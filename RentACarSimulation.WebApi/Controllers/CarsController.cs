using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACarSimulation.Service.Cars;

namespace RentACarSimulation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController(ICarService carService) : ControllerBase
    {
        private readonly ICarService _carService = carService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cars = _carService.GetAllDetails();
            return Ok(cars);
        }
    }
}
