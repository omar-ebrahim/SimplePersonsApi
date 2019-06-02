using Moq;
using People.Api.Repositories;
using People.Api.Services;
using System;
using Xunit;

namespace People.Api.UnitTests.Services
{
    public class PersonsDeleteServiceTests
    {
        [Fact]
        public void Constructor_RepositoryIsMissing_Throws()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PersonsDeleteService(null));
        }

        [Fact]
        public void Constructor_RepositoryGiven_DoesNotThrow()
        {
            // Arrange
            var dummyRepostitory = new Mock<IPersonRepository>().Object;

            // Act
            var service = new PersonsDeleteService(dummyRepostitory);

            // Assert
            Assert.NotNull(service);
        }
    }
}
