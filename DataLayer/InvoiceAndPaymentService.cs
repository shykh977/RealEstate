using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
namespace PropertyBackend.DataLayer
{
    public class InvoiceAndPaymentService
    {

        private IGenericRepository<PackageInvoice> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public InvoiceAndPaymentService(IGenericRepository<PackageInvoice> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }


        public APIResponse GetInvoice(PackageInvoice packageInvoice  )
        {
            object obj = new
            {
                InvoiceId = packageInvoice.PackageInvoiceId
            };
           List<PackageInvoiceView> packageInvoices =  _IgenericRepository.ExecuteQuery<PackageInvoiceView>(obj, "usp_GetInvoice").ToList();
            APIResponse.Response = packageInvoices;
            return APIResponse;
        }
        
        public APIResponse GetInvoiceAll(PackageInvoice packageInvoice  )
        {
            object obj = new
            {
                BusinessId = packageInvoice.BusinessId
            };
           List<PackageInvoiceView> packageInvoices =  _IgenericRepository.ExecuteQuery<PackageInvoiceView>(obj, "usp_GetInvoiceAll").ToList();
            APIResponse.Response = packageInvoices;
            return APIResponse;
        }
        
        public APIResponse GetInvoicePayment(PackageInvoice packageInvoice  )
        {
            object obj = new
            {
                BusinessId = packageInvoice.BusinessId
            };
           List<InvoicePaymentView> packageInvoices =  _IgenericRepository.ExecuteQuery<InvoicePaymentView>(obj, "usp_GetInvoicePayment").ToList();
            APIResponse.Response = packageInvoices;
            return APIResponse;
        }
        
        public APIResponse CreateInvoicePayment(InvoicePayment invoicePayment   )
        {

            if(invoicePayment.PaymentId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                invoicePayment.PaymentId = Guid.NewGuid();
            }

           _IgenericRepository.ExecuteQuery<InvoicePayment>(invoicePayment, "usp_Create_Update_InvoicePayment").ToList();
         
            return APIResponse;
        }

        
    }
}
