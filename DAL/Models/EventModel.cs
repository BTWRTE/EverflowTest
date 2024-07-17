namespace DAL.Models
{
    public class EventModel : BaseEntityModel
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid LocationId { get; set; }

        public LocationModel? Location { get; set; }
        public ICollection<EventUserModel> EventUsers { get; set; } = [];
    }
}