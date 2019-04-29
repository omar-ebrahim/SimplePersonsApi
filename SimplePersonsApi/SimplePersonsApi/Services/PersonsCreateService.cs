using SimplePersonsApi.Models;
using SimplePersonsApi.Repositories;
using System;

namespace SimplePersonsApi.Services
{
    public class PersonsCreateService : IPersonsCreateService
    {
        private readonly IPersonRepository repository;

        public PersonsCreateService(IPersonRepository repository)
        {
            this.repository = repository ?? throw new ArgumentException(nameof(repository));
        }

        public Person Create(Person person)
        {
            return repository.Create(person);
        }
    }
}
