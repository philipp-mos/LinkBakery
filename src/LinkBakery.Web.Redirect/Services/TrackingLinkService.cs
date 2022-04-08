using AutoMapper;
using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Web.Redirect.Dtos;
using LinkBakery.Web.Redirect.Services.Interfaces;

namespace LinkBakery.Web.Redirect.Services
{
    public class TrackingLinkService : ITrackingLinkService
    {
        private readonly ITrackingLinkRepository _trackingLinkRepository;
        private readonly IMapper _mapper;


        public TrackingLinkService(
            ITrackingLinkRepository trackingLinkRepository,
            IMapper mapper)
        {
            _trackingLinkRepository = trackingLinkRepository;
            _mapper = mapper;
        }


        public IEnumerable<TrackingLinkDto> GetAll()
            => _mapper.Map<IEnumerable<TrackingLinkDto>>(_trackingLinkRepository.GetAll());
    }
}
