namespace PropertyBackend.Model.ViewModel
{
    public class AgentView
    {


        public Guid AgentId { get; set; }
        public string? AgentName { get; set; }
        public string? Email { get; set; }
        public string? OfficeNo { get; set; }
        public string? Biography { get; set; }
        public string? AgentAddress { get; set; }
        public string? OwnerName { get; set; }
        public string? Logo { get; set; }
        public string? CityName { get; set; }
        public string? LocationName { get; set; }
        public string? AgentSince { get; set; }
        public string? AgentNo { get; set; }
        public string? PortalNews { get; set; }
        public int SALE { get; set; }
        public int RENT { get; set; }
        public Guid BusinessId { get; set; }
    }
}
