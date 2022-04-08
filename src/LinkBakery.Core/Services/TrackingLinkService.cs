using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Core.Services.Interfaces;

namespace LinkBakery.Core.Services
{
    public class TrackingLinkService : ITrackingLinkService
    {
        protected readonly ITrackingLinkRepository _trackingLinkRepository;

        public TrackingLinkService(
            ITrackingLinkRepository trackingLinkRepository)
        {
            _trackingLinkRepository = trackingLinkRepository;
        }



    }
}
