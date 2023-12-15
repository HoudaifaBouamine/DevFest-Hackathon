using DevFest.Api.Entities;
using Microsoft.AspNetCore.Mvc;
using static DevFest.Api.Entities.ProjectReadDto;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
/*

#region

var users = new List<User>()
{
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@example.com",
        Identity = "Simple-User",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Jane",
        LastName = "Smith",
        Email = "jane.smith@example.com",
        Identity = "Sponsor",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Houdaifa",
        LastName = "Bouamine",
        Email = "houdaifa.bouamine@example.com",
        Identity = "Developer",
        HashedPassword = "1234"
    },
    // Add 3 more users with similar structure
    // ...
};

var tags = new List<Tag>()
{
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Technology" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Programming" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Open Source" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Database" },
    // Add 7 more tags with similar structure
    // ...
};

var ideas = new List<Idea>()
{
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Open Source Project",
        Description = "A project to contribute to open source development.",
        Status = "In Progress",
    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Web Development Challenge",
        Description = "Create a web application using the latest technologies.",
        Status = "Idea",
    },
    // Add 3 more ideas with similar structure
    // ...
};

var ideaHaveTags = new List<XHaveTag>
{
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[0].Tag_Id,
        X_Id = ideas[0].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[1].Tag_Id,
        X_Id = ideas[0].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[1].Tag_Id,
        X_Id = ideas[1].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[2].Tag_Id,
        X_Id = ideas[1].Idea_Id
    },
};

var projects = new List<Project>()
{
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[0].Idea_Id,
        Title = "The greatest open source project",
        GithubRepoLink = "https://github.com/example/project1",
        Description = "Contribute to an open source project."
    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[1].Idea_Id,
        Title = "web dev",
        GithubRepoLink = "https://github.com/example/project2",
        Description = "Develop a web application."
    },
    // Add 3 more projects with similar structure
    // ...
};

var helps = new List<Help>()
{
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[0].Project_Id,
        Description = "Looking for developers to help with bug fixing.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[1].Project_Id,
        Description = "Need assistance in designing the user interface.",
        StillAvailable = false
    },
    // Add 8 more helps with similar structure
    // ...
};

var helpHaveTags = new List<XHaveTag>
{

    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[0].Help_Id,
        Tag_Id = tags[0].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[0].Help_Id,
        Tag_Id = tags[1].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[1].Help_Id,
        Tag_Id = tags[1].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[1].Help_Id,
        Tag_Id = tags[2].Tag_Id
    },
};

var userInProjects = new List<UserInProject>()
{
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[0].Project_Id,
        User_Id = users[0].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[0].Project_Id,
        User_Id = users[1].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[1].Project_Id,
        User_Id = users[1].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[1].Project_Id,
        User_Id = users[2].User_Id
    },
};

#endregion

*/
/*
#region

var users = new List<User>()
{
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@example.com",
        Identity = "Simple-User",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Jane",
        LastName = "Smith",
        Email = "jane.smith@example.com",
        Identity = "Sponsor",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Houdaifa",
        LastName = "Bouamine",
        Email = "houdaifa.bouamine@example.com",
        Identity = "Developer",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Amina",
        LastName = "Zahra",
        Email = "amina.zahra@example.com",
        Identity = "Tester",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Alex",
        LastName = "Johnson",
        Email = "alex.johnson@example.com",
        Identity = "Designer",
        HashedPassword = "1234"
    }
};

var tags = new List<Tag>()
{
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Technology" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Programming" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Open Source" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Database" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Web Development" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Mobile Development" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "UI/UX Design" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Testing" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Security" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "AI/ML" }
};

var ideas = new List<Idea>()
{
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Open Source Project",
        Description = "A project to contribute to open source development.",
        Status = "In Progress",
    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Web Development Challenge",
        Description = "Create a web application using the latest technologies.",
        Status = "Idea",
    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Mobile App for Social Good",
        Description = "Develop a mobile application to address social issues.",
        Status = "Idea",
    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "AI-powered Security System",
        Description = "Create an AI-based security system for homes.",
        Status = "Idea",
    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Database Optimization Project",
        Description = "Optimize and enhance database performance.",
        Status = "Idea",
    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Idea without project",
        Description = "hahahahaha.",
        Status = "Idea",
    }
};

var ideaHaveTags = new List<XHaveTag>
{
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[0].Tag_Id,
        X_Id = ideas[0].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[1].Tag_Id,
        X_Id = ideas[0].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[1].Tag_Id,
        X_Id = ideas[1].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[2].Tag_Id,
        X_Id = ideas[1].Idea_Id
    },
    // Add more relationships for the additional ideas and tags
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[4].Tag_Id,
        X_Id = ideas[2].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[7].Tag_Id,
        X_Id = ideas[2].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[8].Tag_Id,
        X_Id = ideas[3].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[9].Tag_Id,
        X_Id = ideas[3].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[3].Tag_Id,
        X_Id = ideas[4].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[4].Tag_Id,
        X_Id = ideas[4].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[2].Tag_Id,
        X_Id = ideas[5].Idea_Id
    },
};

var projects = new List<Project>()
{
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[0].Idea_Id,
        Title = "The Greatest Open Source Project",
        GithubRepoLink = "https://github.com/example/project1",
        Description = "Contribute to an open source project."
    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[1].Idea_Id,
        Title = "Web Development",
        GithubRepoLink = "https://github.com/example/project2",
        Description = "Develop a web application."
    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[2].Idea_Id,
        Title = "Social Good App",
        GithubRepoLink = "https://github.com/example/project3",
        Description = "Develop a mobile application for social good."
    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[3].Idea_Id,
        Title = "AI Security System",
        GithubRepoLink = "https://github.com/example/project4",
        Description = "Create an AI-powered security system."
    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[4].Idea_Id,
        Title = "Database Optimization",
        GithubRepoLink = "https://github.com/example/project5",
        Description = "Optimize and enhance database performance."
    }
};

var helps = new List<Help>()
{
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[0].Project_Id,
        Description = "Looking for developers to help with bug fixing.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[1].Project_Id,
        Description = "Need assistance in designing the user interface.",
        StillAvailable = false
    },
    // Add more help entities with similar structure
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[2].Project_Id,
        Description = "Seeking testers for the mobile app project.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[3].Project_Id,
        Description = "Security experts needed for the AI project.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[4].Project_Id,
        Description = "Database administrators required for optimization.",
        StillAvailable = false
    }
};

var helpHaveTags = new List<XHaveTag>
{
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[0].Help_Id,
        Tag_Id = tags[0].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[0].Help_Id,
        Tag_Id = tags[1].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[1].Help_Id,
        Tag_Id = tags[1].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[1].Help_Id,
        Tag_Id = tags[2].Tag_Id
    },
    // Add more relationships for the additional helps and tags
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[2].Help_Id,
        Tag_Id = tags[4].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[2].Help_Id,
        Tag_Id = tags[7].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[3].Help_Id,
        Tag_Id = tags[8].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[3].Help_Id,
        Tag_Id = tags[9].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[4].Help_Id,
        Tag_Id = tags[3].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[4].Help_Id,
        Tag_Id = tags[4].Tag_Id
    }
};

var userInProjects = new List<UserInProject>()
{
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[0].Project_Id,
        User_Id = users[0].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[0].Project_Id,
        User_Id = users[1].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[1].Project_Id,
        User_Id = users[1].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[1].Project_Id,
        User_Id = users[2].User_Id
    },
    // Add more relationships for the additional users and projects
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[2].Project_Id,
        User_Id = users[2].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[2].Project_Id,
        User_Id = users[3].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[3].Project_Id,
        User_Id = users[3].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[3].Project_Id,
        User_Id = users[4].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[4].Project_Id,
        User_Id = users[4].User_Id
    },
    new UserInProject()
    {
        UserInProject_Id = Guid.NewGuid(),
        Project_Id = projects[4].Project_Id,
        User_Id = users[0].User_Id
    }
};

#endregion
*/

