using Microsoft.EntityFrameworkCore;
using RentACarSimulation.Repository.Cars;
using RentACarSimulation.Repository.Colors;
using RentACarSimulation.Repository.Fuels;
using RentACarSimulation.Repository.Transmissions;

namespace RentACarSimulation.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
    }
}
