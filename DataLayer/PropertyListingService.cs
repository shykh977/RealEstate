using PropertyBackend.DbConnect;
using PropertyBackend.Model;
using PropertyBackend.Model.ViewModel;
using PropertyBackend.Common;
using System.Reflection;
using System.Security;
using Newtonsoft.Json;
using System.Dynamic;
using Newtonsoft.Json.Converters;

namespace PropertyBackend.DataLayer
{
    public class PropertyListingService
    {

        private IGenericRepository<PropertyListing> _IgenericRepository;
        APIResponse APIResponse = new APIResponse();
        public PropertyListingService(IGenericRepository<PropertyListing> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }




        public APIResponse CreatePropertyListing(PropertyListing? propertyListing)
        {
            object obj2 = new
            {
                AgentId = propertyListing.AgentId
            };
            var AgentCustomPackage = _IgenericRepository.Search<AgentPackageDetailView>(obj2, "usp_GetAgentCustomPackage").FirstOrDefault();
            
            var agentpackge = _IgenericRepository.Search<AgentPackageDetailView>(obj2, "usp_GetAgentPackage").FirstOrDefault();

            var agentPropertyStatusViews = _IgenericRepository.Search<AgentPropertyStatusView>(obj2, "usp_GetPropertyCountForAgents").FirstOrDefault();



            if(AgentCustomPackage != null)
            {
                if(AgentCustomPackage.Listing != 0)
                {
                    _IgenericRepository.ExecuteQuery<PropertyListingView>(propertyListing, "usp_Create_Update_PropertyListing").ToList();
                    APIResponse.StatusMessage = "Property Successfully Uploaded";
                }
            }
            else
            {
                if (agentpackge == null)
                {
                    APIResponse.StatusMessage = "Kindly Contact I.T Administrator And Subscribe Your Plan";
                }
                else
                {
                    if (agentPropertyStatusViews.TotalProperty == agentpackge.Listing)
                    {
                        APIResponse.StatusMessage = "You have Reached Maximum Number Listing";
                    }
                    else
                    {
                        _IgenericRepository.ExecuteQuery<PropertyListingView>(propertyListing, "usp_Create_Update_PropertyListing").ToList();
                        APIResponse.StatusMessage = "Property Successfully Uploaded";
                    }
                }
            }           
            return APIResponse;
        }



        public APIResponse CreatePropertyImages(PropertyImages propertyImages )
        {


            if (propertyImages.PropertyImagesId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                propertyImages.PropertyImagesId = Guid.NewGuid();
            }

            _IgenericRepository.ExecuteQuery<PropertyImages>(propertyImages, "usp_Create_Update_PropertyImages").ToList();

            return APIResponse;
        } 
        
        
        public APIResponse DeletePropertyImages(PropertyImages propertyImages )
        {


            object obj = new
            {
                PropertyImagesId = propertyImages.PropertyImagesId
            };


            _IgenericRepository.ExecuteQuery<PropertyImages>(obj, "usp_DeletePropertyImages").ToList();

            return APIResponse;
        }



        public APIResponse CreatePropertyListingAmenities(PropertyListingAmenities propertyListingAmenities )
        {
            

            if(propertyListingAmenities.PropertyListingAmenitiesId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                propertyListingAmenities.PropertyListingAmenitiesId = Guid.NewGuid();
            }

           _IgenericRepository.ExecuteQuery<PropertyListingAmenities>(propertyListingAmenities, "usp_Create_Update_PropertyListingAmenities").ToList();
            
            return APIResponse;
        }



        public APIResponse GetPropertyFilter(PropertyFilter propertyFilter)
        {
            //Bathroom
            //Bedroom
            //PriceTo
            //PriceFrom
            //MinArea
            //MaxArea
            //PropertyTypeName

            if (propertyFilter.LocationId == "null")
            {
                propertyFilter.LocationId = null;
            }

            if(propertyFilter.Bedroom == "null")
            {
                propertyFilter.Bedroom = null;
            }
            if(propertyFilter.Bathroom == "null")
            {
                propertyFilter.Bathroom = null;
            }
            if(propertyFilter.PriceTo == "null")
            {
                propertyFilter.PriceTo = null;
            }
            if(propertyFilter.PriceFrom == "null")
            {
                propertyFilter.PriceFrom = null;
            }
            if(propertyFilter.MinArea == "null")
            {
                propertyFilter.MinArea = null;
            }
            if(propertyFilter.MaxArea == "null")
            {
                propertyFilter.MaxArea = null;
            }
            
            if(propertyFilter.PropertyTypeName == "null")
            {
                propertyFilter.PropertyTypeName = null;
            }


            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(propertyFilter, "usp_GetPropertyFilter").ToList();



            foreach (var pro in PT)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }

