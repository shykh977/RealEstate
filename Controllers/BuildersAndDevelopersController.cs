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
    public class BuildersAndDevelopersController : ControllerBase
    {

        private IGenericRepository<BuildersAndDevelopers> _IgenericRepository;

        BuildersAndDevelopersService _IbuildersAndDevelopers  = null;

        public BuildersAndDevelopersController(IGenericRepository<BuildersAndDevelopers> igenericRepository)
        {
            _IbuildersAndDevelopers = new BuildersAndDevelopersService(igenericRepository);
        }

        [HttpPost]
        [Route("CreateBuildersandDevelopers")]
        public IActionResult CreateBuildersandDevelopers(BuildersAndDevelopers buildersAndDevelopers )
        {
            return Ok(_IbuildersAndDevelopers.CreateBuildersandDevelopers(buildersAndDevelopers));
        }
        
        [HttpPost]
        [Route("GetBuildersandDevelopers")]
        public IActionResult GetBuildersandDevelopers(BuildersAndDevelopers buildersAndDevelopers )
        {
            return Ok(_IbuildersAndDevelopers.GetBuildersandDevelopers(buildersAndDevelopers));
        }
        
        [HttpPost]
        [Route("GetBuildersandDevelopersById")]
        public IActionResult GetBuildersandDevelopersById(BuildersAndDevelopers buildersAndDevelopers )
        {
            return Ok(_IbuildersAndDevelopers.GetBuildersandDevelopersById(buildersAndDevelopers));
        }
        
        [HttpPost]
        [Route("DeleteBuildersandDevelopers")]
        public IActionResult DeleteBuildersandDevelopers(BuildersAndDevelopers buildersAndDevelopers )
        {
            return Ok(_IbuildersAndDevelopers.DeleteBuildersandDevelopers(buildersAndDevelopers));
        }

    }
}
