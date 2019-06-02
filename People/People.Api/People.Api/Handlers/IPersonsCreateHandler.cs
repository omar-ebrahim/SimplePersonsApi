using People.Api.Models;

namespace People.Api.Handlers
{
    public interface IPersonsCreateHandler
    {
        Person Handle(Person person);
    }
}
