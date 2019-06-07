using People.Api.Models;
using People.Api.Repositories;

namespace People.Api.Services
{
    public class PersonsCreateService : BaseService, IPersonsCreateService
    {
        public PersonsCreateService(IPersonRepository repository) : base(repository)
        {
        }

        public Person Create(Person person)
        {
            return repository.Create(person);
        }
    }
}
