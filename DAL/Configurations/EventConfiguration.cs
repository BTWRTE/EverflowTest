using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder
                .Property(e => e.Name)
                .HasMaxLength(100);

            builder
                .HasMany(e => e.EventUsers)
                .WithOne(e => e.Event)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}