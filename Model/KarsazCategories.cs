namespace PropertyBackend.Model
{
    public class KarsazCategories
    {
       public Guid KarsazCategoryId     {get;set;}
       public string? KarsazCategory       {get;set;}
       public string? CategoryType { get;set;}
       public Guid UserId { get; set; }

    }
}
