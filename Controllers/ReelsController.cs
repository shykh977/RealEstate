using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;

namespace PropertyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReelsController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        private IGenericRepository<VideoReels> _IgenericRepository;

        UplaodReels UplaodReels  = null;

        public ReelsController(IGenericRepository<VideoReels> igenericRepository, IWebHostEnvironment environment)
        {
            UplaodReels = new UplaodReels(igenericRepository, environment);
            
        }
        [HttpPost]
        [Route("UploadAgentReels")]
        public ActionResult UploadAgentReels(IFormFile file , [FromForm] Guid AgentId)
        {
            return Ok(UplaodReels.UploadAgentReels(file, AgentId));
        }
        
        
        [HttpPost]
        [Route("GetVideoReels")]
        public ActionResult GetVideoReels(Agentcs agentcs)
        {
            return Ok(UplaodReels.GetVideoReels(agentcs));
        } 
        
        
        [HttpPost]
        [Route("GetVideoReelsByAgent")]
        public ActionResult GetVideoReelsByAgent(Agentcs agentcs)
        {

             
            return Ok(UplaodReels.GetVideoReelsByAgent(agentcs));
        }
        
        [HttpPost]
        [Route("GetRecentVideoReels")]
        public ActionResult GetRecentVideoReels(Agentcs agentcs)
        {
            return Ok(UplaodReels.GetRecentVideoReels(agentcs));
        } 
        
        [HttpPost]
        [Route("GetVideoReelsForApproval")]
        public ActionResult GetVideoReelsForApproval(Agentcs agentcs)
        {
            return Ok(UplaodReels.GetVideoReelsForApproval(agentcs));
        }
        
        [HttpPost]
        [Route("ReelsLikes")]
        public ActionResult ReelsLikes(ReelsLikesAndShare reelsLikesAndShare)
        {
            return Ok(UplaodReels.ReelsLikes(reelsLikesAndShare));
        }
        
        [HttpPost]
        [Route("ReelsSahre")]
        public ActionResult ReelsSahre(ReelsLikesAndShare reelsLikesAndShare)
        {
            return Ok(UplaodReels.ReelsSahre(reelsLikesAndShare));
        }
        
        
        [HttpPost]
        [Route("ApproveOrRejectReels")]
        public ActionResult ApproveOrRejectReels(ReelsView reelsLikesAndShare)
        {
            return Ok(UplaodReels.ApproveOrRejectReels(reelsLikesAndShare));
        }
        
        [HttpPost]
        [Route("DeleteReels")]
        public ActionResult DeleteReels(ReelsView reelsLikesAndShare)
        {
            return Ok(UplaodReels.DeleteReels(reelsLikesAndShare));
        }


    }
}
