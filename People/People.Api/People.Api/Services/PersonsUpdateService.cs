using People.Api.Models;
using People.Api.Repositories;

namespace People.Api.Services
{
    public class PersonsUpdateService : BaseService, IPersonsUpdateService
    {
        public PersonsUpdateService(IPersonRepository repository) : base(repository)
        {
        }

        public Person Put(int id, Person person)
        {
            return repository.Update(id, person);
        }
    }
}
