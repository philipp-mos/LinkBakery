using MediatR;

namespace LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail
{
    public class GetTrackingLinkDetailQuery : IRequest<List<TrackingLinkDetailVm>>
    {
        public int Id { get; set; }
    }
}
