using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Common;
using PropertyBackend.Model.ViewModel;

namespace PropertyBackend.DataLayer
{
    public class CountryServices 
    {

        private IGenericRepository<Country> _IgenericRepository;
        private IGenericRepository<DeviceIdentity> _DeviceIgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public CountryServices(IGenericRepository<Country> igenericRepository, IGenericRepository<DeviceIdentity> DgenericRepository)
        {
            _IgenericRepository = igenericRepository;
            _DeviceIgenericRepository = DgenericRepository;
        }

         public APIResponse GetCountry(Country country)
          {
            object obj = new
            {
                County = country.CountryName
            };        
            List<Country> countries = _IgenericRepository.Search<Country>(obj, "PT_GetCountry").ToList();
            APIResponse.Response = countries;
            return APIResponse;
          }
        
        public APIResponse GetCities(int CountryId)
          {

            object obj = new
            {
                CountryId = CountryId,
            };

            List<Cities> Cities = _IgenericRepository.ExecuteQuery<Cities>(obj, "PT_GetCities").ToList();
            APIResponse.Response = Cities;
            return APIResponse;
          }
        
        public APIResponse GetCityIdByName(Cities cities)
          {

            object obj = new
            {
                CityName = cities.CityName,
            };

            List<Cities> Cities = _IgenericRepository.ExecuteQuery<Cities>(obj, "usp_GetCityIdByName").ToList();
            APIResponse.Response = Cities;
            return APIResponse;
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

            var DeviceIdentity = _DeviceIgenericRepository.Search<DeviceIdentity>(deviceIdentity, "usp_Create_Update_DeviceIdentity").FirstOrDefault();

            var cities = _DeviceIgenericRepository.ExecuteQuery<Cities>(obj, "usp_GetCityIdByName").ToList();


            APIResponse.Response = cities;
            return APIResponse;
        }

        public APIResponse GetAreas(Areas areas)
          {

            object obj = new
            {
                CityID = areas.CityID,
            };

            List<Areas> Cities = _IgenericRepository.ExecuteQuery<Areas>(obj, "PT_GetAreas").ToList();
            APIResponse.Response = Cities;
            return APIResponse;
          }
        
        
        
        public APIResponse GetLocationById(Areas areas)
          {

            object obj = new
            {
                LocationId = areas.LocationID,
            };

            List<Areas> Cities = _IgenericRepository.ExecuteQuery<Areas>(obj, "usp_GetLocationById").ToList();
            APIResponse.Response = Cities;
            return APIResponse;
          }
        
        
        public APIResponse GetLocationIdAreaGuide(Areas areas)
          {

            object obj = new
            {
                LocationID = areas.LocationID ,
                CityID     = areas.CityID

            };

            List<Areas> Cities = _IgenericRepository.ExecuteQuery<Areas>(obj, "usp_GetLocationIdAreaGuide").ToList();
            APIResponse.Response = Cities;
            return APIResponse;
          }
        
        
        public APIResponse GetLocationIdByName(Areas areas)
          {

            object obj = new
            {
                LocationName = areas.LocationName,
            };

            List<Areas> Cities = _IgenericRepository.ExecuteQuery<Areas>(obj, "usp_GetLocationIdByName").ToList();
            APIResponse.Response = Cities;
            return APIResponse;
          } 
        
        

        public APIResponse GetLocationDetail(Areas areas)
          {
            object obj = new
            {
                LocationId = areas.LocationID,
            };
            List<LocationDetail> Cities = _IgenericRepository.ExecuteQuery<LocationDetail>(obj, "usp_GetLocationDetailForWeb").ToList();
            APIResponse.Response = Cities;
            return APIResponse;
          }
        
        
        public APIResponse GetLocationDetailMobile(Cities cities)
          {


            LocationDetailView LDV = new LocationDetailView();

            object obj = new
            {
                CityID = cities.CityID,
            };

            LDV.locationDetailViews = _IgenericRepository.ExecuteQuery<LocationDetailView>(obj, "usp_GetLocationForAreaGuide").ToList();



            foreach (var item in LDV.locationDetailViews)
            {

                item.locationDetails = _IgenericRepository.ExecuteQuery<LocationDetail>(new { LocationId = item.LocationId }, "usp_GetLocationDetail").ToList();


            }

            APIResponse.Response = LDV;

            return APIResponse;
          }

    }

   
}
