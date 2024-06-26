using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
namespace PropertyBackend.Helper
{
    public interface IUplaodReels
    {
         Task<APIResponse> UploadAgentReels(IFormFile file, [FromForm] Guid AgentId);
    }
}
