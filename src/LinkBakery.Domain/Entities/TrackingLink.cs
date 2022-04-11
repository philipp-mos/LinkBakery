using LinkBakery.Domain.Common;

namespace LinkBakery.Domain.Entities
{ 
    public class TrackingLink : BaseEntity
    {
        public string Key { get; set; }
        public string TargetUrl { get; set; }
        public bool RedirectWithQueryParameter { get; set; }
        public bool IsActive { get; set; }

        public ICollection<TrackingLinkCall> TrackingLinkCalls { get; set; }
    }
}
