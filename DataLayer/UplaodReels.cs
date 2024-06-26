using PropertyBackend.Helper;
using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;
using Microsoft.AspNetCore.Mvc;

namespace PropertyBackend.DataLayer
{
    public class UplaodReels : IUplaodReels
    {


        private readonly IWebHostEnvironment _environment;
        private IGenericRepository<VideoReels> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();


        public UplaodReels(IGenericRepository<VideoReels> igenericRepository, IWebHostEnvironment environment)
        {
            _IgenericRepository = igenericRepository;
            _environment = environment;
        }




        public async Task<APIResponse> UploadAgentReels(IFormFile file, [FromForm] Guid AgentId)
        {

            string path = "";
            string videoname = "";
            Guid FName = Guid.NewGuid();

            if (file.Length > 0)
            {
                path = Path.GetFullPath(Path.Combine(_environment.WebRootPath, "UploadedReels"));

                var fileExt = Path.GetExtension(file.FileName);

                videoname = Commons.ServerUrl + FName + file.FileName;


                VideoReels vid = new VideoReels
                {
                    VideoReelsId = Guid.NewGuid(),
                    AgentId = AgentId,
                    Reel = "",
                    ReelUrl = videoname

                };
                _IgenericRepository.Search<VideoReels>(vid, "usp_Create_Update_VideoReels").FirstOrDefault();



                if (fileExt ==".mp4" || fileExt == ".MP4")
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, FName+file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                        

                       
                    }

                    APIResponse.Response = "File Successfully Uploaded";
                    return APIResponse;
                }
                else
                {
                    APIResponse.Response = "Kindly Upload mp4 Type Only";
                    return APIResponse;
                }

                
            }
            else
            {
                APIResponse.Response = "File Is Empty";
                return APIResponse;
            }








            //foreach (var file in MediaFile)
            //{
            //    if (file.Length > 0)
            //    {
            //        using (var ms = new MemoryStream())
            //        {
            //            file.CopyTo(ms);
            //            var fileBytes = ms.ToArray();
            //            string s = Convert.ToBase64String(fileBytes);
            //            // act on the Base64 data

            //           // Base64Decode(s);

            //        }
            //    }
            //}

            //    APIResponse.StatusMessage = "File Uploaded Successfully";
            //return APIResponse;


            //    if (file.Length > 0)
            //    {
            //        path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedReels"));

            //        var fileExt =   Path.GetExtension(file.FileName);

            //        if (!Directory.Exists(path))
            //        {
            //            Directory.CreateDirectory(path);
            //        }
            //        using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
            //        {
            //            await file.CopyToAsync(fileStream);

            //            Byte[] bytes = Convert.FromBase64String(fileStream.Read().ToString());
            //            File.WriteAllBytes(path, bytes);

            //    }
            //        APIResponse.StatusMessage = "File Uploaded Successfully";
            //        return APIResponse;


