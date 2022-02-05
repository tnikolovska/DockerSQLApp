using Microsoft.EntityFrameworkCore;

namespace DockerSqlApp.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Film> Films { get; set; }  

    }
}
