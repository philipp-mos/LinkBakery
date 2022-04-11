using Microsoft.AspNetCore.Components;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail;
using MediatR;
using LinkBakery.Application.Features.TrackingLinks.Commands.UpdateTrackingLink;

namespace LinkBakery.Web.Cms.Components.TrackingLink
{
    public class TrackingLinkEditComponentBase : ComponentBase
    {
        [Inject]
        private IMediator _mediator { get; set; }
        [Inject]
        private NavigationManager _uriHelper { get; set; }



        [Parameter]
        public int Id { get; set; }


        protected TrackingLinkDetailVm trackingLink;

        protected override async Task OnInitializedAsync()
            => trackingLink = await _mediator.Send(new GetTrackingLinkDetailQuery() { Id = Id });


        protected async void HandleValidSubmit()
        {
            await _mediator.Send(new UpdateTrackingLinkCommand() {
                Id = Id,
                TargetUrl = trackingLink.TargetUrl,
                IsActive = trackingLink.IsActive,
                RedirectWithQueryParameter = trackingLink.RedirectWithQueryParameter
            });

            _uriHelper.NavigateTo("/TrackingLinks/Overview", true);
        }
    }
}
