namespace DAL.Models
{
    public class EventUserModel : BaseLinkEntityModel
    {
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }

        public EventModel? Event { get; set; }
        public ApplicationUserModel? User { get; set; }
    }
}