using IntroProject.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroProject.Models
{
    public class WFComment
    {
        public int CommentId { get; set; }

        public int? PostId { get; set; }

        [ForeignKey(nameof(PostId))]

        public virtual WFPost Post { get; set; }

        public string Content { get; set; }

        public virtual ApplicationUser User { get; set; }

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
