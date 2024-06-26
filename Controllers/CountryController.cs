using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;

namespace PropertyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {



        private IGenericRepository<Country> _IgenericRepository;
        private IGenericRepository<DeviceIdentity> _DeviceIgenericRepository;

        CountryServices CountryServices = null;

        public CountryController(IGenericRepository<Country> igenericRepository, IGenericRepository<DeviceIdentity> iDevicegenericRepository)
        {
            CountryServices = new CountryServices(igenericRepository, iDevicegenericRepository);
        }

        APIResponse APIResponse = new APIResponse();

        [HttpPost]
        [Route("GetCountry")]
        public IActionResult GetCountry(Country country)
        {
          return Ok(CountryServices.GetCountry(country));
        }
        
        [HttpPost]
        [Route("GetCities")]
        public IActionResult GetCities(int CountryId)
        {
          return Ok(CountryServices.GetCities(CountryId));
        }
        
        [HttpPost]
        [Route("GetCityIdByName")]
        public IActionResult GetCityIdByName(Cities cities)
        {
          return Ok(CountryServices.GetCityIdByName(cities));
        }
        
        
        [HttpPost]
        [Route("DeviceIdentity")]
        public IActionResult DeviceIdentity(DeviceIdentity deviceIdentity)
        {
          return Ok(CountryServices.DeviceIdentity(deviceIdentity));
        }
        
        [HttpPost]
        [Route("GetAreas")]
        public IActionResult GetAreas(Areas areas)
        {
          return Ok(CountryServices.GetAreas(areas));
        }
        
        
        [HttpPost]
        [Route("GetLocationById")]
        public IActionResult GetLocationById(Areas areas)
        {
          return Ok(CountryServices.GetLocationById(areas));
        }
        
        [HttpPost]
        [Route("GetLocationIdAreaGuide")]
        public IActionResult GetLocationIdAreaGuide(Areas areas)
        {
          return Ok(CountryServices.GetLocationIdAreaGuide(areas));
        }
        
        
        [HttpPost]
        [Route("GetLocationIdByName")]
        public IActionResult GetLocationIdByName(Areas areas)
        {
          return Ok(CountryServices.GetLocationIdByName(areas));
        }
        
        
        [HttpPost]
        [Route("GetLocationDetail")]
        public IActionResult GetLocationDetail(Areas areas)
        {
          return Ok(CountryServices.GetLocationDetail(areas));
        }
        
        
        [HttpPost]
        [Route("GetLocationDetailMobile")]
        public IActionResult GetLocationDetailMobile(Cities cities)
        {
          return Ok(CountryServices.GetLocationDetailMobile(cities));
        }
    }
}
