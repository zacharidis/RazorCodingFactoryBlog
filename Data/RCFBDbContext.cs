using Microsoft.EntityFrameworkCore;
using RazorCodingFactoryBlog.Models.Domain;

namespace RazorCodingFactoryBlog.Data
{
    public class RCFBDbContext : DbContext
    {
        public RCFBDbContext(DbContextOptions options) : base(options)
        {
        
        }


        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }













    }
}
