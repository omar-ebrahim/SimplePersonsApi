using SimplePersonsApi.Models;

namespace SimplePersonsApi.Services
{
    public interface IPersonsCreateService
    {
        Person Create(Person person);
    }
}
