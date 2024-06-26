using PropertyBackend.Common;
using PropertyBackend.DbConnect;

namespace PropertyBackend.DbConnecter
{
    public class ConnectionFactory :IConnection
    {
        public string ConnectionString
        {
            get
            {
                return APIConfig.Configuration.GetSection("ConnectionStrings")["DefaultConnection"];
            }
        }
    }
}
