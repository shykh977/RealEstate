namespace PropertyBackend.Model.ViewModel
{
    public class AssignUserRoleView
    {
        public Guid UserRolesId { get; set; }
        public Guid AssignUserRoleId { get; set; }
        public Guid BusinessId { get; set; }
        public Guid UserId { get; set; }
        public string? RoleName { get; set; }
        public string? Roles { get; set; }
        public string? NavUrl { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
    }
}
