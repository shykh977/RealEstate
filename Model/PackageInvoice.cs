namespace PropertyBackend.Model
{
    public class PackageInvoice
    {


        public Guid PackageInvoiceId { get; set; }
        public Guid SubscriberId { get; set; }
        public Guid PackageId { get; set; }
        public float InvoiceAmount { get; set; }
        public Guid BusinessId { get; set; }
        public Guid UserId { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }
                                   


    }
}
