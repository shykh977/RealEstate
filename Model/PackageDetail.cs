namespace PropertyBackend.Model
{
    public class PackageDetail
    {
            public Guid PackageDetailId                   {get;set;}
            public Guid UserId                            {get;set;}
            public Guid BusinessId                        {get;set;}
            public Guid PackageSubCategoryId              {get;set;}
            public Guid AgentId                           {get;set;}
            public string? PackageDetailName                 {get;set;}
            public float PackageAmount { get;set;}
            public int Listing                           {get;set;}
            public int HotListing                        {get;set;}
            public int SuperHotListing                   {get;set;}
            public int RefreshCredit                     {get;set;}
            public string? Outburst                          {get;set;}
            public string? Website                           {get;set;}
            public string? HomePageLogo                      {get;set;}
            public string? VideoInterview                    {get;set;}
            public string? ExclusiveAgencyProfile            {get;set;}
            public string? TitaniumRibbon                    {get;set;}
            public string? FeaturedAgency                    {get;set;}
            public string? TitaniumFeaturedAgency            {get;set;}
            public string? AreaWallpaperTakeover             {get;set;}
            public string? DoubleRightSideBannerLocationWise {get;set;}
            public string? RightSideBannnerLocationWise      {get;set;}
            public string? LeaderboardImpressions            {get;set;}
            public string? SplashAdsImpressions              {get;set;}
            public string? HotStripImpressions               {get;set;}
            public string? MOUCommission                     {get;set;}
            public string? DiscountExpo                      {get;set;}
            public string? DeveloperPagesAndListing          {get;set;}
            public string? ZameenOutburst                    {get;set;}
            public string? FeaturedDeveloper                 {get;set;}
            public string? ProjectPusher                     {get;set;}
            public string? ExclusiveDeveloperProfile         {get;set;}
            public string? TrustedRibbon                     {get;set;}
            public string? PremiumListing                    {get;set;}
            public string? GoogleCampaign                    {get;set;}
            public string? FacebookCampaign { get; set; }

    }
}
