namespace PropertyBackend.Model
{
    public class ReelsLikesAndShare
    {
       public Guid ReelsLikesAndShareId     {get;set;}
       public Guid VideoReelsId             {get;set;}
       public Guid CustomerId               {get;set;}        
       public int  IsLike { get; set; }
       public int  IsShare { get; set; }
       public string? Device                {get;set;}
       public string? Type                  {get;set;}
       public string? Brand                 {get;set;}
       public string? Physical              {get;set;}
       public string? Manufacture           {get;set;}
       public string? Version { get; set; }
       
    }
}
