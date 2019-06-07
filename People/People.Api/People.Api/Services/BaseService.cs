using People.Api.Repositories;
using System;

namespace People.Api.Services
{
    public abstract class BaseService
    {
        protected readonly IPersonRepository repository;

        public BaseService(IPersonRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
    }
}
