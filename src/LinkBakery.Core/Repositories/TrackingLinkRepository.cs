using LinkBakery.Core.Models;
using LinkBakery.Core.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace LinkBakery.Core.Repositories
{
    public class TrackingLinkRepository : BaseRepository<TrackingLink>, ITrackingLinkRepository
    {
        public TrackingLinkRepository(IConfiguration configuration)
            : base(configuration) { }
    }
}
