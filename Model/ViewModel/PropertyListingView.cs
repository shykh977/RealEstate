namespace PropertyBackend.Model.ViewModel
{
    public class PropertyListingView
    {
      public string?  PropertyImage               {get;set;}
      public string? PropertyTypeName { get;set;}
      public string? ListingType { get;set;}
      public Guid AgentId { get;set;}
      public string? CityId { get;set;}
      public Guid BusinessId { get;set;}
      public string?  AgentName                   {get;set;}
      public string? AgentUserName { get;set;}
      public string?  CityName                    {get;set;}
      public string?  LocationName                {get;set;}
      public Guid  PropertyListingId           {get;set;}
      public string?  PropertyListingName         {get;set;}
      public string?  LocationId                  {get;set;}
      public string?  Description                 {get;set;}
      public float  Price                       {get;set;}
      public int  IsListing                   {get;set;}
      public int  IsHotListing                {get;set;}
      public int IsSuperHotListing           {get;set;}
      public string? InsertedOn { get; set; }
       public string?  SQFT             { get; set; }
       public string?  Bathroom         { get; set; }
       public string? Bedroom { get; set; }
       public string? PropertyListingAmenitiesName { get; set; }
       public string? Thumbnail { get; set; }
       public string? Status { get; set; }
       public string? PropertyType { get; set; }
       public string? AgentLogo { get; set; }
       public string? OfficeNo { get; set; }
       public string? AgentCity { get; set; }
       public string? PropertyNo { get; set; }
       public string? AgentAddress { get; set; }
       public int TotalProperties { get; set; }
       public int OFFSET { get; set; }
       public int IsApprove { get; set; }
       public string? Icon { get; set; }
     

        public List<PropertyImagesView>? imagesViews { get; set; }



    }
}