            //}
            //    else
            //    {
            //    APIResponse.StatusMessage = "File Failed To Upload";
            //    return APIResponse;
            //}

        }



        public APIResponse GetVideoReels(Agentcs agentcs )
        {

            object obj = new
            {
                BusinessId = agentcs.BusinessId
            };

            List<ReelsView> BankList = _IgenericRepository.ExecuteQuery<ReelsView>(obj, "usp_GetVideoReels").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        } 
        
        
        public APIResponse GetVideoReelsByAgent(Agentcs agentcs )
        {

            object obj = new
            {
                AgentId = agentcs.AgentId
            };

            List<ReelsView> BankList = _IgenericRepository.ExecuteQuery<ReelsView>(obj, "usp_GetVideoReels").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        }
        
        
        public APIResponse GetRecentVideoReels(Agentcs agentcs )
        {

            object obj = new
            {
                BusinessId = agentcs.BusinessId
            };

            List<ReelsView> BankList = _IgenericRepository.ExecuteQuery<ReelsView>(obj, "usp_GetRecentVideoReels").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        } 
        
        public APIResponse GetVideoReelsForApproval(Agentcs agentcs )
        {

            object obj = new
            {
                BusinessId = agentcs.BusinessId
            };

            List<ReelsView> BankList = _IgenericRepository.ExecuteQuery<ReelsView>(obj, "usp_GetVideoReelsForApproval").ToList();
            APIResponse.Response = BankList;
            return APIResponse;
        }


        public APIResponse ReelsLikes(ReelsLikesAndShare reelsLikesAndShare)
        {

            Guid ReelsLikesAndShareId = Guid.NewGuid();


            if (reelsLikesAndShare.ReelsLikesAndShareId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                reelsLikesAndShare.ReelsLikesAndShareId = ReelsLikesAndShareId;
                reelsLikesAndShare.IsLike = 1;
            }

            object obj = new
            {
                VideoReelsId = reelsLikesAndShare.VideoReelsId,
                CustomerId = reelsLikesAndShare.CustomerId
            };


            var RLS = _IgenericRepository.Search<ReelsLikeAndSharesVIew>(obj, "usp_GetTotalLikesCount").FirstOrDefault();

            if (RLS.TotalLikes >0)
            {

            }
            else 
            {
                _IgenericRepository.Search<KarsazCategories>(reelsLikesAndShare, "usp_Create_Update_ReelsLikesAndShare").FirstOrDefault();

            }


            var TotalLikes = _IgenericRepository.Search<ReelsLikeAndSharesVIew>(obj, "usp_GetTotalLikesCount").FirstOrDefault();
            APIResponse.Response = TotalLikes;
            return APIResponse;
        }
        
        public APIResponse ReelsSahre(ReelsLikesAndShare reelsLikesAndShare)
        {
            Guid ReelsLikesAndShareId = Guid.NewGuid();

            if (reelsLikesAndShare.ReelsLikesAndShareId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                reelsLikesAndShare.ReelsLikesAndShareId = ReelsLikesAndShareId;
                reelsLikesAndShare.IsShare = 1;
            }


            object obj = new
            {
                VideoReelsId  = reelsLikesAndShare.VideoReelsId,
                CustomerId    = reelsLikesAndShare.CustomerId
            };

            //var RLS = _IgenericRepository.Search<ReelsLikeAndSharesVIew>(obj, "usp_GetTotalSharesCount").FirstOrDefault();

            //if (RLS.TotalShares > 0)
            //{

            //}
            //else
            //{
            //    _IgenericRepository.Search<KarsazCategories>(reelsLikesAndShare, "usp_Create_Update_ReelsLikesAndShare").FirstOrDefault();

            //}
            _IgenericRepository.Search<KarsazCategories>(reelsLikesAndShare, "usp_Create_Update_ReelsLikesAndShare").FirstOrDefault();
            var TotaShares = _IgenericRepository.Search<ReelsLikeAndSharesVIew>(obj, "usp_GetTotalSharesCount").FirstOrDefault();
            APIResponse.Response = TotaShares;
            return APIResponse;
        }  
        public APIResponse ApproveOrRejectReels(ReelsView reelsLikesAndShare)
        {
           
            object obj = new
            {
                VideoReelsId  = reelsLikesAndShare.VideoReelsId,
                IsApproved = reelsLikesAndShare.IsApproved
            };
            _IgenericRepository.Search<ReelsView>(obj, "usp_ApproveOrRejectReels").FirstOrDefault();
            APIResponse.StatusMessage = "Reel Approval Has Been Updated";
            return APIResponse;
        }
        public APIResponse DeleteReels(ReelsView reelsLikesAndShare)
        {
           
            object obj = new
            {
                VideoReelsId  = reelsLikesAndShare.VideoReelsId
            };
            _IgenericRepository.Search<ReelsView>(obj, "usp_DeleteReels").FirstOrDefault();
            APIResponse.StatusMessage = "Reel Approval Has Been Deleted";
            return APIResponse;
        }




    }
}

