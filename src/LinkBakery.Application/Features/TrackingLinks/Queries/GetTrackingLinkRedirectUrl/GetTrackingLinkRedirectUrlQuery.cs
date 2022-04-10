using MediatR;

namespace LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkRedirectUrl
{
    public class GetTrackingLinkRedirectUrlQuery : IRequest<TrackingLinkRedirectUrlVm>
    {
        public string Key { get; set; }
    }
}
