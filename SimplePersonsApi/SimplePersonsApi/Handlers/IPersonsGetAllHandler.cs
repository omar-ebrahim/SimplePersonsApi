using SimplePersonsApi.Models;
using System.Collections.Generic;

namespace SimplePersonsApi.Handlers
{
    public interface IPersonsGetAllHandler
    {
        IEnumerable<Person> Handle();
    }
}
