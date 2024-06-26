namespace PropertyBackend.Model.ViewModel
{
    public class ReelsView
    {
        public Guid VideoReelsId { get; set; }
        public Guid AgentId      { get; set; }
       
      
        public int IsApproved { get; set; }
        public string? AgentName { get; set; }
        public DateTime InsertedOn { get; set; }
        public string? ReelUrl   { get; set; }
        public string? Logo { get; set; }

        
        
        public string? Description { get; set; }
        public string? HashTag { get; set; }
    }
}
