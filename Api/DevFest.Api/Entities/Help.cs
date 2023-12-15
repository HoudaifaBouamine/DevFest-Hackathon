namespace DevFest.Api.Entities
{
    public class Help
    {
        public Guid Help_Id { get; set; }
        public Guid Project_Id { get; set; }
        public string Description { get; set; } = "";
        public bool StillAvailable { get; set; } = true;

        public Help()
        {
            
        }
        public Help(HelpCreateDto helpCreate)
        {
            Help_Id = Guid.NewGuid();
            Project_Id = helpCreate.Project_Id;
            Description = helpCreate.Description;
            StillAvailable = helpCreate.StillAvailable;
        }
    }

    public class HelpReadDto
    {
        public Guid Help_Id { get; set; }
        public Guid Project_Id { get; set; }
        public string Description { get; set; } = "";
        public bool StillAvailable { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();

        public HelpReadDto(Help help,List<XHaveTag> helpHaveTags,List<Tag> tags) 
        {
            Help_Id = help.Help_Id;
            Project_Id = help.Project_Id;
            Description = help.Description;
            StillAvailable = help.StillAvailable;
            Tags = (from t in tags join hht in helpHaveTags
                   on t.Tag_Id equals hht.Tag_Id
                   where hht.X_Id == help.Help_Id
                   select t).ToList();

        }
    }

    public class HelpCreateDto
    {
        public Guid Project_Id { get; set; }
        public string Description { get; set; } = "";
        public bool StillAvailable { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();

    }


}
