using System.ComponentModel.DataAnnotations.Schema;
using DAL.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    [EntityTypeConfiguration(typeof(ApplicationUserConfiguration))]
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Guid? AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Location? Address { get; set; }

        public ICollection<EventUser> EventUsers { get; set; } = [];
    }
}