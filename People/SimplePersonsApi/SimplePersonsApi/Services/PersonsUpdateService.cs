using People.Api.Models;
using People.Api.Repositories;
using System;

namespace People.Api.Services
{
    public class PersonsUpdateService : IPersonsUpdateService
    {
        private readonly IPersonRepository repository;

        public PersonsUpdateService(IPersonRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Person Put(int id, Person person)
        {
            return repository.Update(id, person);
        }
    }
}
