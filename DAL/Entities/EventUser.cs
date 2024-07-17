using System.ComponentModel.DataAnnotations.Schema;
using DAL.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    [EntityTypeConfiguration(typeof(EventUserConfiguration))]
    public class EventUser : BaseLinkEntity
    {
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey(nameof(EventId))]
        public Event? Event { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
    }
}