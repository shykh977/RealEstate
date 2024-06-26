using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;

namespace PropertyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private IGenericRepository<Banks> _IgenericRepository;

        BankService _bankService  = null;

        public BanksController(IGenericRepository<Banks> igenericRepository)
        {
            _bankService = new BankService(igenericRepository);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="banks"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        [Route("CreateBanks")]
        public IActionResult CreateBanks(Banks banks)
        {
            return Ok(_bankService.CreateBanks(banks));
        }
        
        [HttpPost]
        [Route("GetBanks")]
        public IActionResult GetBanks(Banks banks)
        {
            return Ok(_bankService.GetBanks(banks));
        }
        
        [HttpPost]
        [Route("GetBanksById")]
        public IActionResult GetBanksById(Banks banks)
        {
            return Ok(_bankService.GetBanksById(banks));
        }
        
        [HttpPost]
        [Route("DeleteBanks")]
        public IActionResult DeleteBanks(Banks banks)
        {
            return Ok(_bankService.DeleteBanks(banks));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bankServices"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("CreateBankServices")]
        public IActionResult CreateBankServices(BankServices bankServices)
        {
            return Ok(_bankService.CreateBankServices(bankServices));
        }
        
        [HttpPost]
        [Route("GetBankServices")]
        public IActionResult GetBankServices(BankServices bankServices)
        {
            return Ok(_bankService.GetBankServices(bankServices));
        }
        
        [HttpPost]
        [Route("GetBankServicesById")]
        public IActionResult GetBankServicesById(BankServices bankServices)
        {
            return Ok(_bankService.GetBankServicesById(bankServices));
        }
        
        [HttpPost]
        [Route("DeleteBankServices")]
        public IActionResult DeleteBankServices(BankServices bankServices)
        {
            return Ok(_bankService.DeleteBankServices(bankServices));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="bankServicesDetail"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateBankServicesDetail")]
        public IActionResult CreateBankServicesDetail(BankServiceDetail bankServicesDetail)
        {
            return Ok(_bankService.CreateBankServicesDetail(bankServicesDetail));
        }
        
        //[HttpPost]
        //[Route("GetBankServicesDetail")]
        //public IActionResult GetBankServicesDetail(BankServiceDetail bankServicesDetail)
        //{
        //    return Ok(_bankService.GetBankServicesDetail(bankServicesDetail));
        //}
        
        [HttpPost]
        [Route("GetBankServicesDetailById")]
        public IActionResult GetBankServicesDetailById(BankServiceDetail bankServicesDetail)
        {
            return Ok(_bankService.GetBankServicesDetailById(bankServicesDetail));
        }
        
        [HttpPost]
        [Route("DeleteBankServiceDetail")]
        public IActionResult DeleteBankServiceDetail(BankServiceDetail bankServicesDetail)
        {
            return Ok(_bankService.DeleteBankServiceDetail(bankServicesDetail));
        }
        
        [HttpPost]
        [Route("GetBankServicesDetail")]
        public IActionResult GetBankServicesDetail(BaseModel baseModel)
        {
            return Ok(_bankService.GetBankServicesDetail(baseModel));
        }

    }
}
