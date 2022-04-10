using LinkBakery.Web.Cms.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail;

namespace LinkBakery.Web.Cms.Components.TrackingLink
{
    public class TrackingLinkEditComponentBase : ComponentBase
    {
        [Inject]
        private ITrackingLinkService _trackingLinkService { get; set; }
        [Inject]
        private NavigationManager _uriHelper { get; set; }



        [Parameter]
        public int Id { get; set; }


        protected TrackingLinkDetailVm trackingLink;

        protected override async Task OnInitializedAsync()
            => trackingLink = await _trackingLinkService.FindByIdAsync(Id);


        protected void HandleValidSubmit()
        {
            // _trackingLinkService.UpdateEntry(trackingLink);
            _uriHelper.NavigateTo("/TrackingLinks/Overview", true);
        }
    }
}
