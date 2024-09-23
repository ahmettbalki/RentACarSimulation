namespace RentACarSimulation.Repository.Cars
{
    public class CarRepository(AppDbContext context) : GenericRepository<Car>(context), ICarRepository
    {
    }
}
