using MediatR;

namespace LinkBakery.Application.Features.TrackingLinks.Commands.UpdateTrackingLink
{
    public class UpdateTrackingLinkCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string TargetUrl { get; set; }
        public bool IsActive { get; set; }
        public bool RedirectWithQueryParameter { get; set; }
    }
}
