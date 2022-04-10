using LinkBakery.Web.Cms.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList;

namespace LinkBakery.Web.Cms.Components
{
    public class TrackingLinkOverviewTableComponentBase : ComponentBase
    {
        [Inject]
        private ITrackingLinkService _trackingLinkService { get; set; }
        [Inject]
        private IConfiguration _configuration { get; set; }

        protected List<TrackingLinkListVm> trackingLinks = new List<TrackingLinkListVm>();
        protected string redirectWebUrl = "";

        protected override async Task OnInitializedAsync()
        {
            trackingLinks = await _trackingLinkService.GetAllAsync();
            redirectWebUrl = _configuration["RedirectWebUrl"];
        }


        protected string GetActiveValueTitle(bool isActive)
        {
            if (isActive)
            {
                return "Ja";
            }

            return "Nein";
        }
    }
}