#region

var users = new List<User>()
{
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@example.com",
        Identity = "Simple-User",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Jane",
        LastName = "Smith",
        Email = "jane.smith@example.com",
        Identity = "Sponsor",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Houdaifa",
        LastName = "Bouamine",
        Email = "houdaifa.bouamine@example.com",
        Identity = "Developer",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Amina",
        LastName = "Zahra",
        Email = "amina.zahra@example.com",
        Identity = "Content Creator",
        HashedPassword = "1234"
    },
    new User
    {
        User_Id = Guid.NewGuid(),
        FirstName = "Alex",
        LastName = "Johnson",
        Email = "alex.johnson@example.com",
        Identity = "Designer",
        HashedPassword = "1234"
    }
};

var tags = new List<Tag>()
{
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Technology" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Programming" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Peace" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Virtual Reality" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Community Building" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Human Rights" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Journalism" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Digital Storytelling" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Gaming" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Language Translation" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Events" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Data Visualization" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Mapping" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Summits" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Mindfulness" },
    new Tag { Tag_Id = Guid.NewGuid(), Name = "Blockchain" }
};

var ideas = new List<Idea>()
{
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Conflict Resolution App",
        Description = "Develop a mobile or web application that provides tools and resources for conflict resolution, mediation, and peaceful dialogue.",
        Status = "In Progress",
    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Digital Peace Garden",
        Description = "Create a virtual space where users can plant 'seeds of peace' by sharing positive messages, artwork, and stories promoting unity and understanding.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Peace Education Platform",
        Description = "Build an online platform offering courses and educational materials focused on peace studies, conflict resolution, and global citizenship.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Community Building App",
        Description = "Develop a social networking app that connects individuals from different backgrounds to foster understanding, dialogue, and community building.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Virtual Reality for Empathy",
        Description = "Utilize virtual reality technology to create immersive experiences that promote empathy and understanding by allowing users to see the world through others' perspectives.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Crowdsourced Peace Initiatives",
        Description = "Build a platform where people can propose and collaborate on grassroots peace initiatives, and others can support and contribute to these projects.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Human Rights Monitoring App",
        Description = "Create an app that allows users to report human rights violations, discrimination, and injustice, raising awareness and facilitating action.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Online Conflict Journalism Hub",
        Description = "Develop a platform that curates and disseminates unbiased, in-depth journalism focused on global conflicts and peacebuilding efforts.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Digital Storytelling for Peace",
        Description = "Build a website or app where individuals can share personal stories related to peace, tolerance, and overcoming adversity.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Peaceful Gaming Platform",
        Description = "Develop video games that promote conflict resolution, cooperation, and empathy, providing an engaging way to impart peace-related values.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Language Translation for Peace",
        Description = "Create a language translation tool that focuses on promoting accurate and culturally sensitive communication to bridge language gaps and foster understanding.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Peaceful Community Events Calendar",
        Description = "Build an online calendar highlighting local and global events related to peace, encouraging participation and engagement.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Global Conflict Analysis Dashboard",
        Description = "Develop a data visualization platform that analyzes global conflict trends, providing insights into areas that require attention for peacebuilding efforts.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Peaceful Coexistence Mapping",
        Description = "Create a mapping tool that visually represents instances of peaceful coexistence and collaboration among diverse communities globally.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Virtual Peace Summit Platform",
        Description = "Develop a virtual space for hosting peace summits, conferences, and dialogues, bringing together experts, policymakers, and advocates from around the world.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Mindfulness and Meditation App",
        Description = "Create an app that offers guided mindfulness and meditation exercises to promote inner peace and stress reduction.",
        Status = "Idea",

    },
    new Idea
    {
        Idea_Id = Guid.NewGuid(),
        Title = "Blockchain for Peace",
        Description = "Explore the use of blockchain technology for transparent and accountable fundraising for peace initiatives, ensuring that funds reach their intended recipients.",
        Status = "Idea",

    }
};

