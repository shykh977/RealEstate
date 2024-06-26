using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;

namespace PropertyBackend.DataLayer
{
    public class BankService
    {
        private IGenericRepository<Banks> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public BankService(IGenericRepository<Banks> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="banks"></param>
        /// <returns></returns>
        public APIResponse CreateBanks(Banks banks)
        {
            if (banks.BankId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                banks.BankId = Guid.NewGuid();
            }
           
            APIResponse.Response = _IgenericRepository.ExecuteQuery<Banks>(banks, "usp_Create_Update_Banks").ToList();
            return APIResponse;
        }
        
        public APIResponse GetBanks(Banks banks)
        {                                            
            List<Banks> BankList = _IgenericRepository.ExecuteQuery<Banks>(banks, "usp_GetBanks").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        }
        
        public APIResponse GetBanksById(Banks banks)
        {
            object obj = new
            {
                BankId = banks.BankId
            };

            List<Banks> BankList = _IgenericRepository.ExecuteQuery<Banks>(banks, "usp_GetBanks").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        } 
        
        public APIResponse DeleteBanks(Banks banks)
        {
            object obj = new
            {
                BankId = banks.BankId
            };
            APIResponse.Response = _IgenericRepository.ExecuteQuery<Banks>(obj, "usp_DeleteBanks").ToList();
            return APIResponse;
        } 
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="bankServices"></param>
        /// <returns></returns>
        
        public APIResponse CreateBankServices(BankServices bankServices )
        {

            if (bankServices.BankServicesId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                bankServices.BankServicesId = Guid.NewGuid();
            }
            APIResponse.Response = _IgenericRepository.ExecuteQuery<BankServices>(bankServices, "usp_Create_Update_BankServices").ToList();
            return APIResponse;
        }
        
        public APIResponse GetBankServices(BankServices bankServices)
        {
            object obj = new
            {
                BankId = bankServices.BankId
            };
            List<BankServices> BankList = _IgenericRepository.ExecuteQuery<BankServices>(obj, "usp_GetBankServices").ToList();
            APIResponse.Response = BankList;
            return APIResponse;        
        }
        
        public APIResponse GetBankServicesById(BankServices bankServices )
        {
            object obj = new
            {
                BankServicesId = bankServices.BankServicesId
            };
            List<BankServices> BankList = _IgenericRepository.ExecuteQuery<BankServices>(obj, "usp_GetBankServices").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        } 
        
        public APIResponse DeleteBankServices(BankServices bankServices)
        {
            object obj = new
            {
                BankServicesId = bankServices.BankServicesId
            };
            APIResponse.Response = _IgenericRepository.ExecuteQuery<Banks>(obj, "usp_DeleteBankServices").ToList();
            return APIResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bankServicesDetail"></param>
        /// <returns></returns>

        public APIResponse CreateBankServicesDetail(BankServiceDetail bankServicesDetail)
        {


            if(bankServicesDetail.BankServiceDetailId.ToString()  == "00000000-0000-0000-0000-000000000000")
            {
                bankServicesDetail.BankServiceDetailId = Guid.NewGuid();
            }


            APIResponse.Response = _IgenericRepository.ExecuteQuery<BankServiceDetail>(bankServicesDetail, "usp_Create_Update_BankServiceDetail").ToList();
            return APIResponse;
        }

        //public APIResponse GetBankServicesDetail(BankServiceDetail bankServicesDetail)
        //{
        //    object obj = new
        //    {
        //        UserId = bankServicesDetail.UserId
        //    };
        //    List<BankServiceDetail> BankList = _IgenericRepository.ExecuteQuery<BankServiceDetail>(obj, "usp_GetBankServiceDetail").ToList();
        //    APIResponse.Response = BankList;
        //    return APIResponse;
        //}

        public APIResponse GetBankServicesDetailById(BankServiceDetail bankServicesDetail)
        {
            object obj = new
            {
                BankServiceDetailId = bankServicesDetail.BankServiceDetailId
            };
            List<BankServiceDetailView> BankList = _IgenericRepository.ExecuteQuery<BankServiceDetailView>(obj, "usp_GetBankServiceDetail").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        }

        public APIResponse DeleteBankServiceDetail(BankServiceDetail bankServicesDetail)
        {
            object obj = new
            {
                BankServiceDetailId = bankServicesDetail.BankServiceDetailId
            };
            APIResponse.Response = _IgenericRepository.ExecuteQuery<Banks>(obj, "usp_DeleteBankServiceDetail").ToList();
            return APIResponse;
        }


        /////// Bank Load Frond End Services

        public APIResponse GetBankServicesDetail(BaseModel baseModel )
        {
            object obj = new
            {
                BusinessId = baseModel.BusinessId
            };
            List<BankLoanView> BankList = _IgenericRepository.ExecuteQuery<BankLoanView>(obj, "usp_GetBankLoan").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        }
    }
}
