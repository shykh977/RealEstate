using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;


namespace PropertyBackend.DataLayer
{
    public class BuildersAndDevelopersService
    {

        private IGenericRepository<BuildersAndDevelopers> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public BuildersAndDevelopersService(IGenericRepository<BuildersAndDevelopers> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }


        public APIResponse CreateBuildersandDevelopers(BuildersAndDevelopers buildersAndDevelopers )
        {
            _IgenericRepository.ExecuteQuery<BuildersAndDevelopers>(buildersAndDevelopers, "usp_Create_Update_BuildersandDevelopers").ToList();           
            return APIResponse;
        }
        
        public APIResponse GetBuildersandDevelopers(BuildersAndDevelopers buildersAndDevelopers )
        {
            object obj = new
            {
                BusinessId = buildersAndDevelopers.BusinessId
            };
            List<BuildersAndDevelopers> BAD =  _IgenericRepository.ExecuteQuery<BuildersAndDevelopers>(obj, "usp_GetBuildersandDevelopers").ToList();
            APIResponse.Response = BAD;
            return APIResponse;
        } 
        
        
        public APIResponse GetBuildersandDevelopersById(BuildersAndDevelopers buildersAndDevelopers )
        {
            object obj = new
            {
                BuildersId = buildersAndDevelopers.BuildersId
            };
            List<BuildersAndDevelopers> BAD =  _IgenericRepository.ExecuteQuery<BuildersAndDevelopers>(obj, "usp_GetBuildersandDevelopers").ToList();
            APIResponse.Response = BAD;
            return APIResponse;
        }
        
        public APIResponse DeleteBuildersandDevelopers(BuildersAndDevelopers buildersAndDevelopers )
        {
            object obj = new
            {
                BuildersId = buildersAndDevelopers.BuildersId,
                UserId = buildersAndDevelopers.UserId
            };
            _IgenericRepository.ExecuteQuery<BuildersAndDevelopers>(obj, "usp_DeleteBuildersandDevelopers").ToList();
          
            return APIResponse;
        }
    }
}
