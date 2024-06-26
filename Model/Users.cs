namespace PropertyBackend.Model
{
    public class Users : BaseModel
    {

      public int     UserType       {get;set;}
      public Guid    UserTypeId     {get;set;}
      public string?  UserName       {get;set;}
      public string?  Email          {get;set;}
      public string? Password { get; set; }


    }
}
