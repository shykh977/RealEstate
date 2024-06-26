namespace PropertyBackend.Model
{
    public class AssignUserRole
    {
      public Guid  AssignUserRoleId   {get;set;}
      public Guid  UserId             {get;set;}
      public Guid  UserRolesId        {get;set;}
      public Guid InsertedBy { get;set;}
      public Guid  BusinessId         { get; set; }
    }
}
