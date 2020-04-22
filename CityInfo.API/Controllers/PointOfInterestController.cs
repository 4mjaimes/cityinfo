using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Controller]
    [Route("api/cities/{cityId}/pointofinterest")]
    public class PointOfInterestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPointOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
                return NotFound();

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
                return NotFound();

            var pointOfInterest = city.PointsOfInterest
                                 .FirstOrDefault(p => p.Id == id);

            if (pointOfInterest == null)
                return NotFound();

            return Ok(pointOfInterest);
        }
    }
}
