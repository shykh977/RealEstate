namespace PropertyBackend.Model.ViewModel
{
    public class KarsazView
    {
        public Guid UserId { get; set; }
        public Guid KarsazId { get; set; }
        public Guid KarsazCategoryId { get; set; }
        public int LocationId { get; set; }
        public string? IndustryName { get; set; }
        public string? BuildSince { get; set; }
        public string? KarsazType { get; set; }
        public string? IndustryLogo { get; set; }
        public string? CityName { get; set; }
        public string? LocationName { get; set; }
        public string? KarsazCategory { get; set; }

    }
}
