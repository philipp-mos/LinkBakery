using Microsoft.AspNetCore.Components;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail;
using MediatR;

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


        protected void HandleValidSubmit()
        {
            // _trackingLinkService.UpdateEntry(trackingLink);
            _uriHelper.NavigateTo("/TrackingLinks/Overview", true);
        }
    }
}
