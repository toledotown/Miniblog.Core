namespace Miniblog.Core
{
    public class BlogSettings
    {
        public string Owner { get; set; } = "Steve Flowers";
        public int PostsPerPage { get; set; } = 4;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
