using AutoMapper;
using LinkBakery.Core.Models;
using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Web.Redirect.Dtos;
using LinkBakery.Web.Redirect.Services.Interfaces;

namespace LinkBakery.Web.Redirect.Services
{
    public class TrackingLinkService : ITrackingLinkService
    {
        private readonly ITrackingLinkRepository _trackingLinkRepository;
        private readonly ITrackingLinkCallRepository _trackingLinkCallRepository;
        private readonly IMapper _mapper;


        public TrackingLinkService(
            ITrackingLinkRepository trackingLinkRepository,
            ITrackingLinkCallRepository trackingLinkCallRepository,
            IMapper mapper)
        {
            _trackingLinkRepository = trackingLinkRepository;
            _trackingLinkCallRepository = trackingLinkCallRepository;
            _mapper = mapper;
        }


        public IEnumerable<TrackingLinkDto> GetAll()
            => _mapper.Map<IEnumerable<TrackingLinkDto>>(_trackingLinkRepository.GetAllAsync());


        public string? GetLink(string key)
        {
            var trackingLink = _trackingLinkRepository.FindActiveByKey(key);

            if (trackingLink == null)
            {
                return null;
            }

            SaveLinkTrackingCall(trackingLink);

            return trackingLink.TargetUrl;
        }




        private void SaveLinkTrackingCall(TrackingLink trackingLink)
        {
            _trackingLinkCallRepository.InsertAndSafeAsync(new TrackingLinkCall
                {
                    DateTime = DateTime.Now,
                    TrackingLinkId = trackingLink.Id
                }
            );
        }
    }
}
