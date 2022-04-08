namespace LinkBakery.Core.Models
{
    public class TrackingLink : BaseEntity
    {
        public string Key { get; set; }
        public string TargetUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
