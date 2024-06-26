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
    public class ProjectController : ControllerBase
    {
        private IGenericRepository<Project> _IgenericRepository;

        ProjectService _projectService  = null;

        public ProjectController(IGenericRepository<Project> igenericRepository)
        {
            _projectService = new ProjectService(igenericRepository);
        }


        [HttpPost]
        [Route("GetProjects")]
        public IActionResult GetProjects(PropertyListingView projectView)
        {
            return Ok(_projectService.GetProjects(projectView));
        }
        
        
        [HttpPost]
        [Route("GetProjectsAll")]
        public IActionResult GetProjectsAll(PropertyListingView projectView)
        {
            return Ok(_projectService.GetProjectsAll(projectView));
        }
        
        [HttpPost]
        [Route("GetPopularProjects")]
        public IActionResult GetPopularProjects(BuildersAndDevelopers buildersAndDevelopers)
        {
            return Ok(_projectService.GetPopularProjects(buildersAndDevelopers));
        }
        
        [HttpPost]
        [Route("GetProjectBuildersForListing")]
        public IActionResult GetProjectBuildersForListing(BuildersAndDevelopers buildersAndDevelopers)
        {
            return Ok(_projectService.GetProjectBuildersForListing(buildersAndDevelopers));
        }
        
        [HttpPost]
        [Route("GetProjectDetail")]
        public IActionResult GetProjectDetail(Project project  )
        {
            return Ok(_projectService.GetProjectDetail(project));
        }
        
        [HttpPost]
        [Route("GetProjectDetailMobile")]
        public IActionResult GetProjectDetailMobile(Project project  )
        {
            return Ok(_projectService.GetProjectDetailMobile(project));
        }
        
        [HttpPost]
        [Route("GetProjectByBuilders")]
        public IActionResult GetProjectByBuilders(BuildersAndDevelopers buildersAndDevelopers)
        {
            return Ok(_projectService.GetProjectByBuilders(buildersAndDevelopers));
        }
        
        [HttpPost]
        [Route("CreateProject")]
        public IActionResult CreateProject(Project project)
        {
            return Ok(_projectService.CreateProject(project));
        }
        
        [HttpPost]
        [Route("CreateProjectInformation")]
        public IActionResult CreateProjectInformation(PropertyInformation propertyInformation )
        {
            return Ok(_projectService.CreateProjectInformation(propertyInformation));
        } 
        
        [HttpPost]
        [Route("GetProjectAmenities")]
        public IActionResult GetProjectAmenities(PropertyInformation? propertyInformation )
        {
            return Ok(_projectService.GetProjectAmenities(propertyInformation));
        }
        
        [HttpPost]
        [Route("GetprojectInformation")]
        public IActionResult GetprojectInformation(PropertyInformation? propertyInformation )
        {
            return Ok(_projectService.GetprojectInformation(propertyInformation));
        }
        
        [HttpPost]
        [Route("GetFloorsInProject")]
        public IActionResult GetFloorsInProject(PropertyInformation? propertyInformation )
        {
            return Ok(_projectService.GetFloorsInProject(propertyInformation));
        }
        
        [HttpPost]
        [Route("GetAppartmentsInFloor")]
        public IActionResult GetGetAppartmentsInFloor(PropertyInformation? propertyInformation )
        {
            return Ok(_projectService.GetGetAppartmentsInFloor(propertyInformation));
        }
        
        [HttpPost]
        [Route("ExpireProject")]
        public IActionResult ExpireProject(Project project)
        {
            return Ok(_projectService.ExpireProject(project));
        }
        
        [HttpPost]
        [Route("ProjectListingConfiguration")]
        public IActionResult ProjectListingConfiguration(ProjectView project)
        {
            return Ok(_projectService.ProjectListingConfiguration(project));
        }
        
        [HttpPost]
        [Route("RefreshProject")]
        public IActionResult RefreshProject(Project  project)
        {
            return Ok(_projectService.RefreshProject(project));
        }

    }
}
