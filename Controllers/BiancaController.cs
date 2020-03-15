using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi_netcore.Models;

namespace webapi_netcore.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BiancaController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public BiancaController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var model = new BiancaModel();

            model.Age = 25;
            model.Name = "Lucas";
            model.CreationDate = DateTime.Now;

            return Ok(model);
        }
    }
}
