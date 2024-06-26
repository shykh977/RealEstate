namespace PropertyBackend.Model.ViewModel
{
    public class PackageInvoiceView
    {
        public Guid PackageInvoiceId { get; set; }
        public Guid SubscriberId { get; set; }
        public Guid PackageId { get; set; }
        public float InvoiceAmount { get; set; }
        public Guid BusinessId { get; set; }
        public Guid UserId { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }
        public string? PackageCategoryName { get; set; }
        public string? PackageSubCategoryName { get; set; }
        public string? InvoiceNo { get; set; }
        public string? InsertedOn { get; set; }
        public int IsPaid { get; set; }
    }
}
