using AutoMapper;
using LinkBakery.Core.Models;
using LinkBakery.Web.Redirect.Dtos;

namespace LinkBakery.Web.Redirect.Profiles
{
    public class TrackingLinkProfile : Profile
    {
        public TrackingLinkProfile()
        {
            CreateMap<TrackingLink, TrackingLinkDto>();
        }
    }
}
