using SimplePersonsApi.Models;
using System.Collections.Generic;

namespace SimplePersonsApi.Services
{
    public interface IPersonsGetAllService : IService
    {
        IEnumerable<Person> Get();
    }
}
