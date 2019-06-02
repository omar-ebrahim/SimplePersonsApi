using People.Api.Models;
using People.Api.Repositories;
using System;
using System.Collections.Generic;

namespace People.Api.Services
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
