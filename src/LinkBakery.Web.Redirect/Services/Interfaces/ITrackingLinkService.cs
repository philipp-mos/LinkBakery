namespace LinkBakery.Web.Redirect.Services.Interfaces
{
    public interface ITrackingLinkService // : Core.Services.Interfaces.ITrackingLinkService
    {
        string? GetLinkAndTrackCall(string key, string? queryString = null);
    }
}
