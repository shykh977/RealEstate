namespace PropertyBackend.Model
{
    public class PropertyInformation
    {

      public Guid  ProjectInformationId       {get;set;}
      public string?  PropertyNo               {get;set;}
      public string?  Area                     {get;set;}
      public string?  Bed                      {get;set;}
      public string?  Bath                     {get;set;}
      public Guid  ProjectId                {get;set;}
      public string?  PriceTo                  {get;set;}
      public string?  PriceFrom                {get;set;}
      public string?  PeymentPlan              {get;set;}
      public string? Block { get; set; }
      public string? FloorNo { get; set; }
      public string? PlotNo { get; set; }
       

    }
}
