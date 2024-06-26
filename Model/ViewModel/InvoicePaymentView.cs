namespace PropertyBackend.Model.ViewModel
{
    public class InvoicePaymentView
    {
        public Guid PaymentId { get; set; }
        public Guid InvoiceId { get; set; }
        public Guid UserId { get; set; }
        public Guid BusinessId { get; set; }
        public string PaymentOption { get; set; }
        public string TransectionId { get; set; }
        public DateTime TransectionDate { get; set; }
        public float TransectionAmount { get; set; }
        public string Attachments { get; set; }
        public string AgentName { get; set; }
        public string BuildersName { get; set; }
        public string InvoiceNo { get; set; }
        public string PackageCategoryName { get; set; }
        public string PackageSubCategoryName { get; set; }
    }
}
