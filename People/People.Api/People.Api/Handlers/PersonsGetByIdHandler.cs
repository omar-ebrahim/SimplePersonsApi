using People.Api.Models;
using People.Api.Services;
using System;

namespace People.Api.Handlers
{
    public class PersonsGetByIdHandler : IPersonsGetByIdHandler
    {
        private readonly IPersonsGetByIdService service;

        public PersonsGetByIdHandler(IPersonsGetByIdService service)
        {
            this.service = service ?? throw new NotImplementedException(nameof(service));
        }

        public Person Handle(int id)
        {
            return service.Get(id);
        }
    }
}
