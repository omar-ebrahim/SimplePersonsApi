using People.Api.Models;
using People.Api.Repositories;

namespace People.Api.Services
{
    public class PersonsGetByIdService : BaseService, IPersonsGetByIdService
    {
        public PersonsGetByIdService(IPersonRepository repository) : base(repository)
        {
        }

        public Person Get(int id)
        {
            return repository.Get(id);
        }
    }
}
