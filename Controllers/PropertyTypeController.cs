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
    public class PropertyTypeController : ControllerBase
    {
        private IGenericRepository<PropertyType> _IgenericRepository;

        PropertyTypeService PropertyTypeService  = null;

        APIResponse APIResponse = new APIResponse();
        public PropertyTypeController(IGenericRepository<PropertyType> igenericRepository)
        {
            PropertyTypeService = new PropertyTypeService(igenericRepository);
        }

        [HttpPost]
        [Route("CreateUpdatePropertyType")]
        public IActionResult CreateUpdatePropertyType(PropertyType propertyType)
        {
            return Ok(PropertyTypeService.CreateUpdatePropertyType(propertyType));
        }

        [HttpPost]
        [Route("GetPropertyType")]
        public IActionResult GetPropertyType(PropertyType propertyType)
        {
            return Ok(PropertyTypeService.GetPropertyType(propertyType));
        }

        [HttpPost]
        [Route("GetPropertyTypeById")]
        public IActionResult GetPropertyTypeById(PropertyType propertyType)
        {
            return Ok(PropertyTypeService.GetPropertyTypeById(propertyType));
        }
        
        
        [HttpPost]
        [Route("GetPropertyTypeByName")]
        public IActionResult GetPropertyTypeByName(PropertyType propertyType)
        {
            return Ok(PropertyTypeService.GetPropertyTypeByName(propertyType));
        }
        
        [HttpPost]
        [Route("GetPropertyTypeByPropertyCategory")]
        public IActionResult GetPropertyTypeByPropertyCategory(PropertyType propertyType)
        {
            return Ok(PropertyTypeService.GetPropertyTypeByPropertyCategory(propertyType));
        }
        
        
        [HttpPost]
        [Route("GetPropertyTypeByPropertyCategoryMobile")]
        public IActionResult GetPropertyTypeByPropertyCategoryMobile(PropertyType propertyType)
        {
            return Ok(PropertyTypeService.GetPropertyTypeByPropertyCategoryMobile(propertyType));
        }

        [HttpPost]
        [Route("DeletePropertyType")]
        public IActionResult DeletePropertyType(PropertyType propertyType)
        {
            return Ok(PropertyTypeService.DeletePropertyType(propertyType));
        }

    }
}
