using LinkBakery.Core.Models;

namespace LinkBakery.Web.Redirect.Services.Interfaces
{
    public interface ITrackingLinkService
    {
        IEnumerable<TrackingLink> GetAll();
    }
}
