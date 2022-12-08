using Microsoft.EntityFrameworkCore;

namespace etickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
