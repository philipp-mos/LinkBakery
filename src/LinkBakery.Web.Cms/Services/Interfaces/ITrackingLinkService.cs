using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList;

namespace LinkBakery.Web.Cms.Services.Interfaces
{
    public interface ITrackingLinkService
    {
        Task<List<TrackingLinkListVm>> GetAllAsync();
        Task<TrackingLinkDetailVm> FindByIdAsync(int id);
        // void UpdateEntry(TrackingLinkEditDto trackingLinkDto);
    }
}
