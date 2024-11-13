using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IntroProject.Models
{
    public class Comment
    {
        [Key] public int Comment_id { get; set; }
        public string Contents { get; set; }
        public int User_id { get; set; }
        public int Post_id { get; set; }

        [ForeignKey("User_id")]
        public User User { get; set; }

        [ForeignKey("Post_id")]
        public Post Post { get; set; }
    }
}
