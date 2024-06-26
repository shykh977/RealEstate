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
    public class KarsazController : ControllerBase
    {


        private IGenericRepository<Karsaz> _IgenericRepository;

        KarsazService karsazService  = null;

        public KarsazController(IGenericRepository<Karsaz> igenericRepository)
        {
            karsazService = new KarsazService(igenericRepository);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="karsazCategories"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateKarsazCategory")]
        public IActionResult CreateKarsazCategory(KarsazCategories karsazCategories)
        {
            return Ok(karsazService.CreateKarsazCategory(karsazCategories));
        }
        
        
        
        [HttpPost]
        [Route("GetKarsazCategory")]
        public IActionResult GetKarsazCategory(KarsazCategories karsazCategories)
        {
            return Ok(karsazService.GetKarsazCategory(karsazCategories));
        }
        
        
        
        [HttpPost]
        [Route("GetKarsazCategoryById")]
        public IActionResult GetKarsazCategoryById(KarsazCategories karsazCategories)
        {
            return Ok(karsazService.GetKarsazCategoryById(karsazCategories));
        }
        
        
        
        [HttpPost]
        [Route("DeleteKarsazCategory")]
        public IActionResult DeleteKarsazCategory(KarsazCategories karsazCategories)
        {
            return Ok(karsazService.DeleteKarsazCategory(karsazCategories));
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="karsaz"></param>
        /// <returns></returns>
        
        
        [HttpPost]
        [Route("CreateKarsaz")]
        public IActionResult CreateKarsaz(Karsaz karsaz )
        {
            return Ok(karsazService.CreateKarsaz(karsaz));
        }
        
        
        [HttpPost]
        [Route("GetKarsaz")]
        public IActionResult GetKarsaz(Karsaz karsaz)
        {
            return Ok(karsazService.GetKarsaz(karsaz));
        }
        
        [HttpPost]
        [Route("GetKarsazByCategory")]
        public IActionResult GetKarsazByCategory(Karsaz karsaz)
        {
            return Ok(karsazService.GetKarsazByCategory(karsaz));
        }
        
        [HttpPost]
        [Route("GetTeammatesSearchFilter")]
        public IActionResult GetTeammatesSearchFilter(TeammatesSearchFilter teammatesSearchFilter)
        {
            return Ok(karsazService.GetTeammatesSearchFilter(teammatesSearchFilter));
        }
        
        [HttpPost]
        [Route("GetKARIGEERSearchFilter")]
        public IActionResult GetKARIGEERSearchFilter(TeammatesSearchFilter teammatesSearchFilter)
        {
            return Ok(karsazService.GetKARIGEERSearchFilter(teammatesSearchFilter));
        }
        
        [HttpPost]
        [Route("GetKarsazById")]
        public IActionResult GetKarsazById(Karsaz karsaz)
        {
            return Ok(karsazService.GetKarsazById(karsaz));
        }
        
        [HttpPost]
        [Route("DeleteKarsaz")]
        public IActionResult DeleteKarsaz(Karsaz karsaz)
        {
            return Ok(karsazService.DeleteKarsaz(karsaz));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="karsazDetail"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("CreateKarsazDetail")]
        public IActionResult CreateKarsazDetail(KarsazDetail karsazDetail  )
        {
            return Ok(karsazService.CreateKarsazDetail(karsazDetail));
        }
        
        
        [HttpPost]
        [Route("GetKarsazDetail")]
        public IActionResult GetKarsazDetail(Karsaz karsaz)
        {
            return Ok(karsazService.GetKarsazDetail(karsaz));
        } 
        
        
        [HttpPost]
        [Route("GetKarsazDetailMobile")]
        public IActionResult GetKarsazDetailMobile(Karsaz karsaz)
        {
            return Ok(karsazService.GetKarsazDetailMobile(karsaz));
        }
        
        
        [HttpPost]
        [Route("GetKarsazDetailById")]
        public IActionResult GetKarsazDetailById(KarsazDetail karsaz)
        {
            return Ok(karsazService.GetKarsazDetailById(karsaz));
        }
        
        [HttpPost]
        [Route("DeleteKarsazDetail")]
        public IActionResult DeleteKarsazDetail(KarsazDetail karsaz)
        {
            return Ok(karsazService.DeleteKarsazDetail(karsaz));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="karsazDetailDescription"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("CreateKarsazDetailDescription")]
        public IActionResult CreateKarsazDetailDescription(KarsazDetailDescription karsazDetail)
        {
            return Ok(karsazService.CreateKarsazDetailDescription(karsazDetail));
        }
        
        [HttpPost]
        [Route("GetKarsazDetailDescription")]
        public IActionResult GetKarsazDetailDescription(KarsazDetailDescription karsazDetail)
        {
            return Ok(karsazService.GetKarsazDetailDescription(karsazDetail));
        }
        
        [HttpPost]
        [Route("GetKarsazDetailDescriptionById")]
        public IActionResult GetKarsazDetailDescriptionById(KarsazDetailDescription karsazDetail)
        {
            return Ok(karsazService.GetKarsazDetailDescriptionById(karsazDetail));
        }
        
        [HttpPost]
        [Route("DeleteKarsazDetailDescription")]
        public IActionResult DeleteKarsazDetailDescription(KarsazDetailDescription karsazDetail)
        {
            return Ok(karsazService.DeleteKarsazDetailDescription(karsazDetail));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="karigarComments"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("CreatekarigarComments")]
        public IActionResult CreatekarigarComments(karigarComments karigarComments )
        {
            return Ok(karsazService.CreatekarigarComments(karigarComments));
        }
        
        [HttpPost]
        [Route("GetkarigarComments")]
        public IActionResult GetkarigarComments(Karsaz customers)
        {
            return Ok(karsazService.GetkarigarComments(customers));
        }
    }
}
