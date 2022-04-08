namespace LinkBakery.Web.Cms.Dtos
{
    public class TrackingLinkOverviewDto
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string TargetUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
