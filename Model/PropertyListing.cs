namespace PropertyBackend.Model
{
    public class PropertyListing :BaseModel
    {
     public Guid   PropertyListingId         {get;set;}
     public Guid AgentId { get;set;}
     public Guid PropertyTypeId { get;set;}
     public string?   PropertyListingName       {get;set;}
     public string? LocationId                {get;set;}
     public int CityId                {get;set;}
     public string?   Description               {get;set;}
     public string?   Price                     {get;set;}
     public Guid CurrencyId                {get;set;}
     public string?  IsListing                 {get;set;}
     public string? CarParking { get;set;}
     public string? Thumbnail { get;set;}
     public string?   IsHotListing              {get;set;}
     public string?   IsSuperHotListing         {get;set;}
     public string? Refreshed { get;set;}
     public string? Status { get;set;}
     public Guid ListingId                 {get;set;}
     public Guid HotListingId              {get;set;}
     public Guid SuperHotListingId         {get;set;}
     public Guid RefreshedId { get; set; }

        public string? Bathroom { get; set; }
        public string? Bedroom { get; set; }

        public string? SQFT { get; set; }


    }
}
