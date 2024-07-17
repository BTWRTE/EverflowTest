using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder
                .Property(e => e.StreetLine1)
                .HasMaxLength(50);

            builder
                .Property(e => e.StreetLine2)
                .HasMaxLength(50);

            builder
                .Property(e => e.StreetLine3)
                .HasMaxLength(50);

            builder
                .Property(e => e.City)
                .HasMaxLength(100);

            builder
                .Property(e => e.County)
                .HasMaxLength(100);

            builder
                .Property(e => e.PostCode)
                .HasMaxLength(10);

            builder
                .HasMany(e => e.Events)
                .WithOne(e => e.Location)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasMany(e => e.Users)
                .WithOne(e => e.Address)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}