using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroProject.Models
{
    public class Post
    {
        [Key] public int Post_id { get; set; }
        public string? Contents { get; set; }
        public int User_id { get; set; }

        [ForeignKey("User_id")]
        public User? User { get; set; }

        //One post can have many comments
        public ICollection<Comment>? Comments { get; set; }

    }
}
