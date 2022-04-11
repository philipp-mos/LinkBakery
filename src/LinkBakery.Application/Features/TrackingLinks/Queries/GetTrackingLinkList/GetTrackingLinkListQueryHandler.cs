using AutoMapper;
using LinkBakery.Application.Contracts.Persistence;
using MediatR;

namespace LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList
{
    public class GetTrackingLinkListQueryHandler : IRequestHandler<GetTrackingLinkListQuery, List<TrackingLinkListVm>>
    {
        private readonly ITrackingLinkRepository _trackingLinkRepository;
        private readonly IMapper _mapper;


        public GetTrackingLinkListQueryHandler(
                ITrackingLinkRepository trackingLinkRepository,
                IMapper mapper
        )
        {
            _trackingLinkRepository = trackingLinkRepository;
            _mapper = mapper;
        }



        public async Task<List<TrackingLinkListVm>> Handle(GetTrackingLinkListQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<TrackingLinkListVm>>(await _trackingLinkRepository.GetAllAsync());
        }
    }
}
