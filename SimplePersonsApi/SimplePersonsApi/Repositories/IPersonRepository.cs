using SimplePersonsApi.Models;
using System.Collections.Generic;

namespace SimplePersonsApi.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        void Create(Person person);
        void Update(int id, Person person);
        void Delete(int id);
    }
}
