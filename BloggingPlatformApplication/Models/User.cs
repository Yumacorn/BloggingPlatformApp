using System.ComponentModel.DataAnnotations;

namespace BloggingPlatformApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Username { get; set; }
        
        public string Email { get; set; }


        // Navigation properties to dependent child model of BlogPosts
        public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();

        public User()
        {               
        }
    }
}
