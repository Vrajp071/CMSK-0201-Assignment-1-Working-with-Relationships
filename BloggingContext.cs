using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Vraj_P_Patel_3154641_Assignment_1
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            var path = AppContext.BaseDirectory;
            Dbpath = Path.Join(path, "UserBlogPost.db");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public string Dbpath { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={Dbpath}");
        }
    }
}
