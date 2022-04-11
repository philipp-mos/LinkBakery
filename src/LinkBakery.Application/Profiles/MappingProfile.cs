using AutoMapper;
using LinkBakery.Application.Features.TrackingLinks.Commands.CreateTrackingLink;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkDetail;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkRedirectUrl;
using LinkBakery.Domain.Entities;

namespace LinkBakery.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TrackingLink, TrackingLinkListVm>().ReverseMap();
            CreateMap<TrackingLink, TrackingLinkDetailVm>().ReverseMap();
            CreateMap<TrackingLink, TrackingLinkRedirectUrlVm>().ReverseMap();

            CreateMap<TrackingLink, CreateTrackingLinkCommand>().ReverseMap();
            CreateMap<TrackingLink, UpdateTrackingLinkCommand>().ReverseMap();
        }
    }
}
