using People.Api.Services;
using System;
using Xunit;

namespace People.Api.UnitTests.Services
{
    public class PersonsCreateServiceTests
    {
        [Fact]
        public void Constructor_RepositoryMissing_Throws()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PersonsCreateService(null));
        }
    }
}
