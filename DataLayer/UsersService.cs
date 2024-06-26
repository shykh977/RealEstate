using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;


namespace PropertyBackend.DataLayer
{
    public class UsersService 
    {
        private IGenericRepository<Users> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public UsersService(IGenericRepository<Users> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }


        public APIResponse LoginUser(Users users )
        {
            object obj = new
            {
               UserName = users.UserName,
               Password = users.Password,
               UserType = users.UserType
            };
            List<Users> LoginUser = _IgenericRepository.Search<Users>(obj, "usp_UserLogin").ToList();
           
            if(LoginUser.Count > 0)
            {
                APIResponse.Response = LoginUser;
                return APIResponse;
            }
            else
            {
                APIResponse.StatusMessage = "Login Failed Check Username Or Password";
                return APIResponse;
            }                     
        }
        
        
        
        public APIResponse AgentLogin(Users users )
        {
            object obj = new
            {
               UserName = users.UserName,
               Password = users.Password
            };
            var LoginUser = _IgenericRepository.Search<Users>(obj, "usp_AgentLogin").FirstOrDefault();
           
            if(LoginUser != null)
            {
                APIResponse.Response = LoginUser;
                APIResponse.StatusMessage = "Agent Login Successfully";
                return APIResponse;
            }
            else
            {
                APIResponse.StatusMessage = "Login Failed Check Username Or Password";
                return APIResponse;
            }                     
        }


    }
}
