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
    public class UserRoleController : ControllerBase
    {


        private IGenericRepository<UserRoles> _IgenericRepository;

        UserRolesService userRolesService  = null;

        public UserRoleController(IGenericRepository<UserRoles> igenericRepository)
        {
            userRolesService = new UserRolesService(igenericRepository);
        }

        [HttpPost]
        [Route("CreateUserRoles")]
        public IActionResult CreateUserRoles(UserRoles userRoles)
        {
            return Ok(userRolesService.CreateUserRoles(userRoles));
        }
        
        
        [HttpPost]
        [Route("GetUserRoles")]
        public IActionResult GetUserRoles(UserRoles userRoles)
        {
            return Ok(userRolesService.GetUserRoles(userRoles));
        } 
        
        [HttpPost]
        [Route("GetAssignedUserRole")]
        public IActionResult GetAssignedUserRole(UserRoles userRoles)
        {
            return Ok(userRolesService.GetAssignedUserRole(userRoles));
        }
        
        
        [HttpPost]
        [Route("DeleteUserRoles")]
        public IActionResult DeleteUserRoles(UserRoles userRoles)
        {
            return Ok(userRolesService.DeleteUserRoles(userRoles));
        }
        
        [HttpPost]
        [Route("AssignUserRole")]
        public IActionResult AssignUserRole(AssignUserRole assignUserRole)
        {
            return Ok(userRolesService.AssignUserRole(assignUserRole));
        }
        
        
        [HttpPost]
        [Route("DeleteAssignUserRole")]
        public IActionResult DeleteAssignUserRole(AssignUserRole assignUserRole)
        {
            return Ok(userRolesService.DeleteAssignUserRole(assignUserRole));
        }



    }
}
