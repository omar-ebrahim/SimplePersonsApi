using People.Api.Repositories;

namespace People.Api.Services
{
    public class PersonsDeleteService : BaseService, IPersonsDeleteService
    {
        public PersonsDeleteService(IPersonRepository repository) : base(repository)
        {
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }
    }
}
