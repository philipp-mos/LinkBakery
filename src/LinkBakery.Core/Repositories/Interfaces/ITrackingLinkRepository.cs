using LinkBakery.Core.Models;

namespace LinkBakery.Core.Repositories.Interfaces
{
    public interface ITrackingLinkRepository : IBaseRepository<TrackingLink>
    {
        TrackingLink? FindByKey(string key);
    }
}
