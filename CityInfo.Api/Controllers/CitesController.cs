using CityInfo.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitesController : ControllerBase
    {

        [HttpGet("cityid")]
        public ActionResult<IEnumerable<CityDto>> GetCites()
        {

            return Ok (

                   CitiesDataStore.Current.Cities
           );

        }

        [HttpGet("id")]
    
        public ActionResult<CityDto> GetCity(int id)
        {
            var cityreturn = CitiesDataStore.Current.Cities.FirstOrDefault(a => a.Id == id);
            if (cityreturn == null)
            {
                return NotFound();
            }
            return Ok(cityreturn);
        }
    }
}
