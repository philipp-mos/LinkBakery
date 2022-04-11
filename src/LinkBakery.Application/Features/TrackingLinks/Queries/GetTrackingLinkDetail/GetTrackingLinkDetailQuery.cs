using MediatR;

namespace LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail
{
    public class GetTrackingLinkDetailQuery : IRequest<TrackingLinkDetailVm>
    {
        public int Id { get; set; }
    }
}