var ideaHaveTags = new List<XHaveTag>
{
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[0].Tag_Id,
        X_Id = ideas[0].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[1].Tag_Id,
        X_Id = ideas[0].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[1].Tag_Id,
        X_Id = ideas[1].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[2].Tag_Id,
        X_Id = ideas[1].Idea_Id
    },
    // Add more relationships for the additional ideas and tags
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[4].Tag_Id,
        X_Id = ideas[2].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[7].Tag_Id,
        X_Id = ideas[2].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[8].Tag_Id,
        X_Id = ideas[3].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[9].Tag_Id,
        X_Id = ideas[3].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[3].Tag_Id,
        X_Id = ideas[4].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[4].Tag_Id,
        X_Id = ideas[4].Idea_Id
    },
    new XHaveTag
    {
        XHaveTag_Id = Guid.NewGuid(),
        Tag_Id = tags[2].Tag_Id,
        X_Id = ideas[5].Idea_Id
    },
};

var projects = new List<Project>()
{
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[0].Idea_Id,
        Title = "Conflict Resolution App Implementation",
        GithubRepoLink = "https://github.com/example/conflict-resolution-app",
        Description = "Develop a mobile or web application for conflict resolution.",


    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[1].Idea_Id,
        Title = "Digital Peace Garden Platform",
        GithubRepoLink = "https://github.com/example/digital-peace-garden",
        Description = "Create a virtual space for sharing positive messages and artwork.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[2].Idea_Id,
        Title = "Peace Education Platform Development",
        GithubRepoLink = "https://github.com/example/peace-education-platform",
        Description = "Build an online platform for peace studies and global citizenship education.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[3].Idea_Id,
        Title = "Community Building App Implementation",
        GithubRepoLink = "https://github.com/example/community-building-app",
        Description = "Develop a social networking app for fostering understanding and community building.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[4].Idea_Id,
        Title = "Virtual Reality for Empathy Project",
        GithubRepoLink = "https://github.com/example/virtual-reality-empathy",
        Description = "Utilize virtual reality technology for promoting empathy and understanding.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[5].Idea_Id,
        Title = "Crowdsourced Peace Initiatives Platform",
        GithubRepoLink = "https://github.com/example/crowdsourced-peace-initiatives",
        Description = "Build a platform for proposing and collaborating on grassroots peace initiatives.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[6].Idea_Id,
        Title = "Human Rights Monitoring App Development",
        GithubRepoLink = "https://github.com/example/human-rights-monitoring-app",
        Description = "Create an app for reporting human rights violations and discrimination.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[7].Idea_Id,
        Title = "Online Conflict Journalism Hub",
        GithubRepoLink = "https://github.com/example/online-conflict-journalism-hub",
        Description = "Develop a platform for unbiased, in-depth journalism on global conflicts and peacebuilding efforts.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[8].Idea_Id,
        Title = "Digital Storytelling for Peace Platform",
        GithubRepoLink = "https://github.com/example/digital-storytelling-for-peace",
        Description = "Build a website or app for sharing personal stories related to peace and tolerance.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[9].Idea_Id,
        Title = "Peaceful Gaming Platform Development",
        GithubRepoLink = "https://github.com/example/peaceful-gaming-platform",
        Description = "Develop video games that promote conflict resolution and empathy.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[10].Idea_Id,
        Title = "Language Translation for Peace Tool",
        GithubRepoLink = "https://github.com/example/language-translation-for-peace",
        Description = "Create a language translation tool for promoting accurate communication.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[11].Idea_Id,
        Title = "Peaceful Community Events Calendar",
        GithubRepoLink = "https://github.com/example/peaceful-community-events-calendar",
        Description = "Build an online calendar highlighting events related to peace.",

    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[12].Idea_Id,
        Title = "Global Conflict Analysis Dashboard",
        GithubRepoLink = "https://github.com/example/global-conflict-analysis-dashboard",
        Description = "Develop a data visualization platform that analyzes global conflict trends.",
    
    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[13].Idea_Id,
        Title = "Peaceful Coexistence Mapping Tool",
        GithubRepoLink = "https://github.com/example/peaceful-coexistence-mapping",
        Description = "Create a mapping tool representing instances of peaceful coexistence globally.",
    
    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[14].Idea_Id,
        Title = "Virtual Peace Summit Platform Development",
        GithubRepoLink = "https://github.com/example/virtual-peace-summit-platform",
        Description = "Develop a virtual space for hosting peace summits and conferences.",
        
    },
    new Project
    {
        Project_Id = Guid.NewGuid(),
        Idea_Id = ideas[15].Idea_Id,
        Title = "Mindfulness and Meditation App Development",
        GithubRepoLink = "https://github.com/example/mindfulness-meditation-app",
        Description = "Create an app offering guided mindfulness and meditation exercises.",
    
    },
    new Project
    {
    Project_Id = Guid.NewGuid(),
    Idea_Id = ideas[16].Idea_Id,
    Title = "Blockchain for Peace Exploration",
    GithubRepoLink = "https://github.com/example/blockchain-for-peace",
    Description = "Explore the use of blockchain for transparent fundraising for peace initiatives.",
    
    }
};

