using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroProject.Models
{
    public class Comment
    {
        [Key] public int Comment_id { get; set; }
        public string? Contents { get; set; }
        public string? Id { get; set; }
        public int Post_id { get; set; }

        [ForeignKey("Id")]
        public IdentityUser? User { get; set; }

        [ForeignKey("Post_id")]
        public Post? Post { get; set; }
    }
}
