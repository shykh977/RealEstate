using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Common;


namespace PropertyBackend.DataLayer
{
    public class PropertyCategoryService
    {

        private IGenericRepository<PropertyCategory> _IgenericRepository;
        APIResponse APIResponse = new APIResponse();
        public PropertyCategoryService(IGenericRepository<PropertyCategory> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        public APIResponse CreateUpdatePropertyCategory(PropertyCategory propertyCategory)
        {
            if(propertyCategory.PropertyCategoryId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                _IgenericRepository.ExecuteQuery<PropertyCategory>(propertyCategory, "usp_Create_Update_PropertyCategory").FirstOrDefault();
                APIResponse.StatusMessage = "Property Category Successfully Added ";
            }
            else
            {
                _IgenericRepository.ExecuteQuery<PropertyCategory>(propertyCategory, "usp_Create_Update_PropertyCategory").FirstOrDefault();
                APIResponse.StatusMessage = "Property Category Successfully Updated ";
            }            
            return APIResponse;
        }

        public APIResponse GetPropertyCategory(PropertyCategory propertyCategory)
        {
            object obj = new
            {
                BusinessId = propertyCategory.BusinessId
            };
            List<PropertyCategory> PT = _IgenericRepository.Search<PropertyCategory>(obj, "usp_GetPropertyCategory").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }

        public APIResponse GetPropertyCategoryById(PropertyCategory propertyCategory)
        {
            object obj = new
            {
                PropertyCategoryId = propertyCategory.PropertyCategoryId
            };
            List<PropertyCategory> PT = _IgenericRepository.Search<PropertyCategory>(obj, "usp_GetPropertyCategory").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }

        public APIResponse DeletePropertyCategory(PropertyCategory propertyCategory)
        {
            object obj = new
            {
                PropertyCategoryId = propertyCategory.PropertyCategoryId,
                UserId = propertyCategory.UserId
            };           
            _IgenericRepository.ExecuteQuery<PropertyCategory>(obj, "usp_DeletePropertyCategory").FirstOrDefault();
            APIResponse.StatusMessage = "Property Category Successfully Deleted ";                        
            return APIResponse;
        }


    }
}
