using People.Api.Models;

namespace People.Api.Handlers
{
    public interface IPersonsGetByIdHandler
    {
        Person Handle(int id);
    }
}
