using Microsoft.EntityFrameworkCore;

namespace ApiProject.Models
{
    public class DatabaseContext : DbContext 
    {

        public DbSet<Albums> Album { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }





    }
}
