using LinkBakery.Core.Models;

namespace LinkBakery.Core.Repositories.Interfaces
{
    public interface ITrackingLinkCallRepository : IBaseRepository<TrackingLinkCall>
    {
        IEnumerable<TrackingLinkCall> GetAllForTrackingLink(int trackingLinkId);
    }
}
