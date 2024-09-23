using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using RentACarSimulation.Repository;
using RentACarSimulation.Repository.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace RentACarSimulation.Service.Cars
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly AppDbContext _context;
        public CarService(ICarRepository carRepository, AppDbContext context)
        {
            _carRepository = carRepository;
            _context = context;
        }

        public List<CarDetailDto> GetAllDetails()
        {
            var result =
            from ca in _context.Cars
            join co in _context.Colors on ca.ColorId equals co.Id
            join fu in _context.Fuels on ca.FuelId equals fu.Id
            join tr in _context.Transmissions on ca.TransmissionId equals tr.Id
            select new CarDetailDto(
                ca.Id,
                fu.Name,
                tr.Name,
                co.Name,
                ca.CarState,
                ca.KiloMeter ?? 0,
                ca.ModelYear ?? 0,
                ca.Plate,
                ca.BrandName,
                ca.ModelName,
                ca.DailyPrice ?? 0
            );
            return result.ToList();

            //var result =
            //    from ca in _context.Cars
            //    join co in _context.Colors on ca.ColorId equals co.Id
            //    join fu in _context.Fuels on ca.FuelId equals fu.Id
            //    join tr in _context.Transmissions on ca.TransmissionId equals tr.Id
            //    select new CarDetailDto(
            //        Id: ca.Id,
            //        FuelName: fu.Name,
            //        TransmissionName: tr.Name,
            //        ColorName: co.Name,
            //        CarState: ca.CarState,
            //        KiloMeter: ca.KiloMeter ?? 0,
            //        ModelYear: ca.ModelYear ?? 0,
            //        Plate: ca.Plate,
            //        BrandName: ca.BrandName,
            //        ModelName: ca.ModelName,
            //        DailyPrice: ca.DailyPrice ?? 0
            //        );
            // return result.ToList();
        }

        public List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllDetailsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllDetailsByFuelId(int fuelId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max)
        {
            throw new NotImplementedException();
        }

        public CarDetailDto? GetDetailById(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