            APIResponse.Response = PT;
            return APIResponse;
        }



        public APIResponse GetProperties(PropertyListingView propertyListingView  )
        {
            object obj = new
            {
                LocationId = propertyListingView.LocationId,
                CityId = propertyListingView.CityId,
                OFFSET = propertyListingView.OFFSET

            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetProperty").ToList();
           
            foreach(var pro in PT)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }
            
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        
        public APIResponse GetPropertiesAll(PropertyListingView propertyListingView  )
        {
            object obj = new
            {
                BusinessId = propertyListingView.BusinessId,

                OFFSET = propertyListingView.OFFSET

            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertiesAll").ToList();
           
            foreach(var pro in PT)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }
            
            APIResponse.Response = PT;
            return APIResponse;
        }
       
        public APIResponse GetPropertyCount(PropertyListing propertyListing )
        {
            object obj = new
            {
                LocationId = propertyListing.LocationId,
                CityId = propertyListing.CityId
                
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyCount").ToList();

            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetPropertyByLocation(PropertyListing propertyListing )
        {
            object obj = new
            {
                LocationId = Convert.ToInt32(propertyListing.LocationId),
               
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyByLocation").ToList();

            foreach (var pro in PT)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }

            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetPropertyByType(PropertyListing propertyListing )
        {
            object obj = new
            {
                LocationId = propertyListing.LocationId,
                CityId = propertyListing.CityId,
                PropertyTypeId = propertyListing.PropertyTypeId
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyByType").ToList();

            foreach (var pro in PT)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }
            APIResponse.Response = PT;
            return APIResponse;
        } 
        
        
        public APIResponse GetPropertyByTypeName(PropertyListingView propertyListingView )
        {
            object obj = new
            {
                LocationId = propertyListingView.LocationId,
                //CityId = propertyListing.CityId,
                PropertyTypeName = propertyListingView.PropertyTypeName
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyByTypeName").ToList();

            foreach (var pro in PT)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetPropertyByAgent(PropertyListing propertyListing )
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,         
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyByAgent").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetPropertyListingForAgentPortal(PropertyListing propertyListing )
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,         
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_getPropertyListingForAgentPortal").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetPropertyListingForHotlisting(PropertyListing propertyListing )
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,         
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_getPropertyListingForHotlisting").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
                
        public APIResponse GetPropertyDetail(PropertyListing propertyListing )
        {
            object obj = new
            {
                PropertyListingId = propertyListing.PropertyListingId,              
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyDetail").ToList();

            foreach (var pro in PT)
            {
                object analytics = new 
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    VisitId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Visits").ToList();
            }


            APIResponse.Response = PT;
            return APIResponse;
        }


        public APIResponse GetPropertyDetailForMobile(PropertyListing propertyListing)
        {
            PropertyListingView PL = new PropertyListingView();
            object obj = new
            {
                PropertyListingId = propertyListing.PropertyListingId,
            };

            PL = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyDetail").FirstOrDefault();

            PL.imagesViews = _IgenericRepository.Search<PropertyImagesView>(obj, "usp_GetPropertyImages").ToList();


            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyDetail").ToList();
 
            foreach (var pro in PT)
            {
                object analytics = new
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    VisitId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Visits").ToList();
            }


            APIResponse.Response = PL;
            return APIResponse;
        }





        public APIResponse GetPropertyByStatus(PropertyListing propertyListing )
        {
            object obj = new
            {
                LocationId = propertyListing.LocationId,
                CityId = propertyListing.CityId,
                Status = propertyListing.Status,              
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyByStatus").ToList();

            foreach (var pro in PT)
            {
                Analytics analytics = new Analytics
                {
                    AgentId = pro.AgentId,
                    PropertyListingId = pro.PropertyListingId,
                    ImpressionsId = Guid.NewGuid()
                };

                _IgenericRepository.ExecuteQuery<Analytics>(analytics, "usp_Create_Update_Impressions").ToList();
            }


            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetRecentProperties(PropertyListing propertyListing )
        {
            object obj = new
            {
                BusinessId = propertyListing.BusinessId,
                       
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetRecentProperties").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
         
        public APIResponse GetFeaturedProperties(PropertyListingView propertyListing)
        {
            object obj = new
            {
                BusinessId = propertyListing.BusinessId,
                PropertyType = propertyListing.PropertyType,

            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetFeaturedProperties").ToList();
            
           
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetPropertyAmenities(PropertyListing propertyListing )
        {
            object obj = new
            {
                PropertyListingId = propertyListing.PropertyListingId,              
            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetPropertyAmenities").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetPropertyImages(PropertyListing propertyListing )
        {
            object obj = new
            {
                PropertyListingId = propertyListing.PropertyListingId,              
            };
            List<PropertyImagesView> PT = _IgenericRepository.Search<PropertyImagesView>(obj, "usp_GetPropertyImages").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse ExpireProperty(PropertyListing propertyListing )
        {
            object obj = new
            {
                PropertyListingId = propertyListing.PropertyListingId,              
            };
            _IgenericRepository.ExecuteQuery<PropertyImagesView>(obj, "usp_ExpireProperty").FirstOrDefault();
           
            return APIResponse;
        }
        
        public APIResponse RefreshProperty(PropertyListing propertyListing )
        {
            object obj = new
            {
                PropertyListingId = propertyListing.PropertyListingId,              
            };
            _IgenericRepository.ExecuteQuery<PropertyImagesView>(obj, "usp_RefreshProperty").FirstOrDefault();

            return APIResponse;
        }

        public APIResponse PropertiesListingConfiguration(PropertyListingView propertyListingView )
        {
            object obj = new
            {
                PropertyListingId = propertyListingView.PropertyListingId,
                ListingType = propertyListingView.ListingType,              
            };


            object obj2 = new
            {
                AgentId = propertyListingView.AgentId
            };
            var agentpackge = _IgenericRepository.Search<AgentPackageDetailView>(obj2, "usp_GetAgentPackage").FirstOrDefault();
            
            var agentPropertyStatusViews = _IgenericRepository.Search<AgentPropertyStatusView>(obj2, "usp_GetPropertyCountForAgents").FirstOrDefault();

           


            if (propertyListingView.ListingType == "SHT")
            {
                int SuperHotListing = agentpackge.SuperHotListing;
                if (SuperHotListing > 0)
                {

                    if (agentPropertyStatusViews.TotalSuperHotListProperty == SuperHotListing)
                    {
                        APIResponse.StatusMessage = "You have Reached Maximum Number Of Super Hot List";
                    }
                    else
                    {
                        _IgenericRepository.ExecuteQuery<PropertyListingView>(obj, "usp_PropertiesListingConfiguration").ToList();
                        APIResponse.StatusMessage = "Property Mark As Super Hot Listed";
                    }
                }
                else
                {
                    APIResponse.StatusMessage = "Super Hot Listing Is Not In Your Current Package";
                }
            }
           
            
            else if(propertyListingView.ListingType == "HT")
            {
                int HotListing = agentpackge.HotListing;

               
                if(agentPropertyStatusViews.TotalHotListProperty  == HotListing)
                {
                    APIResponse.StatusMessage = "You have Reached Maximum Number Of Hot List";
                }
                else {
                    _IgenericRepository.ExecuteQuery<PropertyListingView>(obj, "usp_PropertiesListingConfiguration").ToList();
                    APIResponse.StatusMessage = "Property Mark As  Hot Listed";
                }              
            }





            return APIResponse;
        }

        public APIResponse GetPropertyCountDetail(PropertyListing propertyListing)
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,

            };
            List<PropertyType> PT = _IgenericRepository.Search<PropertyType>(obj, "usp_GetPropertyCountDetail").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }


        public APIResponse GetHotlistingProperties(PropertyListing propertyListing)
        {
            object obj = new
            {
                CityId = propertyListing.CityId,
                IsHotList = propertyListing.IsHotListing,

            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetHotlistingProperties").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetSuperHotlistingProperties(PropertyListing propertyListing)
        {
            object obj = new
            {
                CityId = propertyListing.CityId,
                IsHotList = propertyListing.IsHotListing,

            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetHotlistingProperties").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetAgentPropertyByStatus(PropertyListing propertyListing)
        {
            object obj = new
            {
                AgentId = propertyListing.AgentId,
                Status = propertyListing.Status,

            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "usp_GetAgentPropertyByStatus").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }


        /// <summary>
        /// ////Area Guides Functionality
        /// </summary>
        /// <param name="propertyListing"></param>
        /// <returns></returns>



        public APIResponse CreateLocationDetail(LocationDetail locationDetail)
        {
           
            if(locationDetail.LocationDetailId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                locationDetail.LocationDetailId = Guid.NewGuid();
            }

            var  PT = _IgenericRepository.Search<LocationDetail>(locationDetail, "usp_Create_Update_LocationDetail").ToList();

            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse CreateLocationDescription(Areas areas)
        {
            object obj = new
            {
                LocationID = areas.LocationID,
                Description = areas.Description
            };
            var  PT = _IgenericRepository.Search<LocationDetail>(obj, "usp_CreateLocationDescription").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }






        public APIResponse GetLocationForAreaGuid(PropertyListing propertyListing)
        {
            object obj = new
            {
                CityId = propertyListing.CityId,

            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "ups_GetLocationForAreaGuid").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        public APIResponse GetLocationForAreaGuidMobile(PropertyListing propertyListing)
        {
            object obj = new
            {
                CityId = propertyListing.CityId,

            };
            List<PropertyListingView> PT = _IgenericRepository.Search<PropertyListingView>(obj, "ups_GetLocationForAreaGuid").ToList();
           
            
            
            APIResponse.Response = PT;
            return APIResponse;
        }
        
        
        public APIResponse GetAreaGuideDetail(PropertyListing propertyListing)
        {
            object obj = new
            {
                LocationId = propertyListing.LocationId,

            };
            List<AreaGuideDetail> PT = _IgenericRepository.Search<AreaGuideDetail>(obj, "usp_GetAreaGuideDetail").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }
        public APIResponse GetAreaGuideByPropertyType(PropertyListing propertyListing)
        {
            object obj = new
            {
                PropertyTypeId = propertyListing.PropertyTypeId,
                LocationId = propertyListing.LocationId
            };
            List<AreaGuideDetail> PT = _IgenericRepository.Search<AreaGuideDetail>(obj, "usp_GetAreaGuideByPropertyType").ToList();
           
            
            
            
            APIResponse.Response = PT;
            return APIResponse;
        }


        public APIResponse GetAreaGuideDetailAndPropertyType(PropertyListing propertyListing)
        {

            AreaGuideDetail areaGuideDetail = new AreaGuideDetail();


            object obj = new
            {
                LocationId = propertyListing.LocationId,

            };


            areaGuideDetail.areaGuideDetails = _IgenericRepository.ExecuteQuery<AreaGuideDetail>(obj, "usp_GetAreaGuideDetail").ToList();

            foreach (var item in areaGuideDetail.areaGuideDetails)
            {
                item.PropertyTypes = _IgenericRepository.ExecuteQuery<AreaGuideDetailByPropertyTypeView>(new { PropertyTypeId = item.PropertyTypeId , LocationId = propertyListing.LocationId }, "usp_GetAreaGuideByPropertyType").ToList();                          
            }

            APIResponse.Response = areaGuideDetail.areaGuideDetails;


            return APIResponse;


        }



        public APIResponse GetMostViewedCities(PropertyListing propertyListing)
        {
            object obj = new
            {
                BusinessId = propertyListing.BusinessId
            };
            List<Cities> PT = _IgenericRepository.Search<Cities>(obj, "usp_GetMostViewedCities").ToList();
            APIResponse.Response = PT;
            return APIResponse;
        }

    }
}
