using People.Api.Models;
using People.Api.Repositories;
using System.Collections.Generic;

namespace People.Api.Services
{
    public class PersonsGetAllService : BaseService, IPersonsGetAllService
    {
        public PersonsGetAllService(IPersonRepository repository) : base(repository)
        {
        }

        public IEnumerable<Person> Get()
        {
            return repository.GetAll();
        }
    }
}
