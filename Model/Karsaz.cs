namespace PropertyBackend.Model
{
    public class Karsaz
    {
       public Guid UserId            {get;set;}
       public Guid KarsazId          {get;set;}
       public Guid KarsazCategoryId { get;set;}
       public int LocationId { get;set;}
       public string? IndustryName      {get;set;}
       public string? BuildSince        {get;set;}
       public string? KarsazType { get; set; }
       public string? IndustryLogo { get; set; }
        
    }
}
