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
    public class PropertyCategoryController : ControllerBase
    {
        private IGenericRepository<PropertyCategory> _IgenericRepository;

        PropertyCategoryService PropertyCategoryService  = null;
        
        APIResponse APIResponse = new APIResponse();
        public PropertyCategoryController(IGenericRepository<PropertyCategory> igenericRepository)
        {
            PropertyCategoryService = new PropertyCategoryService(igenericRepository);
        }

        [HttpPost]
        [Route("CreateUpdatePropertyCategory")]
        public IActionResult CreateUpdatePropertyCategory(PropertyCategory propertyCategory )
        {
            return Ok(PropertyCategoryService.CreateUpdatePropertyCategory(propertyCategory));
        }
        
        [HttpPost]
        [Route("GetPropertyCategory")]
        public IActionResult GetPropertyCategory(PropertyCategory propertyCategory )
        {
            return Ok(PropertyCategoryService.GetPropertyCategory(propertyCategory));
        }
        
        
        //[HttpPost]
        //[Route("GetPropertyCategoryMobile")]
        //public IActionResult GetPropertyCategoryMobile(PropertyCategory propertyCategory )
        //{
        //    return Ok(PropertyCategoryService.GetPropertyCategoryMobile(propertyCategory));
        //}
        
        [HttpPost]
        [Route("GetPropertyCategoryById")]
        public IActionResult GetPropertyCategoryById(PropertyCategory propertyCategory )
        {
            return Ok(PropertyCategoryService.GetPropertyCategoryById(propertyCategory));
        }
        
        [HttpPost]
        [Route("DeletePropertyCategory")]
        public IActionResult DeletePropertyCategory(PropertyCategory propertyCategory )
        {
            return Ok(PropertyCategoryService.DeletePropertyCategory(propertyCategory));
        }


    }
}
