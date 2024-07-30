using Dating_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Dating_App.Data
{
    public class DataContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}
