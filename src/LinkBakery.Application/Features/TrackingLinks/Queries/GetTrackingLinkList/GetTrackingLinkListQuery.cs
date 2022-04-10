using MediatR;

namespace LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList
{
    public class GetTrackingLinkListQuery : IRequest<List<TrackingLinkListVm>>
    {
    }
}
