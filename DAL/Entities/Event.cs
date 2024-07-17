using System.ComponentModel.DataAnnotations.Schema;
using DAL.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    [EntityTypeConfiguration(typeof(EventConfiguration))]
    public class Event : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]
        public Location? Location { get; set; }

        public ICollection<EventUser> EventUsers { get; set; } = [];
    }
}