using LinkBakery.Application.Contracts.Persistence;
using LinkBakery.Domain.Entities;

namespace LinkBakery.Persistence.Repositories
{
    public class TrackingLinkRepository : BaseRepository<TrackingLink>, ITrackingLinkRepository
    {
        public TrackingLinkRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }


        public TrackingLink? FindActiveByKey(string key)
        {
            return _dbContext.TrackingLinks.FirstOrDefault(x => x.Key == key && x.IsActive == true);
        }
    }
}
