using SimplePersonsApi.Models;
using SimplePersonsApi.Services;
using System;

namespace SimplePersonsApi.Handlers
{
    public class PersonsPutHandler : IPersonsPutHandler
    {
        private readonly IPersonsUpdateService service;

        public PersonsPutHandler(IPersonsUpdateService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public Person Put(int id, Person person)
        {
            return service.Put(id, person);
        }
    }
}
