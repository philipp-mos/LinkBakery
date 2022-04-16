using AutoMapper;
using LinkBakery.Application.Contracts.Persistence;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkList;
using LinkBakery.Application.Profiles;
using LinkBakery.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace LinkBakery.Application.UnitTests.TrackingLinks.Queries
{
    public class GetTrackingLinkListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ITrackingLinkRepository> _mockTrackingLinkRepository;


        public GetTrackingLinkListQueryHandlerTests()
        {
            _mockTrackingLinkRepository = RepositoryMocks.GetTrackingLinkRepository();

            var configurationProvider = new MapperConfiguration(cnf =>
            {
                cnf.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }



        [Fact]
        public async Task GetTrackingLinkListTest()
        {
            var handler = new GetTrackingLinkListQueryHandler(_mockTrackingLinkRepository.Object, _mapper);

            var result = await handler.Handle(new GetTrackingLinkListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<TrackingLinkListVm>>();

            result.Count.ShouldBe(1);
        }

    }
}
