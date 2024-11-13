namespace IntroProject.Models
{
    public class Comment
    {
        public int Comment_id { get; set; }
        public string Contents { get; set; }
        public int User_id { get; set; }
        public int Post_id { get; set; }
    }
}
