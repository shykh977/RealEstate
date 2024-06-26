namespace PropertyBackend.Model
{
    public class InvoicePayment
    {
       public Guid PaymentId             {get;set;}
       public Guid InvoiceId             {get;set;}
       public Guid UserId                {get;set;}
       public Guid BusinessId            {get;set;}
       public string PaymentOption         {get;set;}
       public string TransectionId         {get;set;}
       public DateTime TransectionDate       {get;set;}
       public float TransectionAmount     {get;set;}
       public string Attachments { get; set; }
    }
}
