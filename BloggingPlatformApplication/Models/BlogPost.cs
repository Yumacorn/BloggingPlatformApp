using System.ComponentModel.DataAnnotations;

namespace BloggingPlatformApplication.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime timestamp_creation { get; }
        public DateTime timestamp_updated { get; }

        // Navigation properties to parent model of User
        public int UserId { get; set; }
        public User User { get; set; }

        public BlogPost()
        {
                
        }
    }
}
