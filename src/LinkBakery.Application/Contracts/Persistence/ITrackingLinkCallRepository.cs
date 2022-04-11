using LinkBakery.Domain.Entities;

namespace LinkBakery.Application.Contracts.Persistence
{
    public interface ITrackingLinkCallRepository : IBaseRepository<TrackingLinkCall>
    {
        IEnumerable<TrackingLinkCall> GetAllForTrackingLink(int trackingLinkId);
    }
}
