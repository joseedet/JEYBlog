using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JEYBlog.Models.Comments;

namespace JEYBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public string Image { get; set; } = "";
        public string Description { get; set; } = "";
        public string Tags { get; set; } = "";
        public string Category { get; set; } = "";
        public DateTime Craated { get; set; } = DateTime.Now;
        public List <MainComment> MainComments { get; set; }
    }
}
