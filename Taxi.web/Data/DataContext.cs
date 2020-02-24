using Microsoft.EntityFrameworkCore;
using Taxi.web.Data.Entities;

namespace Taxi.web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<TaxiEntity> Taxis { get; set; }
    }
}
