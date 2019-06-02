using People.Api.Repositories;
using System;
using Xunit;

namespace People.Api.UnitTests.Repositories
{
    public class PersonRepositoryTests
    {
        [Fact]
        public void Contructor_NoValueGiven_Throws()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PersonRepository(null));
        }
    }
}
