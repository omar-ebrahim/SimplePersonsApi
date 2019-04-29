using SimplePersonsApi.Models;

namespace SimplePersonsApi.Services
{
    public interface IPersonsUpdateService
    {
        Person Put(int id, Person person);
    }
}
