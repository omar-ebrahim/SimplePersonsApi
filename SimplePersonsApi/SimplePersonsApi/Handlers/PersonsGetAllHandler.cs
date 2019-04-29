using SimplePersonsApi.Models;
using SimplePersonsApi.Services;
using System;
using System.Collections.Generic;

namespace SimplePersonsApi.Handlers
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
