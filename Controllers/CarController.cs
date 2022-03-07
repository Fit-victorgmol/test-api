using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json; 

namespace API1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        public CarController(){}


        [HttpGet]
        [Route("/obtercarros")]
        public IActionResult GetCars()
        {
            Random rnd = new Random();
            var cars = new[] {
                "corolla",
                "camaro",
                "civic",
                "fiat uno",
                "ford ranger",
                "hilux",
                "s-10",
                "saveira",
                "Mereva",
                "prisma",
                "onix"
                };

            var car = cars[rnd.Next(0,10)];

            var result = JsonSerializer.Serialize(car);

            return Ok(result);
        }

    }
}