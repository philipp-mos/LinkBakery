namespace LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail
{
    public class TrackingLinkDetailVm
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string TargetUrl { get; set; }
        public bool RedirectWithQueryParameter { get; set; }
        public bool IsActive { get; set; }
    }
}
