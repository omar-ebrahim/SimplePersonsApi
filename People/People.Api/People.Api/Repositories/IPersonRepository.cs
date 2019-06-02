using People.Api.Models;
using System.Collections.Generic;

namespace People.Api.Repositories
{
    public interface IPersonRepository
    {
        // Gets all person records
        IEnumerable<Person> GetAll();

        // Gets a specific person based on the ID
        Person Get(int id);

        // Creates a new person
        Person Create(Person person);

        // Updates a specific person
        Person Update(int id, Person person);

        // Deletes a specific person
        bool Delete(int id);
    }
}
