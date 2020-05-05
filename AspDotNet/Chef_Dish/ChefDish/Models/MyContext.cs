using Microsoft.EntityFrameworkCore; 
namespace ChefDish.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        
        // "users" table is represented by this DbSet "Users"
    //(Convention dictates that the names of these tables is the plural of your Model.) 
        public DbSet<Chef> Chefs {get;set;}
        public DbSet<Dish> Dishes {get;set;}
    }
}