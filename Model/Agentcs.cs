namespace PropertyBackend.Model
{
    public class Agentcs :BaseModel
    {
      public Guid  AgentId         {get;set;}
      public  string? AgentName     {get;set;}
      public  string? Logo          {get;set;}

       public  string?  OfficeNo        {get;set;}
       public  string?  MobileNo        {get;set;}
       public  string?  Biography       {get;set;}
        public int LocationId { get; set; }
    }
}
