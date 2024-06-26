using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;


namespace PropertyBackend.DataLayer
{
    public class AdminPanelServices
    {

        private IGenericRepository<BaseModel> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public AdminPanelServices(IGenericRepository<BaseModel> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        public APIResponse GetAdminPanelStatistics(BaseModel baseModel)
        {
            object obj = new
            {
                BusinessId = baseModel.BusinessId
            };
            List<AdminPanelView> countries = _IgenericRepository.Search<AdminPanelView>(obj, "usp_GetAdminPanelStatistics").ToList();
            APIResponse.Response = countries;
            return APIResponse;
        }
        
        
        public APIResponse GetAdminPanelStatisticsMobile(BaseModel baseModel)
        {
            object obj = new
            {
                BusinessId = baseModel.BusinessId
            };
            var AdminPanelStatistics = _IgenericRepository.Search<AdminPanelView>(obj, "usp_GetAdminPanelStatistics").FirstOrDefault();
            APIResponse.Response = AdminPanelStatistics;
            return APIResponse;
        }
        
        
        public APIResponse GetPropertyForApproval(BaseModel baseModel)
        {
            object obj = new
            {
                BusinessId = baseModel.BusinessId
            };
            List<PropertyListingView> countries = _IgenericRepository.Search<PropertyListingView>(obj, "GetPropertyForApproval").ToList();
            APIResponse.Response = countries;
            return APIResponse;
        }
        
        
        public APIResponse ApproveProperty(PropertyListing propertyListing )
        {
            object obj = new
            {
                PropertyListingId = propertyListing.PropertyListingId
            };
           APIResponse.Response = _IgenericRepository.ExecuteQuery<PropertyListing>(obj, "ApproveProperty").ToList();
            
            return APIResponse;
        }
        
        
        public APIResponse ApprovePropertyImages(PropertyImages propertyImages   )
        {
            object obj = new
            {
                PropertyImagesId = propertyImages.PropertyImagesId
            };
           APIResponse.Response = _IgenericRepository.ExecuteQuery<PropertyListing>(obj, "ApprovePropertyImages").ToList();
            
            return APIResponse;
        }

        public APIResponse GetPropertyImagesForApproval(PropertyListing propertyListing)
        {
            object obj = new
            {
                PropertyListingId = propertyListing.PropertyListingId,
            };
            List<PropertyImagesView> PT = _IgenericRepository.Search<PropertyImagesView>(obj, "usp_GetPropertyImagesForApproval").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetSubAdmin(Users users )
        {
            object obj = new
            {
                BusinessId = users.BusinessId,
                UserType = users.UserType,
            };
            List<Users> PT = _IgenericRepository.Search<Users>(obj, "usp_GetSubAdmin").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }

    }
}
