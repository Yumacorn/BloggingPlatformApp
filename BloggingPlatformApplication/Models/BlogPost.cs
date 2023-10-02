using System.ComponentModel.DataAnnotations;

namespace BloggingPlatformApplication.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Content")]
        public string Content { get; set; }
        public DateTimeOffset? timestamp_creation = DateTimeOffset.Now;
        public DateTimeOffset? timestamp_updated = DateTimeOffset.Now;

        // Navigation properties to parent model of User
        [Required(ErrorMessage = "Please set UserId")]
        public int UserId { get; set; }
        public User? User { get; set; }

        public BlogPost()
        {
                
        }
    }
}
