using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.FirstName)
                .HasMaxLength(50);

            builder
                .Property(e => e.LastName)
                .HasMaxLength(50);

            builder
                .HasMany(e => e.EventUsers)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}