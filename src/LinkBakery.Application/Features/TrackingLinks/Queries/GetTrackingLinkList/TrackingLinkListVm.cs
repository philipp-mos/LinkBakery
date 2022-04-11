namespace LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList
{
    public class TrackingLinkListVm
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
