﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarSimulation.Service.Cars
{
    public record CarDetailDto
        (
            int Id,
            string FuelName,
            string TransmissionName,
            string ColorName,
            string CarState,
            int KiloMeter,
            short ModelYear,
            string Plate,
            string BrandName,
            string ModelName,
            double DailyPrice
        );
}
