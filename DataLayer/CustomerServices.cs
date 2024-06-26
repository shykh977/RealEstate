using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;



namespace PropertyBackend.DataLayer
{
    public class CustomerServices
    {
        private IGenericRepository<Customers> _IgenericRepository;
        APIResponse APIResponse = new APIResponse();
        public CustomerServices(IGenericRepository<Customers> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }


        public APIResponse CreateCustoemrs(Customers customers )
        {
            if (customers.CustomerId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                customers.CustomerId = Guid.NewGuid();
            }
           APIResponse.Response = _IgenericRepository.ExecuteQuery<Customers>(customers, "usp_Create_Update_Customers").ToList();

            APIResponse.StatusMessage = "User Created Successfully";


            return APIResponse;
        }
        
        public APIResponse CustomerChats(CustomerChats customerChats  )
        {
            if (customerChats.CustomerChatsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                customerChats.CustomerChatsId = Guid.NewGuid();
            }
            _IgenericRepository.ExecuteQuery<CustomerChats>(customerChats, "usp_Create_Update_CustomerChats").ToList();
            return APIResponse;
        }
        
        public APIResponse SendMessageFromAgent(CustomerChats customerChats  )
        {
            if (customerChats.CustomerChatsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                customerChats.CustomerChatsId = Guid.NewGuid();
            }
            _IgenericRepository.ExecuteQuery<CustomerChats>(customerChats, "usp_SendMessageFromAgent").ToList();
            return APIResponse;
        }
        
        
        
        public APIResponse SendMessageFromCustomer(CustomerChats customerChats  )
        {
            if (customerChats.CustomerChatsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                customerChats.CustomerChatsId = Guid.NewGuid();
            }
            _IgenericRepository.ExecuteQuery<CustomerChats>(customerChats, "usp_SendMessageFromCustomer").ToList();
            return APIResponse;
        }
        
        
        public APIResponse LikedProperty(LikedProperty likedProperty   )
        {
            if (likedProperty.LikedPropertyId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                likedProperty.LikedPropertyId = Guid.NewGuid();
            }
            _IgenericRepository.ExecuteQuery<LikedProperty>(likedProperty, "usp_Create_Update_LikedProperty").ToList();
            return APIResponse;
        }
        
        
        public APIResponse LoginCustomer(Customers customers )
        {

            object obj = new
            {
                Email       = customers.Email,
                Password    = customers.Password
            };


           List<Customers> CustomerLogin = _IgenericRepository.ExecuteQuery<Customers>(obj, "LoginCustomer").ToList();
           
            if(CustomerLogin.Count > 0)
            {
                APIResponse.Response = CustomerLogin;
                APIResponse.StatusMessage = "Success";
            }
            else
            {
                APIResponse.StatusMessage = "Failed";
            }        
            return APIResponse;
        }
        
        
        public APIResponse LoginCustomerApp(Customers customers )
        {

            object obj = new
            {
                Email       = customers.Email,
                Password    = customers.Password
            };


            var CustomerLogin = _IgenericRepository.ExecuteQuery<Customers>(obj, "LoginCustomer").FirstOrDefault();
           
            if(CustomerLogin != null)
            {
                APIResponse.Response = CustomerLogin;
                APIResponse.StatusMessage = "Login Successfully";
            }
            else
            {
                APIResponse.StatusMessage = "Login Failed Check Username or Password";
            }        
            return APIResponse;
        }



        public APIResponse CreatePropertyListing(PropertyListing? propertyListing)
        {
            object obj2 = new
            {
                AgentId = propertyListing.AgentId
            };

            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj2, "usp_getPropertyListingForCustomerPortal").ToList();


            if(PT.Count > 4)
            {
                APIResponse.StatusMessage = "Free Plan Limit Exceed.Kindly Subscribe New Plan";
            }
            else
            {
                _IgenericRepository.ExecuteQuery<PropertyListingView>(propertyListing, "usp_Create_Update_PropertyListing").ToList();
                APIResponse.StatusMessage = "Property Successfully Uploaded";
            }

                        
            return APIResponse;
        }

        public APIResponse GetPropertyListingForCustomerPortal(PropertyListing propertyListing)
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_getPropertyListingForCustomerPortal").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        public APIResponse GetPropertyLikedProperties(PropertyListing propertyListing)
        
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyLikedProperties").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetCustomerAndAgentChats(PropertyListing propertyListing)       
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,
            };
            List<ChatsView> PT = _IgenericRepository.Search<ChatsView>(obj, "GetCustomerAndAgentChats").ToList();                        
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetCustomerChats(Customers customers  )       
        {
            object obj = new
            {
                CustomerId = customers.CustomerId,
            };
            List<ChatsView> PT = _IgenericRepository.Search<ChatsView>(obj, "GetCustomerAndAgentChats").ToList();                        
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetAgentChats(AgentView agentView)       
        {
            object obj = new
            {
                AgentId = agentView.AgentId,
            };
            List<ChatsView> PT = _IgenericRepository.Search<ChatsView>(obj, "GetCustomerAndAgentChats").ToList();                        
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetAgentCustomers(PropertyListing propertyListing)       
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,
            };
            List<Customers> PT = _IgenericRepository.Search<Customers>(obj, "usp_GetAgentCustomers").ToList();                        
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        
        public APIResponse GetCustomerAgent(Customers customers  )       
        {
            object obj = new
            {
                CustomerId = customers.CustomerId,
            };
            List<AgentView> PT = _IgenericRepository.Search<AgentView>(obj, "usp_GetAgentCustomers").ToList();                        
            APIResponse.Response = PT;
            return APIResponse;
        }



    }
}
