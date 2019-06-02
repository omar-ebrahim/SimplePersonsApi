using People.Api.Models;
using People.Api.Repositories;
using System;

namespace People.Api.Services
{
    public class PersonsGetByIdService : IPersonsGetByIdService
    {
        private readonly IPersonRepository repository;

        public PersonsGetByIdService(IPersonRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Person Get(int id)
        {
            return repository.Get(id);
        }
    }
}
