using LinkBakery.Domain.Common;

namespace LinkBakery.Domain.Entities
{
    public class TrackingLinkCall : BaseEntity
    {
        public DateTime DateTime { get; set; }

        public int TrackingLinkId { get; set; }
        public string? QueryParameter { get; set; }
        public TrackingLink TrackingLink { get; set; }
    }
}
