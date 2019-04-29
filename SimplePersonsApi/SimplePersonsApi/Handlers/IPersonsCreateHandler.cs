using SimplePersonsApi.Models;

namespace SimplePersonsApi.Handlers
{
    public interface IPersonsCreateHandler
    {
        Person Handle(Person person);
    }
}
