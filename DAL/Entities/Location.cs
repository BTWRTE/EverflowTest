using DAL.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    [EntityTypeConfiguration(typeof(LocationConfiguration))]
    public class Location : BaseEntity
    {
        public required string StreetLine1 { get; set; }
        public string? StreetLine2 { get; set; }
        public string? StreetLine3 { get; set; }
        public required string City { get; set; }
        public required string County { get; set; }
        public required string PostCode { get; set; }

        public ICollection<Event> Events { get; set; } = [];
        public ICollection<ApplicationUser> Users { get; set; } = [];
    }
}