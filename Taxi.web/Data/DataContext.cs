using Microsoft.EntityFrameworkCore;
using Taxi.web.Data.Entities;
using Taxi.Web.Data.Entities;

namespace Taxi.web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<TaxiEntity> Taxis { get; set; }
        public DbSet<TripEntity> Trips { get; set; }
        public DbSet<TripDetailEntity> TripDetails { get; set; }

    }
}
