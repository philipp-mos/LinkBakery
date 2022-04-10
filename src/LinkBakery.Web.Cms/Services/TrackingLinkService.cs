using AutoMapper;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList;
using LinkBakery.Web.Cms.Services.Interfaces;
using MediatR;

namespace LinkBakery.Web.Cms.Services
{
    public class TrackingLinkService : ITrackingLinkService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;


        public TrackingLinkService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }


        public async Task<List<TrackingLinkListVm>> GetAllAsync()
        {
            return await _mediator.Send(new GetTrackingLinkListQuery());
        }


        public async Task<TrackingLinkDetailVm> FindByIdAsync(int id)
        {
            return await _mediator.Send(new GetTrackingLinkDetailQuery() { Id = id });
        }
    }
}
