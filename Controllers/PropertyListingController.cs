using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;

namespace PropertyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyListingController : ControllerBase
    {

        private IGenericRepository<PropertyListing> _IgenericRepository;

        PropertyListingService PropertyListing  = null;

        public PropertyListingController(IGenericRepository<PropertyListing> igenericRepository)
        {
            PropertyListing = new PropertyListingService(igenericRepository);
        }

        APIResponse APIResponse = new APIResponse();


        [HttpPost]
        [Route("CreatePropertyListing")]
        public IActionResult CreatePropertyListing(PropertyListing? propertyListing)
        {
            return Ok(PropertyListing.CreatePropertyListing(propertyListing));
        }
        
        [HttpPost]
        [Route("CreatePropertyListingAmenities")]
        public IActionResult CreatePropertyListingAmenities(PropertyListingAmenities propertyListingAmenities)
        {
            return Ok(PropertyListing.CreatePropertyListingAmenities(propertyListingAmenities));
        }
        
        [HttpPost]
        [Route("CreatePropertyImages")]
        public IActionResult CreatePropertyImages(PropertyImages propertyImages)
        {
            return Ok(PropertyListing.CreatePropertyImages(propertyImages));
        }
        
        [HttpPost]
        [Route("DeletePropertyImages")]
        public IActionResult DeletePropertyImages(PropertyImages propertyImages)
        {
            return Ok(PropertyListing.DeletePropertyImages(propertyImages));
        }




        [HttpPost]
        [Route("GetPropertyFilter")]
        public IActionResult GetPropertyFilter(PropertyFilter propertyFilter)
        {
            return Ok(PropertyListing.GetPropertyFilter(propertyFilter));
        }
        
        
        [HttpPost]
        [Route("GetProperties")]
        public IActionResult GetProperties(PropertyListingView propertyListingView)
        {
            return Ok(PropertyListing.GetProperties(propertyListingView));
        }
        
        
        [HttpPost]
        [Route("GetPropertiesAll")]
        public IActionResult GetPropertiesAll(PropertyListingView propertyListingView)
        {
            return Ok(PropertyListing.GetPropertiesAll(propertyListingView));
        }

        [HttpPost]
        [Route("GetPropertyCount")]
        public IActionResult GetPropertyCount(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyCount(propertyListing));
        }             
        
        [HttpPost]
        [Route("GetPropertyByAgent")]
        public IActionResult GetPropertyByAgent(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyByAgent(propertyListing));
        } 
        
        [HttpPost]
        [Route("GetPropertyListingForAgentPortal")]
        public IActionResult GetPropertyListingForAgentPortal(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyListingForAgentPortal(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyListingForHotlisting")]
        public IActionResult GetPropertyListingForHotlisting(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyListingForHotlisting(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetPropertyByLocation")]
        public IActionResult GetPropertyByLocation(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyByLocation(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyByType")]
        public IActionResult GetPropertyByType(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyByType(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyByTypeName")]
        public IActionResult GetPropertyByTypeName(PropertyListingView propertyListing)
        {
            return Ok(PropertyListing.GetPropertyByTypeName(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyDetail")]
        public IActionResult GetPropertyDetail(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyDetail(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetPropertyDetailForMobile")]
        public IActionResult GetPropertyDetailForMobile(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyDetailForMobile(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyByStatus")]
        public IActionResult GetPropertyByStatus(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyByStatus(propertyListing));
        }
        
        [HttpPost]
        [Route("GetRecentProperties")]
        public IActionResult GetRecentProperties(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetRecentProperties(propertyListing));
        }
        
        [HttpPost]
        [Route("GetFeaturedProperties")]
        public IActionResult GetFeaturedProperties(PropertyListingView propertyListing)
        {
            return Ok(PropertyListing.GetFeaturedProperties(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetPropertyAmenities")]
        public IActionResult GetPropertyAmenities(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyAmenities(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyImages")]
        public IActionResult GetPropertyImages(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyImages(propertyListing));
        }
        
        [HttpPost]
        [Route("PropertiesListingConfiguration")]
        public IActionResult PropertiesListingConfiguration(PropertyListingView propertyListingView)
        {
            return Ok(PropertyListing.PropertiesListingConfiguration(propertyListingView));
        }
        
        [HttpPost]
        [Route("ExpireProperty")]
        public IActionResult ExpireProperty(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.ExpireProperty(propertyListing));
        }
        
        [HttpPost]
        [Route("RefreshProperty")]
        public IActionResult RefreshProperty(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.RefreshProperty(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyCountDetail")]
        public IActionResult GetPropertyCountDetail(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetPropertyCountDetail(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetSuperHotlistingProperties")]
        public IActionResult GetSuperHotlistingProperties(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetSuperHotlistingProperties(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetAgentPropertyByStatus")]
        public IActionResult GetAgentPropertyByStatus(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetAgentPropertyByStatus(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetHotlistingProperties")]
        public IActionResult GetHotlistingProperties(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetHotlistingProperties(propertyListing));
        }
        
        /// <summary>
        /// Area Guide 
        /// </summary>
        /// <param name="propertyListing"></param>
        /// <returns></returns>


        [HttpPost]
        [Route("CreateLocationDetail")]
        public IActionResult CreateLocationDetail(LocationDetail locationDetail)
        {
            return Ok(PropertyListing.CreateLocationDetail(locationDetail));
        }
        
        
        [HttpPost]
        [Route("CreateLocationDescription")]
        public IActionResult CreateLocationDescription(Areas areas)
        {
            return Ok(PropertyListing.CreateLocationDescription(areas));
        }
        
        
        
        [HttpPost]
        [Route("GetLocationForAreaGuid")]
        public IActionResult GetLocationForAreaGuid(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetLocationForAreaGuid(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetLocationForAreaGuidMobile")]
        public IActionResult GetLocationForAreaGuidMobile(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetLocationForAreaGuidMobile(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetAreaGuideDetail")]
        public IActionResult GetAreaGuideDetail(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetAreaGuideDetail(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetAreaGuideByPropertyType")]
        public IActionResult GetAreaGuideByPropertyType(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetAreaGuideByPropertyType(propertyListing));
        }


        [HttpPost]
        [Route("GetAreaGuideDetailAndPropertyType")]
        public IActionResult GetAreaGuideDetailAndPropertyType(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetAreaGuideDetailAndPropertyType(propertyListing));
        }
        
        [HttpPost]
        [Route("GetMostViewedCities")]
        public IActionResult GetMostViewedCities(PropertyListing propertyListing)
        {
            return Ok(PropertyListing.GetMostViewedCities(propertyListing));
        }
       
    }
}
