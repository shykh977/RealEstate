using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;

namespace PropertyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceAndPaymentController : ControllerBase
    {
        private IGenericRepository<PackageInvoice> _IgenericRepository;

        InvoiceAndPaymentService InvoiceAndPaymentService   = null;

        public InvoiceAndPaymentController(IGenericRepository<PackageInvoice> igenericRepository)
        {
            InvoiceAndPaymentService = new InvoiceAndPaymentService(igenericRepository);
        }

        APIResponse APIResponse = new APIResponse();

        [HttpPost]
        [Route("GetSubscriptionInvoice")]
        public IActionResult GetInvoice(PackageInvoice packageInvoice )
        {
            return Ok(InvoiceAndPaymentService.GetInvoice(packageInvoice));
        }
        
        [HttpPost]
        [Route("GetInvoiceAll")]
        public IActionResult GetInvoiceAll(PackageInvoice packageInvoice )
        {
            return Ok(InvoiceAndPaymentService.GetInvoiceAll(packageInvoice));
        }
        
        [HttpPost]
        [Route("GetInvoicePayment")]
        public IActionResult GetInvoicePayment(PackageInvoice packageInvoice )
        {
            return Ok(InvoiceAndPaymentService.GetInvoicePayment(packageInvoice));
        }
        
        [HttpPost]
        [Route("CreateInvoicePayment")]
        public IActionResult CreateInvoicePayment(InvoicePayment invoicePayment  )
        {
            return Ok(InvoiceAndPaymentService.CreateInvoicePayment(invoicePayment));
        }
    }
}