var helps = new List<Help>()
{
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[0].Project_Id,
        Description = "Looking for developers to help with mobile app development.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[1].Project_Id,
        Description = "Seeking designers and content creators for the virtual peace garden.",
        StillAvailable = false
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[2].Project_Id,
        Description = "In need of educators for developing peace education courses.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[3].Project_Id,
        Description = "Looking for developers and community managers for the community building app.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[4].Project_Id,
        Description = "Seeking VR developers for creating empathy-promoting experiences.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[5].Project_Id,
        Description = "Looking for developers and collaborators for the crowdsourced peace initiatives platform.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[6].Project_Id,
        Description = "In need of app developers for the human rights monitoring app.",
        StillAvailable = true
    },
    new Help
    {
        Help_Id = Guid.NewGuid(),
        Project_Id = projects[7].Project_Id,
        Description = "Seeking journalists and content creators for the online conflict journalism hub.",
        StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[8].Project_Id,
    Description = "Looking for developers and storytellers for the digital storytelling for peace platform.",
    StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[9].Project_Id,
    Description = "Seeking game developers for the peaceful gaming platform.",
    StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[10].Project_Id,
    Description = "In need of developers for the language translation for peace tool.",
    StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[11].Project_Id,
    Description = "Seeking organizers and contributors for the peaceful community events calendar.",
    StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[12].Project_Id,
    Description = "In need of developers and analysts for the global conflict analysis dashboard.",
    StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[13].Project_Id,
    Description = "Seeking developers and mappers for the peaceful coexistence mapping tool.",
    StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[14].Project_Id,
    Description = "In need of organizers and contributors for the virtual peace summit platform.",
    StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[15].Project_Id,
    Description = "Seeking developers and mindfulness experts for the mindfulness and meditation app.",
    StillAvailable = true
    },
    new Help
    {
    Help_Id = Guid.NewGuid(),
    Project_Id = projects[16].Project_Id,
    Description = "Looking for blockchain developers for exploring blockchain for peace.",
    StillAvailable = true
    }
    };

