namespace PropertyBackend.Model
{
    public class BuildersAndDevelopers
    {

     public Guid   BuildersId               {get;set;}
     public Guid   UserId                   {get;set;}
     public Guid   BusinessId               {get;set;}
     public string?   Email                  {get;set;}
     public string?   OfficeNo               {get;set;}
     public string? Logo { get;set;}
     public string?   MobileNo               {get;set;}
     public string?   Biography              {get;set;}
     public string?   BuildersName           {get;set;}
     public string?   OwnerName              {get;set;}
     public string? BuildersAddress { get; set; }
    }
}
