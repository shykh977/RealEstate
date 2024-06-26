namespace PropertyBackend.Model
{
    public class BankServices
    {


      public Guid UserId { get;set;}
      public Guid  BankServicesId      {get;set;}
      public Guid  BankId              {get;set;}
      public string?  ServiceName      { get; set; }
    }
}
