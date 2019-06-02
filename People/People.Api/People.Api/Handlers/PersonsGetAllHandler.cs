using People.Api.Models;
using People.Api.Services;
using System;
using System.Collections.Generic;

namespace People.Api.Handlers
{
    public class PersonsGetAllHandler : IPersonsGetAllHandler
    {
        private readonly IPersonsGetAllService service;

        public PersonsGetAllHandler(IPersonsGetAllService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public IEnumerable<Person> Handle()
        {
            return service.Get();
        }
    }
}
