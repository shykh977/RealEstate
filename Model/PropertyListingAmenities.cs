namespace PropertyBackend.Model
{
    public class PropertyListingAmenities :BaseModel
    {
        
        public string? PropertyListingAmenitiesName { get; set; }
        public Guid PropertyListingId { get; set; }
        public Guid PropertyListingAmenitiesId { get; set; }

    }
}
