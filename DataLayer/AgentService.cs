using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;

namespace PropertyBackend.DataLayer
{
    public class AgentService
    {

        private IGenericRepository<Agentcs> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public AgentService(IGenericRepository<Agentcs> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        public APIResponse GetAgents(BaseModel baseModel)
        {
            object obj = new
            {
                BusinessId = baseModel.BusinessId
            };
            List<AgentView> countries = _IgenericRepository.Search<AgentView>(obj, "usp_GetAgents").ToList();
            APIResponse.Response = countries;
            return APIResponse;
        } 
        
        public APIResponse GetTitaniumAgent(BaseModel baseModel)
        {
            object obj = new
            {
                BusinessId = baseModel.BusinessId
            };
            List<AgentView> countries = _IgenericRepository.Search<AgentView>(obj, "usp_GetTitaniumAgent").ToList();
            APIResponse.Response = countries;
            return APIResponse;
        }
        
        public APIResponse GetAgentsById(Agentcs agentcs )
        {
            object obj = new
            {
                AgentId = agentcs.AgentId
            };
            List<AgentView> countries = _IgenericRepository.Search<AgentView>(obj, "usp_GetAgentsDetail").ToList();
            APIResponse.Response = countries;
            return APIResponse;
        }
        
        
        public APIResponse GetAgentsByIdMobile(Agentcs agentcs )
        {
            object obj = new
            {
                AgentId = agentcs.AgentId
            };
            var AgentsDetail = _IgenericRepository.Search<AgentView>(obj, "usp_GetAgentDetailForApp").FirstOrDefault();
            APIResponse.Response = AgentsDetail;
            return APIResponse;
        } 
        
        public APIResponse GetPropertyCountForAgents(Agentcs agentcs )
        {
            object obj = new
            {
                AgentId = agentcs.AgentId
            };
            List<AgentPropertyStatusView> agentPropertyStatusViews  = _IgenericRepository.Search<AgentPropertyStatusView>(obj, "usp_GetPropertyCountForAgents").ToList();
            APIResponse.Response = agentPropertyStatusViews;
            return APIResponse;
        }
        public APIResponse GetAgentPackgeDetail(Agentcs agentcs )
        {
            object obj = new
            {
                AgentId = agentcs.AgentId
            };
            List<AgentPackageDetailView> agentPropertyStatusViews  = _IgenericRepository.Search<AgentPackageDetailView>(obj, "usp_GetAgentPackgeDetail").ToList();
            APIResponse.Response = agentPropertyStatusViews;
            return APIResponse;
        }
        
        public APIResponse GetAgentsOfUser(AgentUsers agentUsers )
        {
            object obj = new
            {
                AgentUserId = agentUsers.AgentUserId
            };
            List<AgentUsersView> agentUsersList  = _IgenericRepository.Search<AgentUsersView>(obj, "GetAgentsOfUser").ToList();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        }
        
        public APIResponse CreateAgentUser(AgentUsers agentUser )
        {

            Users users = new Users();

            Guid AgentUserId = Guid.NewGuid();

            users.UserType = 2;
            users.Email = agentUser.AgentUserEmail;
            users.Password = "123";
            agentUser.AgentUserId = AgentUserId;
            users.UserTypeId = AgentUserId;
            users.UserId = Guid.NewGuid();
            users.UserName = agentUser.AgentUserName;



            _IgenericRepository.ExecuteQuery<Users>(users, "usp_Create_Update_UsersLogin").ToList();
            
            List<AgentUsersView> agentUsersList  = _IgenericRepository.ExecuteQuery<AgentUsersView>(agentUser, "usp_Create_Update_AgentUser").ToList();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        }
        
        public APIResponse GetAgentPackage(AgentUsers agentUsers )
        {
            object obj = new
            {
                AgentUserId = agentUsers.AgentUserId
            };
            List<AgentPackageDetailView> agentUsersList  = _IgenericRepository.Search<AgentPackageDetailView>(obj, "usp_GetAgentPackage").ToList();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        }
        
        public APIResponse GetPackageStatus(AgentUsers agentUsers )
        {
            object obj = new
            {
                AgentId = agentUsers.AgentId
            };
            List<AgentPropertyStatusView> agentUsersList  = _IgenericRepository.Search<AgentPropertyStatusView>(obj, "usp_GetPackageStatus").ToList();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        } 
        
        
        public APIResponse GetAgentList(PropertyListingView propertyListingView)
        {
            object obj = new
            {
                LocationId = propertyListingView.LocationId,
                CityId = propertyListingView.CityId,
                OFFSET = propertyListingView.OFFSET

            };
            List<AgentView> agentUsersList  = _IgenericRepository.Search<AgentView>(obj, "usp_GetAgentList").ToList();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        }


        //////Agent WebSite Config
        ///

        public APIResponse CreateAgentPortalImages(AgentPortalImages agentPortalImages )
        {
            agentPortalImages.AgentPortalImagesId = Guid.NewGuid();
            
            var agentUsersList = _IgenericRepository.ExecuteQuery<AgentPortalImages>(agentPortalImages, "usp_Create_Update_AgentPortalImages").FirstOrDefault();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        }
        
        
        public APIResponse UpdateAgentProfile(Agentcs agentcs)
        {



            object obj = new
            {
                AgentId =       agentcs.AgentId	,
                OfficeNo =      agentcs.OfficeNo	,
                MobileNo =      agentcs.MobileNo	,
                Biography =     agentcs.Biography	,
                Logo =          agentcs.Logo
            };



            
            var agentUsersList = _IgenericRepository.ExecuteQuery<AgentPortalImages>(obj, "usp_UpdateAgentProfile").FirstOrDefault();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        }  
       
        
        public APIResponse UpdatePortalNews(AgentView agentcs)
        {

            object obj = new
            {
                AgentId =       agentcs.AgentId,
              PortalNews = agentcs.PortalNews
            };

            var agentUsersList = _IgenericRepository.ExecuteQuery<AgentPortalImages>(obj, "usp_UpdatePortalNews").FirstOrDefault();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        } 
        
        public APIResponse GetPortalImages(AgentPortalImages agentPortalImages )
        {
            object obj = new
            {
                AgentId = agentPortalImages.AgentId
            };         
            List<AgentPortalImages> agentUsersList = _IgenericRepository.ExecuteQuery<AgentPortalImages>(obj, "usp_GetPortalImages").ToList();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        }
        
        public APIResponse DeletePortalImages(AgentPortalImages agentPortalImages )
        {
            object obj = new
            {
                AgentPortalImagesId = agentPortalImages.AgentPortalImagesId
            };         
            List<AgentPortalImages> agentUsersList = _IgenericRepository.ExecuteQuery<AgentPortalImages>(obj, "usp_DeletePortalImages").ToList();
            APIResponse.Response = agentUsersList;
            return APIResponse;
        }
    }
}
