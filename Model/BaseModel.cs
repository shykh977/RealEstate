namespace PropertyBackend.Model
{
    public class BaseModel
    {

      public Guid  UserId            {get;set;}
      public Guid  BusinessId        {get;set;}
      public Guid  AgentId           {get;set;}
        public int IsActive { get; set; } = 1;
        public int IsDeleted { get; set; } = 0;
   


    }
}
