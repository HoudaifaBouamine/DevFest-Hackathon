namespace DevFest.Api.Entities
{
    public class Tag
    {
        public Guid Tag_Id { get; set; }
        public string Name { get; set; } = "";
    }

    public class XHaveTag
    {
        // Used to link between a Tag and an object from other tag (help or idea)
        public Guid XHaveTag_Id { get; set; }
        public Guid X_Id { get; set; }
        public Guid Tag_Id { get; set; }

    }
}
