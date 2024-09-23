using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarSimulation.Service.Cars
{
    public record CarDto
    (
            int Id,
            int ColorId,
            int FuelId,
            int TransmissionId,
            string CarState,
            int KiloMeter,
            short ModelYear,
            string Plate,
            string BrandName,
            string ModelName,
            double DailyPrice
        );
}
