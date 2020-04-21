using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CityInfo.API.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>()
                {
                    new { id = 1, Name = "Bucaramanga"},
                    new { id = 2, Name = "Bogota"}
                }
            );
        }
    }
}
