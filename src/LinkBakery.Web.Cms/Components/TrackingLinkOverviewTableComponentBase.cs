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
        private NavigationManager _uriHelper { get; set; }
        [Inject]
        private IConfiguration _configuration { get; set; }
        [Inject]
        private IJSRuntime _jsRuntime { get; set; }


        protected IEnumerable<TrackingLinkOverviewDto> trackingLinks = new List<TrackingLinkOverviewDto>();

        protected override async Task OnInitializedAsync()
        {
            trackingLinks = await _trackingLinkService.GetAllAsync();
        }


        protected void NavigateToEdit(int id) => _uriHelper.NavigateTo($"/TrackingLinks/Edit/{ id }");
        protected void NavigateToChart(int id) => _uriHelper.NavigateTo($"/TrackingLinks/Chart/{ id }");
        protected void NavigateToTrackingLinkInNewTab(string key) => _jsRuntime.InvokeAsync<object>("open", $"{ _configuration["RedirectWebUrl"] }{ key }", "_blank");


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
