namespace PropertyBackend.Model
{
    public class CustomerChats
    {

      public Guid   CustomerChatsId   { get;set;}
      public Guid   CustomerId       {get;set;}
      public Guid   AgentId          {get;set;}
      public string Messages        { get; set; }


    }
}
