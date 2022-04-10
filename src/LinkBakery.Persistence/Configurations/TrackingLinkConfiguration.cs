using LinkBakery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkBakery.Persistence.Configurations
{
    public class TrackingLinkConfiguration : IEntityTypeConfiguration<TrackingLink>
    {
        public void Configure(EntityTypeBuilder<TrackingLink> builder)
        {
            builder.Property(x => x.Key)
                    .IsRequired();

            builder.Property(x => x.TargetUrl)
                    .IsRequired();
        }
    }
}
