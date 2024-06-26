using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;

namespace PropertyBackend.DataLayer
{
    public class AnalyticsService
    {

        private IGenericRepository<Analytics> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public AnalyticsService(IGenericRepository<Analytics> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        public APIResponse GetImpressions(Analytics analytics )
        {
          

            if(analytics.ImpressionsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                analytics.ImpressionsId = Guid.NewGuid();
            }

           _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();

            return APIResponse;
        } 
        
        public APIResponse GetVisits(Analytics analytics )
        {
          

            if(analytics.ImpressionsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                analytics.ImpressionsId = Guid.NewGuid();
            }

            object obj = new
            {
                ClicksId            = analytics.ImpressionsId,
                PropertyListingId   = analytics.PropertyListingId,
                AgentId             = analytics.AgentId,
            };

           _IgenericRepository.ExecuteQuery<Analytics>(obj, "usp_Create_Update_Visits").ToList();

            return APIResponse;
        }
        
        public APIResponse GetAnalytics(Agentcs agentcs  )
        {
            object obj = new
            {
                AgentId = agentcs.AgentId
            };
           List<AnalyticsView> analyticsViews = _IgenericRepository.ExecuteQuery<AnalyticsView>(obj, "usp_Get_ImpressionsAndVisit").ToList();
            APIResponse.Response = analyticsViews;
            return APIResponse;
        }
        
        public APIResponse GetTotalImpressionsGraph(Agentcs agentcs  )
        {
            object obj = new
            {
                AgentId = agentcs.AgentId
            };
           List<AnalyticsView> analyticsViews = _IgenericRepository.ExecuteQuery<AnalyticsView>(obj, "usp_GetTotalTmpressionsGraph").ToList();
            APIResponse.Response = analyticsViews;
            return APIResponse;
        }
        
        public APIResponse GetTotalViewsGraph(Agentcs agentcs  )
        {
            object obj = new
            {
                AgentId = agentcs.AgentId
            };
           List<AnalyticsView> analyticsViews = _IgenericRepository.ExecuteQuery<AnalyticsView>(obj, "usp_GetTotalViewsGraph").ToList();
            APIResponse.Response = analyticsViews;
            return APIResponse;
        }
        
        public APIResponse GetTotalImpressionsAndVisitGraph(Agentcs agentcs  )
        {
            object obj = new
            {
                AgentId = agentcs.AgentId
            };
           List<AnalyticsView> analyticsViews = _IgenericRepository.ExecuteQuery<AnalyticsView>(obj, "usp_GetTotalImpressionsAndVisitGraph").ToList();
            APIResponse.Response = analyticsViews;
            return APIResponse;
        }

        
    }
}
