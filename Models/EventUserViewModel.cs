namespace EverflowTest.Models
{
    public class EventUserViewModel
    {
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }
        public string? EventName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}