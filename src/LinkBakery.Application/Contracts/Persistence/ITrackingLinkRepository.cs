using LinkBakery.Domain.Entities;

namespace LinkBakery.Application.Contracts.Persistence
{
    public interface ITrackingLinkRepository : IBaseRepository<TrackingLink>
    {
        TrackingLink? FindActiveByKey(string key);
    }
}
