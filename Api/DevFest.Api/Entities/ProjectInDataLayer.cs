using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using static DevFest.Api.Entities.ProjectInBussinessLayer;

namespace DevFest.Api.Entities
{
    public class ProjectInDataLayer
    {

        public Guid Project_Id { get; set; }
        public Guid Idea_Id { get; set; }
        public string GithubRepoLink { get; set; } = "";
        public string Description { get; set; } = "";
        public string Title { get; set; } = "";

















        public ProjectInDataLayer()
        {
            
        }
        public ProjectInDataLayer(ProjectCreateDto projectCreateDto)
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
        [Key]
        [Column(nameof(UserInProject_Id))]
        public Guid UserInProject_Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Project_Id { get; set; }
    }

    public class ProjectInBussinessLayer
    {
        public Guid Project_Id { get; set; }
        public Guid Idea_Id { get; set; }
        public string GithubRepoLink { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<UserInBusinessLayer> Contributors { get; set; } = new List<UserInBusinessLayer>();
        public List<HelpInBusinessLayer> Helps { get; set; } = new List<HelpInBusinessLayer>();





























        public ProjectInBussinessLayer(ProjectInDataLayer project, List<UserInProject> userInProjects, List<User_DataLayer> users,List<Help> helps,List<XHaveTag> helpHaveTags,List<Tag> tags)
        {
            Project_Id = project.Project_Id;
            Idea_Id = project.Idea_Id;
            GithubRepoLink = project.GithubRepoLink;
            Description = project.Description;
            Contributors = User_DataLayer.UsersToDtos(
                (from uip in userInProjects
                 join u in users
                 on uip.User_Id equals u.User_Id
                 where project.Project_Id == uip.Project_Id
                 select u).ToList()
                ) ;
            Helps = (from h in helps where h.Project_Id == project.Project_Id select new HelpInBusinessLayer( h,helpHaveTags,tags ) ).ToList();
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
