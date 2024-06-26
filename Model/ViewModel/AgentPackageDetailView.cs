namespace PropertyBackend.Model.ViewModel
{
    public class AgentPackageDetailView
    {

      public string  PackageCategoryName { get; set; }
      public string  PackageSubCategoryName { get; set; }
        public int  TotalCredits { get; set; }
        public int  ConsumeCredits { get; set; }
        public int  Remaining { get; set; }

       public int Listing { get; set; }
        public int HotListing { get; set; }
        public int SuperHotListing { get; set; }
    }
}
