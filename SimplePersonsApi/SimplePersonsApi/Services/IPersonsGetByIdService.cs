using SimplePersonsApi.Models;

namespace SimplePersonsApi.Services
{
    public interface IPersonsGetByIdService : IService
    {
        Person Get(int id);
    }
}
