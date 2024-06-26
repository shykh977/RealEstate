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
    public class CustomerController : ControllerBase
    {

        private IGenericRepository<Customers> _IgenericRepository;

        CustomerServices customerServices  = null;

        public CustomerController(IGenericRepository<Customers> igenericRepository)
        {
            customerServices = new CustomerServices(igenericRepository);
        }

        APIResponse APIResponse = new APIResponse();
        
        [HttpPost]
        [Route("CreateCustoemrs")]
        public IActionResult CreateCustoemrs(Customers customers )
        {
            return Ok(customerServices.CreateCustoemrs(customers));
        }
        
        
        [HttpPost]
        [Route("CustomerChats")]
        public IActionResult CustomerChats(CustomerChats customerChats )
        {
            return Ok(customerServices.CustomerChats(customerChats));
        }
        
        
        
        [HttpPost]
        [Route("SendMessageFromAgent")]
        public IActionResult SendMessageFromAgent(CustomerChats customerChats )
        {
            return Ok(customerServices.SendMessageFromAgent(customerChats));
        }
        
        [HttpPost]
        [Route("SendMessageFromCustomer")]
        public IActionResult SendMessageFromCustomer(CustomerChats customerChats )
        {
            return Ok(customerServices.SendMessageFromCustomer(customerChats));
        }
        
        
        [HttpPost]
        [Route("LikedProperty")]
        public IActionResult LikedProperty(LikedProperty likedProperty  )
        {
            return Ok(customerServices.LikedProperty(likedProperty));
        }
        
        
        [HttpPost]
        [Route("LoginCustomer")]
        public IActionResult LoginCustomer(Customers customers )
        {
            return Ok(customerServices.LoginCustomer(customers));
        }
        
        
        [HttpPost]
        [Route("LoginCustomerApp")]
        public IActionResult LoginCustomerApp(Customers customers )
        {
            return Ok(customerServices.LoginCustomerApp(customers));
        }

        [HttpPost]
        [Route("CreatePropertyListing")]
        public IActionResult CreatePropertyListing(PropertyListing? propertyListing)
        {
            return Ok(customerServices.CreatePropertyListing(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyListingForCustomerPortal")]
        public IActionResult GetPropertyListingForCustomerPortal(PropertyListing propertyListing)
        {
            return Ok(customerServices.GetPropertyListingForCustomerPortal(propertyListing));
        }
        
        [HttpPost]
        [Route("GetPropertyLikedProperties")]
        public IActionResult GetPropertyLikedProperties(PropertyListing propertyListing)
        {
            return Ok(customerServices.GetPropertyLikedProperties(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetCustomerAndAgentChats")]
        public IActionResult GetCustomerAndAgentChats(PropertyListing propertyListing)
        {
            return Ok(customerServices.GetCustomerAndAgentChats(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetCustomerChats")]
        public IActionResult GetCustomerChats(Customers customers  )
        {
            return Ok(customerServices.GetCustomerChats(customers));
        }
        
        
        [HttpPost]
        [Route("GetAgentChats")]
        public IActionResult GetAgentChats(AgentView agentView)
        {
            return Ok(customerServices.GetAgentChats(agentView));
        }
        
        
        [HttpPost]
        [Route("GetAgentCustomers")]
        public IActionResult GetAgentCustomers(PropertyListing propertyListing)
        {
            return Ok(customerServices.GetAgentCustomers(propertyListing));
        }
        
        
        [HttpPost]
        [Route("GetCustomerAgent")]
        public IActionResult GetCustomerAgent(Customers customers )
        {
            return Ok(customerServices.GetCustomerAgent(customers));
        }
    }
}
