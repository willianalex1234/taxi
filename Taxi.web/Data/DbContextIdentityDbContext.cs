using Microsoft.EntityFrameworkCore;

namespace Taxi.web.Data
{
    public class DbContextIdentityDbContext<T>
    {
        private DbContextOptions<DataContext> options;

        public DbContextIdentityDbContext(DbContextOptions<DataContext> options)
        {
            this.options = options;
        }
    }
}