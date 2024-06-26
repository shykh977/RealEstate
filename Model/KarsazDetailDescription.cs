namespace PropertyBackend.Model
{
    public class KarsazDetailDescription
    {

       public Guid KarsazDetailDescriptionId        {get;set;}
       public Guid KarsazDetailId                   {get;set;}
       public string? Images                           {get;set;}
       public string? Comments                         {get;set;}
       public float Rating { get; set; }

    }
}
