using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyBackend.Common;
using PropertyBackend.DataLayer;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;


namespace PropertyBackend.DataLayer
{
    public class PackageCategoryService
    {
        private IGenericRepository<PackageCategories> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public PackageCategoryService(IGenericRepository<PackageCategories> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }


        public APIResponse GetPackageCategory(PackageCategories packageCategories  )
        {
            object obj = new
            {
                BusinessId = packageCategories.BusinessId
            };
            List<PackageCategories> projectViews = _IgenericRepository.ExecuteQuery<PackageCategories>(obj, "usp_GetPackageCategory").ToList();
            APIResponse.Response = projectViews;
            return APIResponse;
        }
        
        public APIResponse GetPackageSubCategory(PackageCategories packageCategories)
        {
            object obj = new
            {
                PackageCategoryId = packageCategories.PackageCategoryId
            };
            List<PackageSubCategory> projectViews = _IgenericRepository.ExecuteQuery<PackageSubCategory>(obj, "usp_GetPackageSubCategory").ToList();
            APIResponse.Response = projectViews;
            return APIResponse;
        }
        
        public APIResponse GetPackageSubscribers(PackageSubCategory packageSubCategory)
        {
            object obj = new
            {
                PackageSubCategoryId = packageSubCategory.PackageSubCategoryId
            };
            List<PackageDetail> projectViews = _IgenericRepository.ExecuteQuery<PackageDetail>(obj, "usp_GetPackageSubscribers").ToList();
            APIResponse.Response = projectViews;
            return APIResponse;
        } 
        
        public APIResponse GetPackages(PackageSubCategory packageSubCategory)
        {
            object obj = new
            {
                PackageSubCategoryId = packageSubCategory.PackageSubCategoryId
            };
            List<PackageDetail> projectViews = _IgenericRepository.ExecuteQuery<PackageDetail>(obj, "usp_GetPackages").ToList();
            APIResponse.Response = projectViews;
            return APIResponse;
        }
        
        
        
        public APIResponse AssignPackage(PackageSubCategory packageDetail )
        {

            List<PackageDetail> PD = new List<PackageDetail>();


            var PackageDetailId = Guid.NewGuid();

            object obj2 = new
            {
                PackageSubCategoryId = packageDetail.PackageSubCategoryId
            };

            var projectViews = _IgenericRepository.ExecuteQuery<PackageDetail>(obj2, "usp_GetPackages").FirstOrDefault();

            projectViews.AgentId = packageDetail.AgentId;
            projectViews.PackageDetailId = PackageDetailId;

            var PackageDetail = _IgenericRepository.ExecuteQuery<PackageDetail>(projectViews, "usp_Create_Update_PackageDetail").FirstOrDefault();


            object obj3 = new
            {

               AgentPackageDetailId = Guid.NewGuid(),
               UserId = packageDetail.UserId,
               BusinessId = PackageDetail.BusinessId,
               AgentId = PackageDetail.AgentId,
               PackageDetailId = PackageDetailId,
               TotalCredits = PackageDetail.RefreshCredit,
               ConsumeCredits = 0,
               Remaining = PackageDetail.RefreshCredit,
               TotalListing = PackageDetail.Listing,
               TotalHotListing = PackageDetail.HotListing,
               TotalSuperHotListing = PackageDetail.SuperHotListing,               
               LeaderboardImpressions = PackageDetail.LeaderboardImpressions,
               HotStripImpressions = PackageDetail.HotStripImpressions,
               ProjectPusher = PackageDetail.ProjectPusher,
               SplashAdsImpressions = PackageDetail.SplashAdsImpressions,
            };



            PackageInvoice packageInvoice = new PackageInvoice
            {
            
                PackageId = packageDetail.PackageSubCategoryId,
                PackageInvoiceId = Guid.NewGuid(),
                InvoiceAmount = packageDetail.PackageAmount,
                Credit = packageDetail.PackageAmount,
                Debit =  0,
                SubscriberId = packageDetail.AgentId,
                BusinessId = PackageDetail.BusinessId,
                UserId = PackageDetail.UserId

            };


            _IgenericRepository.ExecuteQuery<PackageDetail>(obj3, "usp_Create_Update_AgentPackageDetail").FirstOrDefault();


            _IgenericRepository.ExecuteQuery<PackageInvoice>(packageInvoice, "usp_Create_Update_PackageInvoice").FirstOrDefault();



            APIResponse.Response = projectViews;
            return APIResponse;
        }



        public APIResponse CreateCustomPackage(PackageDetail CustomPackageDetail)
        {

            var PackageDetailId = Guid.NewGuid();

            CustomPackageDetail.PackageDetailId = PackageDetailId;

            var PackageDetail = _IgenericRepository.ExecuteQuery<PackageDetail>(CustomPackageDetail, "usp_Create_Update_CustomPackages").FirstOrDefault();


            /*
            object obj3 = new
            {
                AgentPackageDetailId = Guid.NewGuid(),
                UserId = CustomPackageDetail.AgentId,
                BusinessId = PackageDetail.BusinessId,
                AgentId = PackageDetail.AgentId,
                PackageDetailId = PackageDetailId,
                TotalCredits = PackageDetail.RefreshCredit,
                ConsumeCredits = 0,
                Remaining = PackageDetail.RefreshCredit,
                TotalListing = PackageDetail.Listing,
                TotalHotListing = PackageDetail.HotListing,
                TotalSuperHotListing = PackageDetail.SuperHotListing,
                LeaderboardImpressions = PackageDetail.LeaderboardImpressions,
                HotStripImpressions = PackageDetail.HotStripImpressions,
                ProjectPusher = PackageDetail.ProjectPusher,
                SplashAdsImpressions = PackageDetail.SplashAdsImpressions,
            };
            */


            PackageInvoice packageInvoice = new PackageInvoice
            {

                PackageId = PackageDetailId,
                PackageInvoiceId = Guid.NewGuid(),
                InvoiceAmount = CustomPackageDetail.PackageAmount,
                Credit = CustomPackageDetail.PackageAmount,
                Debit = 0,
                SubscriberId = PackageDetail.AgentId,
                BusinessId = PackageDetail.BusinessId,
                UserId = PackageDetail.UserId

            };


            //_IgenericRepository.ExecuteQuery<PackageDetail>(obj3, "usp_Create_Update_AgentPackageDetail").FirstOrDefault();


            _IgenericRepository.ExecuteQuery<PackageInvoice>(packageInvoice, "usp_Create_Update_PackageInvoice").FirstOrDefault();



            APIResponse.StatusMessage = "Custom Package Has Been Created";
            return APIResponse;
        }


    }
}
