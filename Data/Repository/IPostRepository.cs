using JEYBlog.Models;
using JEYBlog.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JEYBlog.Data.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        List<Post> GetAll(string category);
        // new IQueryable IndexViewModel GetAll(int pageNumber);
        IndexViewModel GetAllPosts(int pageNumber);
        IndexViewModel GetAllPosts(int pageNumber, string category);

    }
}
