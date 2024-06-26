
namespace PropertyBackend.Model.ViewModel
{
    public class LocationDetailView
    {
        public int LocationId { get; set; }
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public string? LocationName { get; set; }
        public string? Description { get; set; }


       public List<LocationDetailView>? locationDetailViews  { get; set; }
       public List<LocationDetail>? locationDetails { get; set; }


    }
}
