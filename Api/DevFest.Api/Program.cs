using DevFest.Api.Data;
using DevFest.Api.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Security.Principal;
using static DevFest.Api.Entities.ProjectReadDto;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin();
            builder.AllowAnyHeader();
            builder.AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.MapPost("/login", ([FromBody] UserLoginDto user, AppDbContext db) =>
{
    User? theUser = db.Users.ToList().Where(u=>u.Email == user.Email).FirstOrDefault();

    if (theUser is null || theUser.HashedPassword != user.Password)  // the password must be hashed in the real program
    {
        return Results.BadRequest("Failed To Login (Email does not exist or password is wrong)");
    }

    UserReadDto userReadDto = new UserReadDto(theUser);

    return Results.Ok(userReadDto);
});

app.MapPost("/sign_in", ([FromBody] UserCreateDto createDto, AppDbContext db) =>
{
    var user = new User(createDto);
    db.Users.Add(user);
    // (To Do) Must Verify that email is unique

    db.SaveChanges();
    return new UserReadDto(user);
});

app.MapGet("/Users",(AppDbContext db) => 
{
    return User.UsersToDtos(db.Users.ToList());
});

app.MapGet("/Users/{user_Id}", (Guid user_Id, AppDbContext db) =>
{
    var userRead = User.UsersToDtos(db.Users.ToList()).Where(u => u.User_Id == user_Id);

    if(userRead == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(userRead);
});

app.MapPut("/users", ([FromBody] UserUpdateDto userUpdate,AppDbContext db) =>
{
    var user = db.Users.Where(u=>u.User_Id == userUpdate.User_Id).FirstOrDefault();

    if(user is null)
    {
        return Results.NotFound("The User you want to update");
    }

    user.FirstName = userUpdate.FullName.Split(" ")[0];
    user.LastName = userUpdate.FullName.Split(" ")[1];
    user.Email = userUpdate.Email;
    user.Identity = userUpdate.Identity;
    
    db.Users.Update(user);

    db.SaveChanges();

    return Results.Ok(user);
});


app.MapGet("/",(AppDbContext db) =>
{
    return "Go to /swagger  for documentation";
});

app.MapGet("/ideas",(AppDbContext db) =>
{
    return Idea.IdeasToDtos(db.Ideas.ToList(), db.Projects.ToList(), db.UserInProjects.ToList(), db.Users.ToList(), db.Helps.ToList(), db.XHaveTags.ToList(), db.Tags.ToList(),db.XHaveTags.ToList());
});

app.MapGet("/ideas/{idea_Id}", (Guid idea_Id,AppDbContext db) =>
{
    return Idea.IdeasToDtos(db.Ideas.ToList(), db.Projects.ToList(), db.UserInProjects.ToList(), db.Users.ToList(), db.Helps.ToList(),db.XHaveTags.ToList(),db.Tags.ToList(),db.XHaveTags.ToList()).Where(i=>i.Idea_Id == idea_Id).FirstOrDefault();
});

app.MapPost("/ideas", ([FromBody] IdeaCreateDto idea, AppDbContext db) =>
{
    if (db.Users.ToList().Where(u=>u.User_Id == idea.Suggester_Id).Count() == 0)
    {
        return Results.BadRequest("Failed to create idea because the User is not found (user guid is wrong)");
    }

    var createdIdea = new Idea(idea);
    db.Ideas.Add(createdIdea);

    for(int i =  0; i < idea.Tags.Count;i++)
        db.XHaveTags.Add(new XHaveTag()
        {
            Tag_Id = idea.Tags[i].Tag_Id,
            XHaveTag_Id = Guid.NewGuid(),
            X_Id = createdIdea.Idea_Id
        });;

    db.SaveChanges();

    return Results.Ok(GetIdeaReadDto(createdIdea, db));
});

app.MapPost("/Projects", ([FromBody] ProjectCreateDto projectCreateDto, AppDbContext db) =>
{
    if (db.Ideas.ToList().Where(i=>i.Idea_Id == projectCreateDto.Idea_Id).Count() == 0)
    {
        return Results.BadRequest("Failed to create project because Idea is not Found");
    }

    if (db.Users.ToList().Where(u => u.User_Id == projectCreateDto.Creator_Id).Count() == 0)
    {
        return Results.BadRequest("Failed to create project because User is not Found");
    }

    var projectCreated = new Project(projectCreateDto);
    db.Projects.Add(projectCreated);

    db.UserInProjects.Add(new UserInProject()
    {
        Project_Id = projectCreated.Project_Id,
        UserInProject_Id = Guid.NewGuid(),
        User_Id = projectCreateDto.Creator_Id
    });

    db.SaveChanges();


    return Results.Ok( GetProjectsReadDtos(db).Where(p => p.Project_Id == projectCreated.Project_Id).FirstOrDefault() );
});

app.MapGet("/Projects",(AppDbContext db) =>
{
    return GetProjectsReadDtos(db);
});

app.MapGet("/Projects/{project_Id}", (Guid project_Id, AppDbContext db) =>
{
    var p = GetProjectsReadDtos(db).Where(p=>p.Project_Id == project_Id);

    if(p == null)
    {
        return Results.NotFound("Project Not Found");
    }
    else
    {
        return Results.Ok(p);
    }
});

app.MapGet("/helps",(AppDbContext db) =>
{
    return from h in db.Helps.ToList() select new HelpReadDto(h,db.XHaveTags.ToList(),db.Tags.ToList());
});

app.MapGet("/helps/tag/{tag_id}", (Guid tag_id,AppDbContext db) =>
{
    var help = (from h in db.Helps.ToList() select new HelpReadDto(h, db.XHaveTags.ToList(), db.Tags.ToList())).Where(h => (h.Tags.Where(t=>t.Tag_Id == tag_id).Count() > 0));

    if(help == null)
    {
        return Results.NotFound("Help not found");
    }
    else
    {
        return Results.Ok(help);
    }
});

app.MapPost("/helps", ([FromBody] HelpCreateDto helpCreateDto, AppDbContext db) =>
{
    if(db.Projects.ToList().Where(
        p=>p.Project_Id == helpCreateDto.Project_Id)
        .Count() == 0)
    {
        return Results.NotFound();
    }

    var createdHelp = new Help(helpCreateDto);
    db.Helps.Add(createdHelp);

    foreach(var tag in helpCreateDto.Tags)
        db.XHaveTags.Add(new XHaveTag
        {
            XHaveTag_Id = Guid.NewGuid(),
            Tag_Id = tag.Tag_Id,
            X_Id = createdHelp.Help_Id
        });

    db.SaveChanges();

    return Results.Ok( new HelpReadDto(createdHelp,db.XHaveTags.ToList(),db.Tags.ToList()) );
});


IdeaReadDto? GetIdeaReadDto(Idea idea, AppDbContext db)
{
    return Idea.IdeasToDtos(db.Ideas.ToList(), db.Projects.ToList(), db.UserInProjects.ToList(),
        db.Users.ToList(), db.Helps.ToList(),
        db.XHaveTags.ToList(), db.Tags.ToList(), db.XHaveTags.ToList())
        .Where(i => i.Idea_Id == idea.Idea_Id)
        .FirstOrDefault();
}
List<ProjectReadDto> GetProjectsReadDtos(AppDbContext db)
{
    return  (from p in db.Projects.ToList()
               select new ProjectReadDto(
                   p, db.UserInProjects.ToList()!, db.Users.ToList()!,
                   db.Helps.ToList()!, db.XHaveTags.ToList()!, db.Tags.ToList()!))
                  .ToList();
}



app.Run("http://localhost:5000");
