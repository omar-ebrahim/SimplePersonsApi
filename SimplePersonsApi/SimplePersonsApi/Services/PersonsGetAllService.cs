using SimplePersonsApi.Models;
using SimplePersonsApi.Repositories;
using System;
using System.Collections.Generic;

namespace SimplePersonsApi.Services
{
    public class PersonsGetAllService : IPersonsGetAllService
    {
        private readonly IPersonRepository personRepository;

        public PersonsGetAllService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
        }

        public IEnumerable<Person> Get()
        {
            return personRepository.GetAll();
        }
    }
}
