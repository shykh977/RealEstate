using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Common;
using PropertyBackend.Model.ViewModel;

namespace PropertyBackend.DataLayer
{
    public class UserRolesService
    {

        private IGenericRepository<UserRoles> _IgenericRepository;
        APIResponse APIResponse = new APIResponse();
        public UserRolesService(IGenericRepository<UserRoles> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }
        public APIResponse CreateUserRoles(UserRoles userRoles )
        {
            if (userRoles.UserRolesId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                userRoles.UserRolesId = Guid.NewGuid();
                _IgenericRepository.ExecuteQuery<UserRoles>(userRoles, "usp_Create_Update_UserRoles").FirstOrDefault();
                APIResponse.StatusMessage = "User Role Successfully Created";

                ///
            }
            else
            {
                _IgenericRepository.ExecuteQuery<UserRoles>(userRoles, "usp_Create_Update_UserRoles").FirstOrDefault();
                APIResponse.StatusMessage = "User Role Successfully Updated";

            }
            return APIResponse;
        }
       
        
        public APIResponse GetUserRoles(UserRoles userRoles)
        {
            object obj = new
            {
                BusinessId = userRoles.BusinessId
            };
            List<UserRoles> userRolesList  = _IgenericRepository.Search<UserRoles>(obj, "usp_GetUserRoles").ToList();
            APIResponse.Response = userRolesList;
            return APIResponse;
        } 
        
        
        public APIResponse GetAssignedUserRole(UserRoles userRoles)
        {
            object obj = new
            {
                UserId = userRoles.UserId
            };
            List<AssignUserRoleView> userRolesList  = _IgenericRepository.Search<AssignUserRoleView>(obj, "usp_GetAssignedUserRole").ToList();
            APIResponse.Response = userRolesList;
            return APIResponse;
        }             
       
        
        public APIResponse DeleteUserRoles(UserRoles userRoles)
        {
            object obj = new
            {
                UserRolesId = userRoles.UserRolesId
            };

            _IgenericRepository.ExecuteQuery<UserRoles>(obj, "usp_DeleteUserRoles").FirstOrDefault();
            APIResponse.StatusMessage = "User Role Has Been Deleted";
            return APIResponse;
        }

        ///// Assigned Roles    

        ///

        public APIResponse AssignUserRole(AssignUserRole assignUserRole )
        {
            if (assignUserRole.AssignUserRoleId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                assignUserRole.AssignUserRoleId = Guid.NewGuid();
                _IgenericRepository.ExecuteQuery<AssignUserRole>(assignUserRole, "usp_Create_Update_AssignUserRole").FirstOrDefault();
                APIResponse.StatusMessage = "Assign Role Successfully Created";

                ///
            }
            else
            {
                _IgenericRepository.ExecuteQuery<AssignUserRole>(assignUserRole, "usp_Create_Update_AssignUserRole").FirstOrDefault();
                APIResponse.StatusMessage = "Assign Role Successfully Updated";

            }
            return APIResponse;
        }


        public APIResponse DeleteAssignUserRole(AssignUserRole assignUserRole )
        {
            object obj = new
            {
                AssignUserRoleId = assignUserRole.AssignUserRoleId
            };

            _IgenericRepository.ExecuteQuery<AssignUserRole>(obj, "usp_DeleteAssignUserRole").FirstOrDefault();
            APIResponse.StatusMessage = "Assigned Role Has Been Deleted";
            return APIResponse;
        }

    }
}
