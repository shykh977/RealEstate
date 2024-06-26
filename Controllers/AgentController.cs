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
    public class AgentController : ControllerBase
    {
        private IGenericRepository<Agentcs> _IgenericRepository;

        AgentService agentService = null;

        public AgentController(IGenericRepository<Agentcs> igenericRepository)
        {
            agentService = new AgentService(igenericRepository);
        }

        APIResponse APIResponse = new APIResponse();


        [HttpPost]
        [Route("GetAgents")]
        public IActionResult GetCountry(BaseModel baseModel)
        {
            return Ok(agentService.GetAgents(baseModel));
        }
        
        
        [HttpPost]
        [Route("GetTitaniumAgent")]
        public IActionResult GetTitaniumAgent(BaseModel baseModel)
        {
            return Ok(agentService.GetTitaniumAgent(baseModel));
        }
        
        [HttpPost]
        [Route("GetAgentsById")]
        public IActionResult GetAgentsById(Agentcs agentcs)
        {
            return Ok(agentService.GetAgentsById(agentcs));
        }
        
        
        [HttpPost]
        [Route("GetAgentsByIdMobile")]
        public IActionResult GetAgentsByIdMobile(Agentcs agentcs)
        {
            return Ok(agentService.GetAgentsByIdMobile(agentcs));
        }
        
        [HttpPost]
        [Route("GetPropertyCountForAgents")]
        public IActionResult GetPropertyCountForAgents(Agentcs agentcs)
        {
            return Ok(agentService.GetPropertyCountForAgents(agentcs));
        }
        
        [HttpPost]
        [Route("GetAgentPackgeDetail")]
        public IActionResult GetAgentPackgeDetail(Agentcs agentcs)
        {
            return Ok(agentService.GetAgentPackgeDetail(agentcs));
        }
        
        [HttpPost]
        [Route("GetAgentsOfUser")]
        public IActionResult GetAgentsOfUser(AgentUsers agentUsers)
        {
            return Ok(agentService.GetAgentsOfUser(agentUsers));
        }
        
        
        [HttpPost]
        [Route("CreateAgentUser")]
        public IActionResult CreateAgentUser(AgentUsers agentUsers)
        {
            return Ok(agentService.CreateAgentUser(agentUsers));
        }
        
        [HttpPost]
        [Route("GetAgentPackage")]
        public IActionResult GetAgentPackage(AgentUsers agentUsers)
        {
            return Ok(agentService.GetAgentPackage(agentUsers));
        }
        
        [HttpPost]
        [Route("GetPackageStatus")]
        public IActionResult GetPackageStatus(AgentUsers agentUsers)
        {
            return Ok(agentService.GetPackageStatus(agentUsers));
        }
        
        [HttpPost]
        [Route("GetAgentList")]
        public IActionResult GetAgentList(PropertyListingView propertyListingView)
        {
            return Ok(agentService.GetAgentList(propertyListingView));
        }





        //////Agent WebSite Config
        ///

        [HttpPost]
        [Route("UpdateAgentProfile")]
        public IActionResult UpdateAgentProfile(Agentcs agentcs)
        {
            return Ok(agentService.UpdateAgentProfile(agentcs));
        }
        
        [HttpPost]
        [Route("CreateAgentPortalImages")]
        public IActionResult CreateAgentPortalImages(AgentPortalImages agentPortalImages )
        {
            return Ok(agentService.CreateAgentPortalImages(agentPortalImages));
        }
        
        [HttpPost]
        [Route("GetPortalImages")]
        public IActionResult GetPortalImages(AgentPortalImages agentPortalImages )
        {
            return Ok(agentService.GetPortalImages(agentPortalImages));
        }
        
        [HttpPost]
        [Route("DeletePortalImages")]
        public IActionResult DeletePortalImages(AgentPortalImages agentPortalImages )
        {
            return Ok(agentService.DeletePortalImages(agentPortalImages));
        }
        
        [HttpPost]
        [Route("UpdatePortalNews")]
        public IActionResult UpdatePortalNews(AgentView agentPortalImages )
        {
            return Ok(agentService.UpdatePortalNews(agentPortalImages));
        }
    }
}
