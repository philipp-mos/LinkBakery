using AutoMapper;
using LinkBakery.Application.Contracts.Persistence;
using MediatR;

namespace LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail
{
    public class GetTrackingLinkDetailQueryHandler : IRequestHandler<GetTrackingLinkDetailQuery, TrackingLinkDetailVm>
    {
        private readonly ITrackingLinkRepository _trackingLinkRepository;
        private readonly IMapper _mapper;


        public GetTrackingLinkDetailQueryHandler(
                ITrackingLinkRepository trackingLinkRepository,
                IMapper mapper
        )
        {
            _trackingLinkRepository = trackingLinkRepository;
            _mapper = mapper;
        }



        public async Task<TrackingLinkDetailVm> Handle(GetTrackingLinkDetailQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<TrackingLinkDetailVm>(await _trackingLinkRepository.GetByIdAsync(request.Id));
        }
    }
}
