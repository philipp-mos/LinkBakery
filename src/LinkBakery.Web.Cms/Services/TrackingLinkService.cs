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
            ITrackingLinkCallRepository trackingLinkCallRepository,
            IMapper mapper)
            : base(trackingLinkRepository, trackingLinkCallRepository)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<TrackingLinkOverviewDto>> GetAllAsync()
            => _mapper.Map<IEnumerable<TrackingLinkOverviewDto>>(await _trackingLinkRepository.GetAllAsync());


        public async Task<TrackingLinkEditDto> FindByIdAsync(int id)
            => _mapper.Map<TrackingLinkEditDto>(await _trackingLinkRepository.GetByIdAsync(id));

        public IEnumerable<TrackingLinkCallChartDto> GetCallChartData(int trackingLinkId)
        {
            return _mapper.Map<IEnumerable<TrackingLinkCallChartDto>>(_trackingLinkCallRepository.GetAllForTrackingLink(trackingLinkId));
        }


        public async void UpdateEntry(TrackingLinkEditDto trackingLinkDto)
        {
            var trackingLink = await _trackingLinkRepository.GetByIdAsync(trackingLinkDto.Id);

            if (trackingLink == null)
            {
                return;
            }

            trackingLink.TargetUrl = trackingLinkDto.TargetUrl;
            trackingLink.IsActive = trackingLinkDto.IsActive;
            trackingLink.RedirectWithQueryParameter = trackingLinkDto.RedirectWithQueryParameter;

            _trackingLinkRepository.Update(trackingLink);
            _trackingLinkRepository.SaveAsync();
        }

    }
}
