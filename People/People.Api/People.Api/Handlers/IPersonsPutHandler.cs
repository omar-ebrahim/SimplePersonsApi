using People.Api.Models;

namespace People.Api.Handlers
{
    public interface IPersonsPutHandler
    {
        Person Put(int id, Person person);
    }
}
