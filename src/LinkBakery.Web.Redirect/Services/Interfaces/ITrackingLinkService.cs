namespace LinkBakery.Web.Redirect.Services.Interfaces
{
    public interface ITrackingLinkService
    {
        string? GetLinkAndTrackCall(string key, string? queryString = null);
    }
}
