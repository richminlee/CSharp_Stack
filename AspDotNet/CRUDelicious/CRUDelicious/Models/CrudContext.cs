using Microsoft.EntityFrameworkCore; 
namespace CRUDelicious.Models
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes {get;set;}
    }
}