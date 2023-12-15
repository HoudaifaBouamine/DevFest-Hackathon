using System.Security.Principal;
using static DevFest.Api.Entities.ProjectReadDto;

namespace DevFest.Api.Entities
{
    public class Project
    {
        public Guid Project_Id { get; set; }
        public Guid Idea_Id { get; set; }
        public string GithubRepoLink { get; set; } = "";
        public string Description { get; set; } = "";
        public string Title { get; set; } = "";

        public Project()
        {
            
        }
        public Project(ProjectCreateDto projectCreateDto)
        {
            Project_Id = Guid.NewGuid();
            Idea_Id = projectCreateDto.Idea_Id;
            GithubRepoLink = projectCreateDto.GithubRepoLink;
            Description = projectCreateDto.Description;
            Title = projectCreateDto.Title;
        }

    }

    public class UserInProject
    {
        // User to link between users and projects to create M to M relation (Project have many contrubuters but c)
        public Guid UserInProject_Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Project_Id { get; set; }
    }

    public class ProjectReadDto
    {
        public Guid Project_Id { get; set; }
        public Guid Idea_Id { get; set; }
        public string GithubRepoLink { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<UserReadDto> Contributors { get; set; } = new List<UserReadDto>();
        public List<HelpReadDto> Helps { get; set; } = new List<HelpReadDto>();

        public ProjectReadDto(Project project, List<UserInProject> userInProjects, List<User> users,List<Help> helps,List<XHaveTag> helpHaveTags,List<Tag> tags)
        {
            Project_Id = project.Project_Id;
            Idea_Id = project.Idea_Id;
            GithubRepoLink = project.GithubRepoLink;
            Description = project.Description;
            Contributors = User.UsersToDtos(
                (from uip in userInProjects
                 join u in users
                 on uip.User_Id equals u.User_Id
                 where project.Project_Id == uip.Project_Id
                 select u).ToList()
                ) ;
            Helps = (from h in helps where h.Project_Id == project.Project_Id select new HelpReadDto( h,helpHaveTags,tags ) ).ToList();
            Title = project.Title;
        }

        public class ProjectCreateDto
        {
            public Guid Idea_Id { get; set; }
            public Guid Creator_Id { get; set; }
            public string GithubRepoLink { get; set; } = "";
            public string Title { get; set; } = "";
            public string Description { get; set; } = "";

        }

    }
}
