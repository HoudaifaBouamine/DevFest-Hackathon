﻿namespace DevFest.Api.Entities
{
    public class Idea
    {
        public Guid Idea_Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "";

        public static List<IdeaReadDto> IdeasToDtos(List<Idea> ideas,List<Project> projects,
            List<UserInProject> userInProjects, List<User> users,List<Help> helps,
            List<XHaveTag> ideaHaveTags, List<Tag> tags, List<XHaveTag> helpHaveTags)
        {
            return (from i in ideas 
                    select new IdeaReadDto(i, projects,userInProjects,
                    users,helps,ideaHaveTags,tags, helpHaveTags)).ToList();
        }

        public Idea()
        {
            
        }

        public Idea(IdeaCreateDto createDto)
        {
            //Idea_Id = default;
            Idea_Id = Guid.NewGuid();
            Title = createDto.Title;
            Description = createDto.Description;
            Status = createDto.Status;
        }
    }

    public class IdeaCreateDto
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "";
        public List<Tag> Tags { get; set; } = new List<Tag>();

    }

    public class IdeaReadDto
    {
        public Guid Idea_Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "";
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public ProjectReadDto? Project { get; set; } = null;

        public IdeaReadDto(Idea idea,List<Project> projects,List<UserInProject> userInProjects,
            List<User> users,List<Help> helps,
            List<XHaveTag> ideaHaveTags,List<Tag> tags,
            List<XHaveTag> helpHaveTags)
        {
            Idea_Id = idea.Idea_Id;
            Title = idea.Title;
            Description = idea.Description;
            Status = idea.Status;

            Project = (from p in projects 
                       where p.Idea_Id == idea.Idea_Id 
                       select new ProjectReadDto(p,userInProjects,users,helps,helpHaveTags,tags))
                       .FirstOrDefault();

            Tags = (from iht in ideaHaveTags
                    join t in tags
                    on iht.Tag_Id equals t.Tag_Id
                    where iht.X_Id == idea.Idea_Id
                    select t)
                    .ToList();
        
        }
    }

    
}
