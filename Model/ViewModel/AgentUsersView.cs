namespace PropertyBackend.Model.ViewModel
{
    public class AgentUsersView
    {
        public string? AgentUserName { get; set; }
        public string? OfficeNo { get; set; }
        public string? Email { get; set; }
        public string? AgentName { get; set; }
        public string? AgentAddress { get; set; }
        public string? Logo { get; set; }

        public string? CityName { get; set; }
        public string? LocationName { get; set; }
public Guid AgentUserId { get; set; }
        public Guid AgentId { get; set; }
    }
}
