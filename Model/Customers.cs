namespace PropertyBackend.Model
{
    public class Customers
    {

      public Guid   CustomerId        {get;set;}
      public string?   CustomerName      {get;set;}
      public string?   Email             {get;set;}
      public string?   ContactNumber     {get;set;}
      public string?   Password     {get;set;}
      public Guid     RefferenceId      {get;set;}
      public Guid     BusinessId          { get; set; }



    }
}
