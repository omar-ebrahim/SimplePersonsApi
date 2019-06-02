using People.Api.Models;

namespace People.Api.Services
{
    public interface IPersonsGetByIdService
    {
        Person Get(int id);
    }
}
