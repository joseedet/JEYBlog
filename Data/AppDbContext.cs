

using Microsoft.EntityFrameworkCore;
using JEYBlog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using JEYBlog.Models.Comments;

namespace JEYBlog.Data
{
    public class AppDbContext: IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet <Post> Posts { get; set; }
        public DbSet<MainComment> MainComments { get; set; }
        public DbSet<SubComment> SubComments { get; set; }


    }
}
