using LinkBakery.Core.Models;
using LinkBakery.Core.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace LinkBakery.Core.Repositories
{
    public class TrackingLinkCallRepository : BaseRepository<TrackingLinkCall>, ITrackingLinkCallRepository
    {
        public TrackingLinkCallRepository(IConfiguration configuration)
            : base(configuration) { }


        public IEnumerable<TrackingLinkCall> GetAllForTrackingLink(int trackingLinkId)
        {
            return _table.Where(x => x.TrackingLinkId == trackingLinkId).ToList();
        }
    }
}
