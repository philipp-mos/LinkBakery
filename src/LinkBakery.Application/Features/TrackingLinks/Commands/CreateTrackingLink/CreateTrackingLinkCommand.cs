using MediatR;

namespace LinkBakery.Application.Features.TrackingLinks.Commands.CreateTrackingLink
{
    public class CreateTrackingLinkCommand : IRequest<int>
    {
        public string Key { get; set; }
        public string TargetUrl { get; set; }
        public bool RedirectWithQueryParameter { get; set; }
        public bool IsActive { get; set; }
    }
}
