using AutoMapper;
using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Web.Cms.Dtos;
using LinkBakery.Web.Cms.Services.Interfaces;

namespace LinkBakery.Web.Cms.Services
{
    public class TrackingLinkService : Core.Services.TrackingLinkService, ITrackingLinkService
    {
        private readonly IMapper _mapper;


        public TrackingLinkService(
            ITrackingLinkRepository trackingLinkRepository,
            IMapper mapper)
            : base(trackingLinkRepository)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<TrackingLinkOverviewDto>> GetAllAsync()
            => _mapper.Map<IEnumerable<TrackingLinkOverviewDto>>(await _trackingLinkRepository.GetAllAsync());


        public async Task<TrackingLinkEditDto> FindByIdAsync(int id)
            => _mapper.Map<TrackingLinkEditDto>(await _trackingLinkRepository.GetByIdAsync(id));

    }
}
