using AutoMapper;
using LinkBakery.Application.Contracts.Persistence;
using LinkBakery.Application.Features.TrackingLinks.Commands.CreateTrackingLink;
using LinkBakery.Application.Profiles;
using LinkBakery.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace LinkBakery.Application.UnitTests.TrackingLinks.Commands
{
    public class CreateTrackingLinkTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ITrackingLinkRepository> _mockTrackingLinkRepository;


        public CreateTrackingLinkTests()
        {
            _mockTrackingLinkRepository = RepositoryMocks.GetTrackingLinkRepository();

            var configurationProvider = new MapperConfiguration(cnf =>
            {
                cnf.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }



        [Fact]
        public async Task Handle_TrackingLink_AddedToTrackingLinkRepository()
        {
            var handler = new CreateTrackingLinkCommandHandler(_mockTrackingLinkRepository.Object, _mapper);

            await handler.Handle(new CreateTrackingLinkCommand() { Key = "mcrsft", TargetUrl = "https://www.microsoft.com/", IsActive = true, RedirectWithQueryParameter = false }, CancellationToken.None);

            var allTrackingLinks = await _mockTrackingLinkRepository.Object.GetAllAsync();

            allTrackingLinks.Count.ShouldBe(2);
        }

    }
}
