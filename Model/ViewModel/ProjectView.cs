namespace PropertyBackend.Model.ViewModel
{
    public class ProjectView
    {
        public Guid ProjectId { get; set; }
        public Guid BusinessId { get; set; }
        public int OFFSET { get; set; }
        public string? ProjectName { get; set; }
        public string? BuildersName { get; set; }
        public int LocationId { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }
        public string? Logo { get; set; }
        public string? OfficeNo { get; set; }
        public string? BuildersAddress { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid BuildersId { get; set; }
        public string? ProjectType { get; set; }
        public string? Thumbnail { get; set; }
        public string? CityName { get; set; }
        public string? LocationName { get; set; }
        public string? InsertedOn { get; set; }
        public string? ListingType { get; set; }
        public string? ProjectNo { get; set; }


       public int IsListing               {get;set;}
       public int IsHotListing            {get;set;}
       public int IsSuperHotListing { get; set; }

        public List<PropertyImagesView>? imagesViews { get; set; }
    }
}
