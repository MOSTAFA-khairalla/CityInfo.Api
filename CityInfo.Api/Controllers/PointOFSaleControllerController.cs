using CityInfo.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/{cityid}")]
    [ApiController]
    public class PointOFSaleControllerController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointofinterestDto>> Getpointsofinterests(int cityid)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(a => a.Id == cityid);

            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.Pointofinterests);
        }

        [HttpGet("{pointofinterestid}")]

        public ActionResult<PointofinterestDto> GetPointOfInterest(
            int cityid ,  int pointofinterestid)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(a => a.Id == cityid);
            if (city == null)
            {
                return NotFound();
            }
            var pointofinterests = city.Pointofinterests.FirstOrDefault(a => a.Id == pointofinterestid);

            if (pointofinterests == null)
            {
                return NotFound();
            }
            return Ok(pointofinterests);
        }
    }
}
