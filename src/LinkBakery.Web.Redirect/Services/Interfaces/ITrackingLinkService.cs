using LinkBakery.Web.Redirect.Dtos;

namespace LinkBakery.Web.Redirect.Services.Interfaces
{
    public interface ITrackingLinkService
    {
        IEnumerable<TrackingLinkDto> GetAll();
        string? GetLinkAndTrackCall(string key, string? queryString = null);
    }
}
