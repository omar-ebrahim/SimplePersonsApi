using SimplePersonsApi.Repositories;
using System;

namespace SimplePersonsApi.Services
{
    public class PersonsDeleteService : IPersonsDeleteService
    {
        private readonly IPersonRepository repository;

        public PersonsDeleteService(IPersonRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }
    }
}
