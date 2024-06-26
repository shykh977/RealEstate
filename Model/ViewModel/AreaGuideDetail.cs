namespace PropertyBackend.Model.ViewModel
{
    public class AreaGuideDetail
    {

        public string    PropertyTypeName           {get;set;}
        public Guid PropertyTypeId { get;set;}
        public string    PropertyCategoryName       {get;set;}
        public string    MinimumPrice               {get;set;}
        public string MaximumPrice { get;set;}
        public string TotalProperties { get; set; }
        public string SQFT { get; set; }


       public List<AreaGuideDetail>? areaGuideDetails { get; set; }
       public List<AreaGuideDetailByPropertyTypeView>? PropertyTypes { get; set; }


    }
}
