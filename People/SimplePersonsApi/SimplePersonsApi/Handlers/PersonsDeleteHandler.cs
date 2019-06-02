using People.Api.Services;
using System;

namespace People.Api.Handlers
{
    public class PersonsDeleteHandler : IPersonsDeleteHandler
    {
        private readonly IPersonsDeleteService service;

        public PersonsDeleteHandler(IPersonsDeleteService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public bool Handle(int id)
        {
            return service.Delete(id);
        }
    }
}
