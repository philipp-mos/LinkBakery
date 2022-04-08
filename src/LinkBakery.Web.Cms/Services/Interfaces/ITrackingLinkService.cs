using LinkBakery.Web.Cms.Dtos;

namespace LinkBakery.Web.Cms.Services.Interfaces
{
    public interface ITrackingLinkService
    {
        Task<IEnumerable<TrackingLinkDto>> GetAllAsync();
    }
}
