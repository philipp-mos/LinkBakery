using AutoMapper;
using LinkBakery.Core.Models;
using LinkBakery.Web.Cms.Dtos;

namespace LinkBakery.Web.Cms.Profiles
{
    public class TrackingLinkProfile : Profile
    {
        public TrackingLinkProfile()
        {
            CreateMap<TrackingLink, TrackingLinkOverviewDto>();
            CreateMap<TrackingLink, TrackingLinkEditDto>();

            CreateMap<TrackingLinkCall, TrackingLinkCallChartDto>();
        }
    }
}
