using IntroProject.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroProject.Models
{
    public class WFPost
    {
        [Key] public int PostId { get; set; }

        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]

        public virtual ApplicationUser User { get; set; }
        public string Content { get; set; }
        public ICollection<WFComment> Comments { get; set; }

        public WFPost(ApplicationUser user, string content)
        {
            User = user;
            Content = content;
        }

        public WFPost()
        {
        }
    }
}
