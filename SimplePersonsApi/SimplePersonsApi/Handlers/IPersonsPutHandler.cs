using SimplePersonsApi.Models;

namespace SimplePersonsApi.Handlers
{
    public interface IPersonsPutHandler
    {
        Person Put(int id, Person person);
    }
}