var helpHaveTags = new List<XHaveTag>
{

    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[0].Help_Id,
        Tag_Id = tags[0].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[0].Help_Id,
        Tag_Id = tags[1].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[1].Help_Id,
        Tag_Id = tags[1].Tag_Id
    },
    new XHaveTag()
    {
        XHaveTag_Id = Guid.NewGuid(),
        X_Id = helps[1].Help_Id,
        Tag_Id = tags[2].Tag_Id
    },
};

var userInProjects = new List<UserInProject>()
{
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[2].User_Id,
Project_Id = projects[0].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[0].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[1].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[1].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[2].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[2].User_Id,
Project_Id = projects[2].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[2].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[0].User_Id,
Project_Id = projects[3].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[2].User_Id,
Project_Id = projects[3].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[3].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[4].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[4].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[4].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[0].User_Id,
Project_Id = projects[5].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[2].User_Id,
Project_Id = projects[5].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[5].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[6].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[6].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[7].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[7].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[7].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[8].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[8].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[9].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[9].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[9].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[10].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[10].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[11].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[11].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[11].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[12].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[12].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[12].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[13].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[13].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id =users[4].User_Id,
Project_Id = projects[13].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[14].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[14].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[1].User_Id,
Project_Id = projects[15].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[15].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[4].User_Id,
Project_Id = projects[15].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[0].User_Id,
Project_Id = projects[16].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[2].User_Id,
Project_Id = projects[16].Project_Id
},
new UserInProject
{
UserInProject_Id = Guid.NewGuid(),
User_Id = users[3].User_Id,
Project_Id = projects[16].Project_Id
}
};


#endregion

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.MapPost("/login", ([FromBody] UserLoginDto user) =>
{

    var usersList = User.UsersToDtos(users);

    UserReadDto? userReadDto = usersList.Where(u=>u.Email == user.Email).FirstOrDefault();

    if(userReadDto == null)
    {
        return Results.NotFound("User Not Found");
    }
    else
    {
        return Results.Ok(userReadDto);
    }

});

app.MapPost("/sign_in", ([FromBody] UserCreateDto createDto) =>
{
    var user = new User(createDto);
    users.Add(user);
    // (To Do) Must Verify that email is unique
    return new UserReadDto(user);
});

app.MapGet("/users", () => 
{
    return User.UsersToDtos(users);
});

