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
    public class UsersController : ControllerBase
    {

        private IGenericRepository<Users> _IgenericRepository;

        UsersService usersService   = null;

        public UsersController(IGenericRepository<Users> igenericRepository)
        {
            usersService = new UsersService(igenericRepository);
        }

        APIResponse APIResponse = new APIResponse();


        [HttpPost]
        [Route("LoginUser")]
        public IActionResult LoginUser(Users users)
        {
            return Ok(usersService.LoginUser(users));
        }
        
        [HttpPost]
        [Route("AgentLogin")]
        public IActionResult AgentLogin(Users users)
        {
            return Ok(usersService.AgentLogin(users));
        }


    }
}
