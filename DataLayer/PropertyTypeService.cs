using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Common;



namespace PropertyBackend.DataLayer
{
    public class PropertyTypeService
    {

        private IGenericRepository<PropertyType> _IgenericRepository;
        APIResponse APIResponse = new APIResponse();
        public PropertyTypeService(IGenericRepository<PropertyType> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        public APIResponse CreateUpdatePropertyType(PropertyType propertyType )
        {
            if (propertyType.PropertyTypeId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                _IgenericRepository.ExecuteQuery<PropertyType>(propertyType, "usp_Create_Update_PropertyType").FirstOrDefault();
                APIResponse.StatusMessage = "Property Type Successfully Added ";
            }
            else
            {
                _IgenericRepository.ExecuteQuery<PropertyType>(propertyType, "usp_Create_Update_PropertyType").FirstOrDefault();
                APIResponse.StatusMessage = "Property Type Successfully Updated ";
            }
            return APIResponse;
        }

        public APIResponse GetPropertyType(PropertyType propertyType)
        {
            object obj = new
            {
                BusinessId = propertyType.BusinessId
            };
            List<PropertyType> PT = _IgenericRepository.Search<PropertyType>(obj, "usp_GetPropertyType").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }

        public APIResponse GetPropertyTypeById(PropertyType propertyType)
        {
            object obj = new
            {
                PropertyTypeId = propertyType.PropertyTypeId
            };
            List<PropertyType> PT = _IgenericRepository.Search<PropertyType>(obj, "usp_GetPropertyType").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }

        public APIResponse GetPropertyTypeByName(PropertyType propertyType)
        {
            object obj = new
            {
                PropertyTypeName = propertyType.PropertyTypeName
            };
            List<PropertyType> PT = _IgenericRepository.Search<PropertyType>(obj, "usp_GetPropertyTypeByName").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }

        public APIResponse GetPropertyTypeByPropertyCategory(PropertyType propertyType)
        {
            object obj = new
            {
                PropertyCategoryId = propertyType.PropertyCategoryId
            };
            List<PropertyType> PT = _IgenericRepository.Search<PropertyType>(obj, "usp_GetPropertyType").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetPropertyTypeByPropertyCategoryMobile(PropertyType propertyType)
        {
            object obj = new
            {
                PropertyCategoryId = propertyType.PropertyCategoryId
            };
            var PT = _IgenericRepository.Search<PropertyType>(obj, "usp_GetPropertyType").FirstOrDefault();
            APIResponse.Response = PT;
            return APIResponse;
        }

        public APIResponse DeletePropertyType(PropertyType propertyType)
        {
            object obj = new
            {
                PropertyTypeId = propertyType.PropertyTypeId,
                UserId = propertyType.UserId
            };
            _IgenericRepository.ExecuteQuery<PropertyType>(obj, "usp_DeletePropertyType").FirstOrDefault();
            APIResponse.StatusMessage = "Property Type Successfully Deleted ";
            return APIResponse;
        }

    }
}
