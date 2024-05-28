using System;

namespace CoolBlog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
    }
}
