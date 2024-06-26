namespace PropertyBackend.Model
{
    public class PackageSubCategory : BaseModel
    {
       
      public Guid  PackageSubCategoryId         {get;set;}
      public Guid  PackageCategoryId            {get;set;}
      public string? PackageSubCategoryName { get; set; }
      public float PackageAmount  { get; set; }
    }
}
