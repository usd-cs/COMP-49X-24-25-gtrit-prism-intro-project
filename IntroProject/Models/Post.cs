using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroProject.Models
{
    public class Post
    {
        [Key] public int Post_id { get; set; }
        public string? Contents { get; set; }
        public string? Id { get; set; }

        [ForeignKey("Id")]
        public IdentityUser? User { get; set; }

        //One post can have many comments
        public ICollection<Comment>? Comments { get; set; }

    }
}
