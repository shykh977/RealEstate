namespace PropertyBackend.Model
{
    public class AgentUsers
    {
      public string?  AgentUserName {get;set;}
      public string?  AgentUserEmail {get;set;}
      public Guid  AgentUserId   {get;set;}
      public Guid AgentId { get; set; }
    }
}
