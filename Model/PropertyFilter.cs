namespace PropertyBackend.Model
{
    public class PropertyFilter
    {
       public string? CityId                    {get;set;}
       public string? LocationId                {get;set;}
       public string? Bathroom                  {get;set;}
       public string? Bedroom                   {get;set;}
       public string? PriceTo	                {get;set;}
       public string? PriceFrom                 {get;set;}
       public string? MinArea	                {get;set;}
       public string? MaxArea		            {get;set;}
       public string? PropertyTypeName          { get; set; }
       public string? Status                    { get; set; }
    }
}
