namespace LinkBakery.Core.Models
{
    public class TrackingLinkCall : BaseEntity
    {
        public DateTime DateTime { get; set; }
        public TrackingLink TrackingLink { get; set; }
    }
}
