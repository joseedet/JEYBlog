using JEYBlog.Models.Comments;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JEYBlog.Data.Repository
{
    public interface ICommentRepository : IRepository<SubComment>
    {
    }
}
