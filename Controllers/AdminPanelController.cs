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
    public class AdminPanelController : ControllerBase
    {
  

    private IGenericRepository<BaseModel> _IgenericRepository;

    AdminPanelServices adminPanelServices  = null;

    public AdminPanelController(IGenericRepository<BaseModel> igenericRepository)
    {
        adminPanelServices = new AdminPanelServices(igenericRepository);
    }

        [HttpPost]
        [Route("GetAdminPanelStatistics")]
        public IActionResult GetAdminPanelStatistics(BaseModel baseModel)
        {
            return Ok(adminPanelServices.GetAdminPanelStatistics(baseModel));
        } 
        
        
        [HttpPost]
        [Route("GetAdminPanelStatisticsMobile")]
        public IActionResult GetAdminPanelStatisticsMobile(BaseModel baseModel)
        {
            return Ok(adminPanelServices.GetAdminPanelStatisticsMobile(baseModel));
        }
        
        [HttpPost]
        [Route("GetPropertyForApproval")]
        public IActionResult GetPropertyForApproval(BaseModel baseModel)
        {
            return Ok(adminPanelServices.GetPropertyForApproval(baseModel));
        }
        
        [HttpPost]
        [Route("ApproveProperty")]
        public IActionResult ApproveProperty(PropertyListing propertyListing)
        {
            return Ok(adminPanelServices.ApproveProperty(propertyListing));
        }
        
        
        [HttpPost]
        [Route("ApprovePropertyImages")]
        public IActionResult ApprovePropertyImages(PropertyImages propertyImages  )
        {
            return Ok(adminPanelServices.ApprovePropertyImages(propertyImages));
        }
        
        [HttpPost]
        [Route("GetPropertyImagesForApproval")]
        public IActionResult GetPropertyImagesForApproval(PropertyListing propertyListing)
        {
            return Ok(adminPanelServices.GetPropertyImagesForApproval(propertyListing));
        }
        
        [HttpPost]
        [Route("GetSubAdmin")]
        public IActionResult GetSubAdmin(Users users)
        {
            return Ok(adminPanelServices.GetSubAdmin(users));
        }



    }
}
