using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class GummiBearContext : DbContext
    {
        //DbSet<Table> will be set as Table in the SQL database 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public GummiBearContext(DbContextOptions<GummiBearContext> options)
            : base(options)
        {
        }

        public GummiBearContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

    

}

//Next Configure our Startup class for the app to use Entity Framework
