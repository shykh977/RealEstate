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
    public class PackageCategoryController : ControllerBase
    {
        private IGenericRepository<PackageCategories> _IgenericRepository;

        PackageCategoryService packageCategoryService  = null;
       
        APIResponse APIResponse = new APIResponse();
        public PackageCategoryController(IGenericRepository<PackageCategories> igenericRepository)
        {
            packageCategoryService = new PackageCategoryService(igenericRepository);
        }
                     
        [HttpPost]
        [Route("GetPackageCategory")]
        public IActionResult GetPackageCategory(PackageCategories packageCategories)
        {
            return Ok(packageCategoryService.GetPackageCategory(packageCategories));
        }
        
        [HttpPost]
        [Route("GetPackageSubCategory")]
        public IActionResult GetPackageSubCategory(PackageCategories packageCategories)
        {
            return Ok(packageCategoryService.GetPackageSubCategory(packageCategories));
        }
        
        [HttpPost]
        [Route("GetPackageSubscribers")]
        public IActionResult GetPackageSubscribers(PackageSubCategory packageSubCategory)
        {
            return Ok(packageCategoryService.GetPackageSubscribers(packageSubCategory));
        }
        
        
        [HttpPost]
        [Route("GetPackages")]
        public IActionResult GetPackages(PackageSubCategory packageSubCategory)
        {
            return Ok(packageCategoryService.GetPackages(packageSubCategory));
        }
        
        
        [HttpPost]
        [Route("AssignPackage")]
        public IActionResult AssignPackage(PackageSubCategory packageDetail)
        {
            return Ok(packageCategoryService.AssignPackage(packageDetail));
        }
        
        
        [HttpPost]
        [Route("CreateCustomPackage")]
        public IActionResult CreateCustomPackage(PackageDetail CustomPackageDetail)
        {
            return Ok(packageCategoryService.CreateCustomPackage(CustomPackageDetail));
        }
    }
}
