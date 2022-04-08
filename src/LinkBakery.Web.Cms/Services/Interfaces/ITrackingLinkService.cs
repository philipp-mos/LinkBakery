using LinkBakery.Web.Cms.Dtos;

namespace LinkBakery.Web.Cms.Services.Interfaces
{
    public interface ITrackingLinkService : Core.Services.Interfaces.ITrackingLinkService
    {
        Task<IEnumerable<TrackingLinkOverviewDto>> GetAllAsync();
        Task<TrackingLinkEditDto> FindByIdAsync(int id);
    }
}
