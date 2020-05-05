using Microsoft.EntityFrameworkCore; 
namespace Products.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        
        // "users" table is represented by this DbSet "Users"
    //(Convention dictates that the names of these tables is the plural of your Model.) 
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Association> Associations {get;set;}


    }
}