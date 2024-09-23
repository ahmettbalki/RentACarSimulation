using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarSimulation.Service.Cars
{
    public interface ICarService
    {
        List<CarDetailDto> GetAllDetails();
        List<CarDetailDto> GetAllDetailsByFuelId(int fuelId);
        List<CarDetailDto> GetAllDetailsByColorId(int colorId);
        List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max);
        List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName);
        List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName);
        CarDetailDto? GetDetailById(int categoryId);
        List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max);
    }
}
