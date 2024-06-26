namespace PropertyBackend.Model.ViewModel
{
    public class BankServiceDetailView
    {

        public Guid BankServicesId { get; set; }
        public Guid UserId { get; set; }
        public Guid BankServiceDetailId { get; set; }
        public string? BankServiceDetailName { get; set; }
        public string? ServiceType { get; set; }
        public string? BankName { get; set; }
        public string? Logo { get; set; }
        public float InterestRate { get; set; }
        public int IsKibor { get; set; }


    }
}
