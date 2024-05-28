using System.Collections.Generic;

namespace CoolBlog.Models
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterStatus { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
