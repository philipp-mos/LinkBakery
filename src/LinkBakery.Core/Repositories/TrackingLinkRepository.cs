using LinkBakery.Core.Models;
using LinkBakery.Core.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace LinkBakery.Core.Repositories
{
    public class TrackingLinkRepository : BaseRepository<TrackingLink>, ITrackingLinkRepository
    {
        public TrackingLinkRepository(IConfiguration configuration)
            : base(configuration) { }


        public TrackingLink? FindByKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }

            return _table.FirstOrDefault(x => x.Key == key && x.IsActive == true);
        }
    }
}
