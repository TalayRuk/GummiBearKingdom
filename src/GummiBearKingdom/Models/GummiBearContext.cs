using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class GummiBearContext : DbContext
    {
        //Generate Context Constructor
        public GummiBearContext()
        {
        }

        //DbSet<Table> will be set as Table in the SQL database 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        //setup the db connection to Sqlserver
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummiBearKingdom;integrated security=True");
        }
        public GummiBearContext(DbContextOptions<GummiBearContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

    

}

//Next Configure our Startup class for the app to use Entity Framework
