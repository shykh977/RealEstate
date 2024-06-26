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
    public class AnalyticsController : ControllerBase
    {

        private IGenericRepository<Analytics> _IgenericRepository;

        AnalyticsService analyticsService  = null;

        public AnalyticsController(IGenericRepository<Analytics> igenericRepository)
        {
            analyticsService = new AnalyticsService(igenericRepository);
        }

        [HttpPost]
        [Route("GetImpressions")]
        public IActionResult GetImpressions(Analytics analytics)
        {
            return Ok(analyticsService.GetImpressions(analytics));
        }
        
        [HttpPost]
        [Route("GetAnalytics")]
        public IActionResult GetAnalytics(Agentcs agentcs)
        {
            return Ok(analyticsService.GetAnalytics(agentcs));
        }
        
        [HttpPost]
        [Route("GetTotalImpressionsGraph")]
        public IActionResult GetTotalImpressionsGraph(Agentcs agentcs)
        {
            return Ok(analyticsService.GetTotalImpressionsGraph(agentcs));
        }
        [HttpPost]
        [Route("GetTotalViewsGraph")]
        public IActionResult GetTotalViewsGraph(Agentcs agentcs)
        {
            return Ok(analyticsService.GetTotalViewsGraph(agentcs));
        }
        
        [HttpPost]
        [Route("GetTotalImpressionsAndVisitGraph")]
        public IActionResult GetTotalImpressionsAndVisitGraph(Agentcs agentcs)
        {
            return Ok(analyticsService.GetTotalImpressionsAndVisitGraph(agentcs));
        }

    }
}
