using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Core.Services.Interfaces;

namespace LinkBakery.Core.Services
{
    public class TrackingLinkService : ITrackingLinkService
    {
        protected readonly ITrackingLinkRepository _trackingLinkRepository;
        protected readonly ITrackingLinkCallRepository _trackingLinkCallRepository;

        public TrackingLinkService(
            ITrackingLinkRepository trackingLinkRepository,
            ITrackingLinkCallRepository trackingLinkCallRepository)
        {
            _trackingLinkRepository = trackingLinkRepository;
            _trackingLinkCallRepository = trackingLinkCallRepository;
        }



    }
}
