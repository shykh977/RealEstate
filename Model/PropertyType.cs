namespace PropertyBackend.Model
{
    public class PropertyType :BaseModel
    {

      public Guid  PropertyTypeId { get; set; }
      public Guid  PropertyCategoryId { get; set; }
        public string?  PropertyTypeName { get; set; }


    }
}
