using DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CarEntity> Cars { get; set; }
    }
}
