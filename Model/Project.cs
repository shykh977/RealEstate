namespace PropertyBackend.Model
{
    public class Project
    {



      public Guid  ProjectId            {get;set;}      
      public Guid BusinessId { get;set;}      
      public string?  ProjectName        {get;set;}
      public int LocationId            {get;set;}
      public string?  Description        {get;set;}
      public string?  Price              {get;set;}
      public Guid CurrencyId            {get;set;}
      public Guid UserId { get;set;}
      public Guid BuildersId            {get;set;}
      public string?  ProjectType        {get;set;}
      public string? Thumbnail { get; set; }

    
    }
}
