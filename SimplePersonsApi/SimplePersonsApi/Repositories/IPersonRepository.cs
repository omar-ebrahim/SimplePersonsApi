using SimplePersonsApi.Models;
using System.Collections.Generic;

namespace SimplePersonsApi.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        Person Create(Person person);
        Person Update(int id, Person person);
        bool Delete(int id);
    }
}
