using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JEYBlog.Models.Comments
{
    public class SubComment
    {
        public int Id { get; set; }
        public int MainCommentId { get; set; }
    }
}
