using People.Api.Models;

namespace People.Api.Services
{
    public interface IPersonsCreateService
    {
        Person Create(Person person);
    }
}
