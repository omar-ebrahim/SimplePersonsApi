using SimplePersonsApi.Models;

namespace SimplePersonsApi.Handlers
{
    public interface IPersonsGetByIdHandler
    {
        Person Handle(int id);
    }
}
