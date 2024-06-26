using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;

namespace PropertyBackend.DataLayer
{
    public class KarsazService
    {
        private IGenericRepository<Karsaz> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public KarsazService(IGenericRepository<Karsaz> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="karsazCategories"></param>
        /// <returns></returns>
        public APIResponse CreateKarsazCategory(KarsazCategories karsazCategories )
        {

            if(karsazCategories.KarsazCategoryId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                karsazCategories.KarsazCategoryId = Guid.NewGuid();
            }
            var Karsaz = _IgenericRepository.Search<KarsazCategories>(karsazCategories, "usp_Create_Update_KarsazCategory").FirstOrDefault();
            APIResponse.Response = Karsaz;
            return APIResponse;
        }

        public APIResponse GetKarsazCategory(KarsazCategories karsazCategories)
        {
            object obj = new
            {
                UserId = karsazCategories.UserId,
                CategoryType = karsazCategories.CategoryType
            };
            List<KarsazCategories> karsazs = _IgenericRepository.Search<KarsazCategories>(obj, "usp_GetKarsazCategory").ToList();
            APIResponse.Response = karsazs;
            return APIResponse;
        }
        public APIResponse GetKarsazCategoryById(KarsazCategories karsazCategories)
        {
            object obj = new
            {
                KarsazCategoryId = karsazCategories.KarsazCategoryId
            };
            var karsazs = _IgenericRepository.Search<KarsazCategories>(obj, "usp_GetKarsazCategory").FirstOrDefault();
            APIResponse.Response = karsazs;
            return APIResponse;
        }
        public APIResponse DeleteKarsazCategory(KarsazCategories karsazCategories)
        {
            object obj = new
            {
                KarsazCategoryId = karsazCategories.KarsazCategoryId
            };
            var karsazs = _IgenericRepository.Search<KarsazCategories>(obj, "usp_DeleteKarsazCategory").FirstOrDefault();
            APIResponse.StatusMessage = "Category Has Been Deleted";
            return APIResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="karsaz"></param>
        /// <returns></returns>

        public APIResponse CreateKarsaz(Karsaz karsaz)
        {

            if(karsaz.KarsazId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                karsaz.KarsazId = Guid.NewGuid();
            }
            var Karsaz = _IgenericRepository.Search<Karsaz>(karsaz, "usp_Create_Update_Karsaz").FirstOrDefault();
            APIResponse.Response = Karsaz;
            return APIResponse;
        } 
        
        
        public APIResponse GetKarsaz(Karsaz karsaz)
        {
            object obj = new
            {
                KarsazType = karsaz.KarsazType
            };
            List<KarsazView> karsazs = _IgenericRepository.Search<KarsazView>(obj, "usp_GetKarsaz").ToList();
            APIResponse.Response = karsazs;
            return APIResponse;
        }
         
        public APIResponse GetKarsazByCategory(Karsaz karsaz)
        {
            object obj = new
            {
                KarsazCategoryId = karsaz.KarsazCategoryId
            };
            List<KarsazView> karsazs = _IgenericRepository.Search<KarsazView>(obj, "usp_GetKarsazByCategory").ToList();
            APIResponse.Response = karsazs;
            return APIResponse;
        }  
        
        
        public APIResponse GetTeammatesSearchFilter(TeammatesSearchFilter teammatesSearchFilter)
        {
           
            List<KarsazView> karsazs = _IgenericRepository.Search<KarsazView>(teammatesSearchFilter, "usp_GetTeammatesSearchFilter").ToList();
            APIResponse.Response = karsazs;
            return APIResponse;
        }
        public APIResponse GetKARIGEERSearchFilter(TeammatesSearchFilter teammatesSearchFilter)
        {
           
            List<KarsazView> karsazs = _IgenericRepository.Search<KarsazView>(teammatesSearchFilter, "usp_GetKARIGEERSearchFilterKARIGEER").ToList();
            APIResponse.Response = karsazs;
            return APIResponse;
        }
        
        
        public APIResponse GetKarsazById(Karsaz karsaz)
        {
            object obj = new
            {
                KarsazId = karsaz.KarsazId
            };
            var karsazs = _IgenericRepository.Search<KarsazView>(obj, "usp_GetKarsaz").FirstOrDefault();
            APIResponse.Response = karsazs;
            return APIResponse;
        } 
        
        
      
        
        public APIResponse DeleteKarsaz(Karsaz karsaz)
        {
            object obj = new
            {
                KarsazId = karsaz.KarsazId
            };
            var karsazs = _IgenericRepository.Search<Karsaz>(obj, "usp_DeleteKarsaz").FirstOrDefault();
            APIResponse.Response = karsazs;
            return APIResponse;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="karsazDetail"></param>
        /// <returns></returns>
        public APIResponse CreateKarsazDetail(KarsazDetail karsazDetail)
        {

            if(karsazDetail.KarsazDetailId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                karsazDetail.KarsazDetailId = Guid.NewGuid();
            }
            var Karsaz = _IgenericRepository.Search<KarsazDetail>(karsazDetail, "usp_Create_Update_KarsazDetail").FirstOrDefault();
            APIResponse.Response = Karsaz;
            return APIResponse;
        }

        public APIResponse GetKarsazDetail(Karsaz karsaz)
        {
            object obj = new
            {
                KarsazId = karsaz.KarsazId
            };
            List<KarsazDetailView> karsazs = _IgenericRepository.Search<KarsazDetailView>(obj, "usp_GetKarsazDetail").ToList();
            APIResponse.Response = karsazs;
            return APIResponse;
        }



        public APIResponse GetKarsazDetailMobile(Karsaz karsaz)
        {
            object obj = new
            {
                KarsazId = karsaz.KarsazId
            };
            var karsazs = _IgenericRepository.Search<KarsazDetailView>(obj, "usp_GetKarsazDetail").FirstOrDefault();
            APIResponse.Response = karsazs;
            return APIResponse;
        }

        public APIResponse GetKarsazDetailById(KarsazDetail karsaz)
        {
            object obj = new
            {
                KarsazDetailId = karsaz.KarsazDetailId
            };
            List<KarsazDetailView> karsazs = _IgenericRepository.Search<KarsazDetailView>(obj, "usp_GetKarsazDetail").ToList();
            APIResponse.Response = karsazs;
            return APIResponse;
        } 
        
        public APIResponse DeleteKarsazDetail(KarsazDetail karsaz)
        {
            object obj = new
            {
                KarsazDetailId = karsaz.KarsazDetailId
            };
            var karsazs = _IgenericRepository.Search<KarsazDetailView>(obj, "usp_DeleteKarsazDetail").ToList();
            APIResponse.Response = karsazs;
            return APIResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="karsazDetailDescription"></param>
        /// <returns></returns>

        public APIResponse CreateKarsazDetailDescription(KarsazDetailDescription karsazDetailDescription)
        {

            if (karsazDetailDescription.KarsazDetailDescriptionId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                karsazDetailDescription.KarsazDetailDescriptionId = Guid.NewGuid();
            }
            var Karsaz = _IgenericRepository.Search<KarsazDetailDescription>(karsazDetailDescription, "usp_Create_Update_KarsazDetailDescription").FirstOrDefault();
            APIResponse.Response = Karsaz;
            return APIResponse;
        }
        public APIResponse GetKarsazDetailDescription(KarsazDetailDescription karsazDetailDescription)
        {
            object obj = new
            {
                KarsazDetailId = karsazDetailDescription.KarsazDetailId
            };
            List<KarsazDetailDescription> KDD = _IgenericRepository.Search<KarsazDetailDescription>(obj, "usp_GetKarsazDetailDescription").ToList();
            APIResponse.Response = KDD;
            return APIResponse;
        }        
        public APIResponse GetKarsazDetailDescriptionById(KarsazDetailDescription karsazDetailDescription)
        {
            object obj = new
            {
                KarsazDetailDescriptionId = karsazDetailDescription.KarsazDetailDescriptionId
            };
            var KDD = _IgenericRepository.Search<KarsazDetailDescription>(obj, "usp_GetKarsazDetailDescription").FirstOrDefault();
            APIResponse.Response = KDD;
            return APIResponse;
        }        
        public APIResponse DeleteKarsazDetailDescription(KarsazDetailDescription karsazDetailDescription)
        {
            object obj = new
            {
                KarsazDetailDescriptionId = karsazDetailDescription.KarsazDetailDescriptionId
            };
            var KDD = _IgenericRepository.Search<KarsazDetailDescription>(obj, "usp_DeleteKarsazDetailDescription").FirstOrDefault();
            APIResponse.Response = KDD;
            return APIResponse;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="karigarComments"></param>
        /// <returns></returns>

        public APIResponse CreatekarigarComments(karigarComments karigarComments)
        {

            if (karigarComments.karigarCommentsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                karigarComments.karigarCommentsId = Guid.NewGuid();
            }
            var Karsaz = _IgenericRepository.Search<karigarComments>(karigarComments, "usp_Create_Update_karigarComments").FirstOrDefault();
            APIResponse.Response = Karsaz;
            return APIResponse;
        }



        public APIResponse GetkarigarComments(Karsaz customers)
        {
            object obj = new
            {
                KarsazId = customers.KarsazId
            };
            List<karigarCommentsView> KDD = _IgenericRepository.Search<karigarCommentsView>(obj, "usp_GetkarigarComments").ToList();
            APIResponse.Response = KDD;
            return APIResponse;
        }
    }
}
