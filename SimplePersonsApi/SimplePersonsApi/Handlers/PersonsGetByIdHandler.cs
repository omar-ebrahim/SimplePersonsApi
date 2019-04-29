using SimplePersonsApi.Models;
using SimplePersonsApi.Services;
using System;

namespace SimplePersonsApi.Handlers
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
