using LoginRegisterWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace LoginRegisterWebAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op) { }
        public DbSet<User>Users { get; set; }
    }
}
