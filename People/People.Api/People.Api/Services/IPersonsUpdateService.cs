using People.Api.Models;

namespace People.Api.Services
{
    public interface IPersonsUpdateService
    {
        Person Put(int id, Person person);
    }
}
