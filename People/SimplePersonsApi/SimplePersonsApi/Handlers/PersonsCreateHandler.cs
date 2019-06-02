using People.Api.Models;
using People.Api.Services;
using System;

namespace People.Api.Handlers
{
    public class PersonsCreateHandler : IPersonsCreateHandler
    {
        private readonly IPersonsCreateService service;

        public PersonsCreateHandler(IPersonsCreateService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public Person Handle(Person person)
        {
            return service.Create(person);
        }
    }
}
