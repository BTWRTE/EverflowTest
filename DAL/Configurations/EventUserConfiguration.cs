using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class EventUserConfiguration : IEntityTypeConfiguration<EventUser>
    {
        public void Configure(EntityTypeBuilder<EventUser> builder)
        {
            builder
                .HasKey(e => new
                {
                    e.EventId,
                    e.UserId
                });

            builder
                .HasOne(e => e.Event)
                .WithMany(e => e.EventUsers)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.EventUsers)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}