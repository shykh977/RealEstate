using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;


namespace PropertyBackend.DataLayer
{
    public class LocationIdentityService
    {

        private IGenericRepository<DeviceIdentity> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public LocationIdentityService(IGenericRepository<DeviceIdentity> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }



        public APIResponse DeviceIdentity(DeviceIdentity deviceIdentity)
        {

            if (deviceIdentity.DeviceIdentityId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                deviceIdentity.DeviceIdentityId = Guid.NewGuid();
            }

            object obj = new
            {
                CityName = deviceIdentity.Location
            };

            var DeviceIdentity = _IgenericRepository.Search<DeviceIdentity>(deviceIdentity, "usp_Create_Update_DeviceIdentity").FirstOrDefault();

           var cities = _IgenericRepository.ExecuteQuery<Cities>(obj, "usp_GetCityIdByName").ToList();


            APIResponse.Response = cities;
            return APIResponse;
        }


    }
}
