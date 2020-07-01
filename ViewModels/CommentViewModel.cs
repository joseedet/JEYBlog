using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JEYBlog.Models.Comments;


namespace JEYBlog.ViewModels
{
    public class CommentViewModel
    {
        public class SubComment : Comment
        {
            [Required]
            public int PostId { get; set; }

            [Required]
            public int MainCommentId { get; set; }

            [Required]
            public string Message { get; set; }
        }
    }
}
