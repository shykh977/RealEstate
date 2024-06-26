namespace PropertyBackend.Model
{
    public class UserRoles
    {
      public Guid  UserRolesId {get;set;}
      public Guid  BusinessId {get;set;}
      public Guid UserId { get;set;}
      public string?  RoleName    {get;set;}
      public string?  Roles       { get; set; }
      public string? NavUrl { get; set; }


    }
}
