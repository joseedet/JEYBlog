using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JEYBlog.Models.Comments;


namespace JEYBlog.ViewModels
{
    public class CommentViewModel
    {
        public class SubComment : Comment
        {
            public int MainCommentId { get; set; }
        }
    }
}
