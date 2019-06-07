using Moq;
using People.Api.Repositories;
using People.Api.Services;
using System;
using Xunit;

namespace People.Api.UnitTests.Services
{
    public class BaseServiceTests
    {
        [Fact]
        public void Constructor_RepositoryIsMissing_Throws()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new TestableService(null));
        }

        [Fact]
        public void Constructor_RepositoryGiven_DoesNotThrow()
        {
            // Arrange
            var dummyRepostitory = new Mock<IPersonRepository>().Object;

            // Act
            var service = new TestableService(dummyRepostitory);

            // Assert
            Assert.NotNull(service);
        }
    }

    class TestableService : BaseService
    {
        public TestableService(IPersonRepository repository) : base(repository)
        {
        }
    }
}
