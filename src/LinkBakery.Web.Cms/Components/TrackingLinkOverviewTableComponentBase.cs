using LinkBakery.Web.Cms.Services.Interfaces;
using LinkBakery.Web.Cms.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace LinkBakery.Web.Cms.Components
{
    public class TrackingLinkOverviewTableComponentBase : ComponentBase
    {
        [Inject]
        private ITrackingLinkService _trackingLinkService { get; set; }
        [Inject]
        private IConfiguration _configuration { get; set; }

        protected IEnumerable<TrackingLinkOverviewDto> trackingLinks = new List<TrackingLinkOverviewDto>();
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
