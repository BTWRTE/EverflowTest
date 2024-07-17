namespace DAL.Models
{
    public class LocationModel : BaseEntityModel
    {
        public required string StreetLine1 { get; set; }
        public string? StreetLine2 { get; set; }
        public string? StreetLine3 { get; set; }
        public required string City { get; set; }
        public required string County { get; set; }
        public required string PostCode { get; set; }

        public ICollection<EventModel> Events { get; set; } = [];
        public ICollection<ApplicationUserModel> Users { get; set; } = [];
    }
}