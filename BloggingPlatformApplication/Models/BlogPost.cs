namespace BloggingPlatformApplication.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime timestamp_creation { get; set; }
        public DateTime timestamp_updated { get; set;}

    }
}
