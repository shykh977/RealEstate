using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;

namespace PropertyBackend.DataLayer
{
    public class ProjectService
    {

        private IGenericRepository<Project> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public ProjectService(IGenericRepository<Project> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        public APIResponse GetProjects(PropertyListingView projectView )
        {
            object obj = new
            {
                LocationId = projectView.LocationId,
                CityId = projectView.CityId,
                OFFSET = projectView.OFFSET
            };
            List<ProjectView> projectViews  = _IgenericRepository.ExecuteQuery<ProjectView>(obj, "usp_GetProjectsNew").ToList();

            foreach (var pro in projectViews)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.BuildersId,
                    PropertyListingId = pro.ProjectId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }
            APIResponse.Response = projectViews;
            return APIResponse;
        }
        
        
        public APIResponse GetProjectsAll(PropertyListingView projectView )
        {
            object obj = new
            {
                BusinessId = projectView.BusinessId,
               
                OFFSET = projectView.OFFSET
            };
            List<ProjectView> projectViews  = _IgenericRepository.ExecuteQuery<ProjectView>(obj, "usp_GetProjects").ToList();

            foreach (var pro in projectViews)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.BuildersId,
                    PropertyListingId = pro.ProjectId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }
            APIResponse.Response = projectViews;
            return APIResponse;
        }
        
        public APIResponse GetPopularProjects(BuildersAndDevelopers buildersAndDevelopers)
        {
            object obj = new
            {
                BusinessId = buildersAndDevelopers.BusinessId
            };
            List<ProjectView> projectViews  = _IgenericRepository.ExecuteQuery<ProjectView>(obj, "usp_GetPopularProjects").ToList();
          
            
            APIResponse.Response = projectViews;
            return APIResponse;
        }
        
        public APIResponse GetProjectBuildersForListing(BuildersAndDevelopers buildersAndDevelopers)
        {
            object obj = new
            {
                BuildersId = buildersAndDevelopers.BuildersId
            };
            List<ProjectView> projectViews  = _IgenericRepository.ExecuteQuery<ProjectView>(obj, "usp_GetProjectBuildersForListing").ToList();
            APIResponse.Response = projectViews;
            return APIResponse;
        }
        
        public APIResponse GetProjectDetail(Project project)
        {
            object obj = new
            {
                ProjectId = project.ProjectId
            };
            List<ProjectView> projectViews  = _IgenericRepository.ExecuteQuery<ProjectView>(obj, "usp_GetProjectDetail").ToList();

            foreach (var pro in projectViews)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.BuildersId,
                    PropertyListingId = pro.ProjectId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }



            APIResponse.Response = projectViews;
            return APIResponse;
        }


        public APIResponse GetProjectDetailMobile(Project project)
        {



            ProjectView PL = new ProjectView();
            object obj = new
            {
                ProjectId = project.ProjectId
            };
            
            object obj02 = new
            {
                PropertyListingId = project.ProjectId
            };



            PL = _IgenericRepository.ExecuteQuery<ProjectView>(obj, "usp_GetProjectDetail").FirstOrDefault();
            PL.imagesViews = _IgenericRepository.ExecuteQuery<PropertyImagesView>(obj02, "usp_GetPropertyImages").ToList();


            List<ProjectView> projectViews = _IgenericRepository.ExecuteQuery<ProjectView>(obj, "usp_GetProjectDetail").ToList();



            foreach (var pro in projectViews)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.BuildersId,
                    PropertyListingId = pro.ProjectId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }



            APIResponse.Response = PL;
            return APIResponse;
        }




        public APIResponse GetProjectByBuilders(BuildersAndDevelopers buildersAndDevelopers)
        {
            object obj = new
            {
                BuildersId = buildersAndDevelopers.BuildersId
            };
            List<ProjectView> projectViews  = _IgenericRepository.ExecuteQuery<ProjectView>(obj, "usp_GetProjectByBuilders").ToList();
            APIResponse.Response = projectViews;
            return APIResponse;
        }
        
        public APIResponse CreateProject(Project project)
        {           
            _IgenericRepository.ExecuteQuery<Project>(project, "usp_Create_Update_Project").ToList();         
            return APIResponse;
        }
                      
        public APIResponse CreateProjectInformation(PropertyInformation propertyInformation)
        {
            propertyInformation.ProjectInformationId = Guid.NewGuid();
            _IgenericRepository.ExecuteQuery<PropertyInformation>(propertyInformation, "usp_Create_Update_ProjectInformation").ToList();         
            return APIResponse;
        }
        
        public APIResponse GetProjectAmenities(PropertyInformation? propertyInformation)
        {
            object obj = new
            {
                ProjectId = propertyInformation.ProjectId
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetProjectAmenities").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetprojectInformation(PropertyInformation? propertyInformation)
        {
            object obj = new
            {
                ProjectId = propertyInformation.ProjectId
            };
            List<PropertyInformation> PT = _IgenericRepository.Search<PropertyInformation>(obj, "usp_GetprojectInformation").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetFloorsInProject(PropertyInformation? propertyInformation)
        {
            object obj = new
            {
                ProjectId = propertyInformation.ProjectId
            };
            List<PropertyInformation> PT = _IgenericRepository.Search<PropertyInformation>(obj, "usp_GetFloorsInProject").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetGetAppartmentsInFloor(PropertyInformation? propertyInformation)
        {
            object obj = new
            {
                ProjectId = propertyInformation.ProjectId,
                FloorNo = propertyInformation.FloorNo
            };
            List<PropertyInformation> PT = _IgenericRepository.Search<PropertyInformation>(obj, "usp_GetAppartmentsInFloor").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }

        public APIResponse ExpireProject(Project project)
        {
            object obj = new
            {
                ProjectId = project.ProjectId
            };

            _IgenericRepository.ExecuteQuery<Project>(obj, "usp_ExpireProject").ToList();
            return APIResponse;
        }


        public APIResponse ProjectListingConfiguration(ProjectView projectView  )
        {
            object obj = new
            {
                ProjectId = projectView.ProjectId,
                ListingType = projectView.ListingType,
            };


            object obj2 = new
            {
                AgentId = projectView.BuildersId
            };
            var agentpackge = _IgenericRepository.Search<AgentPackageDetailView>(obj2, "usp_GetAgentPackage").FirstOrDefault();

            var agentPropertyStatusViews = _IgenericRepository.Search<AgentPropertyStatusView>(obj2, "usp_GetPropertyCountForAgents").FirstOrDefault();




            if (projectView.ListingType == "SHT")
            {
                int SuperHotListing = agentpackge.SuperHotListing;
                if (SuperHotListing > 0)
                {

                    if (agentPropertyStatusViews.TotalSuperHotListProperty == SuperHotListing)
                    {
                        APIResponse.StatusMessage = "You have Reached Maximum Number Of Super Hot List";
                    }
                    else
                    {
                        _IgenericRepository.ExecuteQuery<PropertyListingView>(obj, "usp_ProjectListingConfiguration").ToList();
                        APIResponse.StatusMessage = "Property Mark As Super Hot Listed";
                    }
                }
                else
                {
                    APIResponse.StatusMessage = "Super Hot Listing Is Not In Your Current Package";
                }
            }


           

            return APIResponse;
        }


        public APIResponse RefreshProject(Project project )
        {
            object obj = new
            {
                ProjectId = project.ProjectId,
            };
            _IgenericRepository.ExecuteQuery<PropertyImagesView>(obj, "usp_RefreshProject").FirstOrDefault();

            return APIResponse;
        }
    }
}
