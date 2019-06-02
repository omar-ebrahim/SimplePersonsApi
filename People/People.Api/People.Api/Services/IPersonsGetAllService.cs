using People.Api.Models;
using System.Collections.Generic;

namespace People.Api.Services
{
    public interface IPersonsGetAllService
    {
        IEnumerable<Person> Get();
    }
}
