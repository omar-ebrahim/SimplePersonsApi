using People.Api.Models;
using System.Collections.Generic;

namespace People.Api.Handlers
{
    public interface IPersonsGetAllHandler
    {
        IEnumerable<Person> Handle();
    }
}