app.MapGet("/users/{user_Id}", (Guid user_Id) =>
{
    var userRead = User.UsersToDtos(users).Where(u => u.User_Id == user_Id);

    if(userRead == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(userRead);
});

app.MapGet("/", () =>
{
    return "Go to /swagger  for documentation";
});

app.MapGet("/ideas", () =>
{
    return Idea.IdeasToDtos(ideas, projects, userInProjects, users, helps, ideaHaveTags, tags,helpHaveTags);
});

app.MapGet("/ideas/{idea_Id}", (Guid idea_Id) =>
{
    return Idea.IdeasToDtos(ideas, projects, userInProjects, users, helps,ideaHaveTags,tags,helpHaveTags).Where(i=>i.Idea_Id == idea_Id).FirstOrDefault();
});

app.MapPost("/ideas", ([FromBody] IdeaCreateDto idea) =>
{
    var createdIdea = new Idea(idea);
    ideas.Add(createdIdea);

    for(int i =  0; i < idea.Tags.Count;i++)
        ideaHaveTags.Add(new XHaveTag()
        {
            Tag_Id = idea.Tags[i].Tag_Id,
            XHaveTag_Id = Guid.NewGuid(),
            X_Id = createdIdea.Idea_Id
        });;

    return Results.Ok(GetIdeaReadDto(createdIdea));
});

app.MapPost("/projects", ([FromBody] ProjectCreateDto projectCreateDto) =>
{
    if (ideas.Where(i=>i.Idea_Id == projectCreateDto.Idea_Id).Count() == 0)
    {
        return Results.BadRequest("Failed to create project because Idea is not Found");
    }

    if (users.Where(u => u.User_Id == projectCreateDto.Creator_Id).Count() == 0)
    {
        return Results.BadRequest("Failed to create project because User is not Found");
    }

    var projectCreated = new Project(projectCreateDto);
    projects.Add(projectCreated);

    userInProjects.Add(new UserInProject()
    {
        Project_Id = projectCreated.Project_Id,
        UserInProject_Id = Guid.NewGuid(),
        User_Id = projectCreateDto.Creator_Id
    });

    return Results.Ok( GetProjectsReadDtos().Where(p => p.Project_Id == projectCreated.Project_Id).FirstOrDefault() );
});

app.MapGet("/projects", () =>
{
    return GetProjectsReadDtos();
});

app.MapGet("/projects/{project_Id}", (Guid project_Id) =>
{
    var p = GetProjectsReadDtos().Where(p=>p.Project_Id == project_Id);

    if(p == null)
    {
        return Results.NotFound("Project Not Found");
    }
    else
    {
        return Results.Ok(p);
    }
});

app.MapGet("/helps", () =>
{
    return from h in helps select new HelpReadDto(h,helpHaveTags,tags);
});

app.MapGet("/helps/tag/{tag_id}", (Guid tag_id) =>
{
    var help = (from h in helps select new HelpReadDto(h, helpHaveTags, tags)).Where(h => (h.Tags.Where(t=>t.Tag_Id == tag_id).Count() > 0));

    if(help == null)
    {
        return Results.NotFound("Help not found");
    }
    else
    {
        return Results.Ok(help);
    }
});

app.MapPost("/helps", ([FromBody] HelpCreateDto helpCreateDto) =>
{
    if(projects.Where(
        p=>p.Project_Id == helpCreateDto.Project_Id)
        .Count() == 0)
    {
        return Results.NotFound();
    }

    var createdHelp = new Help(helpCreateDto);
    helps.Add(createdHelp);

    foreach(var tag in helpCreateDto.Tags)
        helpHaveTags.Add(new XHaveTag
        {
            XHaveTag_Id = Guid.NewGuid(),
            Tag_Id = tag.Tag_Id,
            X_Id = createdHelp.Help_Id
        });


    return Results.Ok( new HelpReadDto(createdHelp,helpHaveTags,tags) );
});
IdeaReadDto? GetIdeaReadDto(Idea idea)
{
    return Idea.IdeasToDtos(ideas, projects, userInProjects,
        users, helps,
        ideaHaveTags, tags, helpHaveTags)
        .Where(i => i.Idea_Id == idea.Idea_Id)
        .FirstOrDefault();
}

List<ProjectReadDto> GetProjectsReadDtos()
{
    return  (from p in projects
               select new ProjectReadDto(
                   p, userInProjects!, users!,
                   helps!, helpHaveTags!, tags!))
                  .ToList();
}



app.Run("http://localhost:5000");
