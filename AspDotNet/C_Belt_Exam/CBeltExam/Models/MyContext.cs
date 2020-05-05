using Microsoft.EntityFrameworkCore; 
namespace CBeltExam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Sport> Sports {get;set;}
        public DbSet<Association> Associations {get;set;}
        
        
    }
}