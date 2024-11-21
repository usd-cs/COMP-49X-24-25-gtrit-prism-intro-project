using IntroProject.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroProject.Models
{
    public class WFComment
    {
        [Key] public int CommentId { get; set; }

        public int? PostId { get; set; }

        [ForeignKey(nameof(PostId))]
        public virtual WFPost Post { get; set; }
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]

        public virtual ApplicationUser User { get; set; }

        public string Content { get; set; }

        public WFComment(WFPost post, ApplicationUser user, string content)
        {
            Post = post;
            User = user;
            Content = content;
        }

        public WFComment()
        {
        }
    }
}
