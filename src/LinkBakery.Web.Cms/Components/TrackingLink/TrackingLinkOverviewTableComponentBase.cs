using Microsoft.AspNetCore.Components;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList;
using MediatR;

namespace LinkBakery.Web.Cms.Components.TrackingLink
{
    public class TrackingLinkOverviewTableComponentBase : ComponentBase
    {
        [Inject]
        private IMediator _mediator { get; set; }
        [Inject]
        private IConfiguration _configuration { get; set; }

        protected List<TrackingLinkListVm> trackingLinks = new List<TrackingLinkListVm>();
        protected string redirectWebUrl = "";

        protected override async Task OnInitializedAsync()
        {
            trackingLinks = await _mediator.Send(new GetTrackingLinkListQuery());
            redirectWebUrl = _configuration["RedirectWebUrl"];
        }


        protected string GetActiveValueTitle(bool isActive)
        {
            return isActive ? "Ja" : "Nein";
        }
    }
}
