using Microsoft.EntityFrameworkCore;

namespace Taak_CRUD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Animal> animals { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
