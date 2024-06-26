namespace PropertyBackend.Model.ViewModel
{
    public class karigarCommentsView
    {
        public Guid karigarCommentsId { get; set; }
        public Guid karigarId { get; set; }
        public string? Comment { get; set; }
        public string CustomerName { get; set; }
        public int DaysAgo { get; set; }
        public float Rating { get; set; }

    }
}
