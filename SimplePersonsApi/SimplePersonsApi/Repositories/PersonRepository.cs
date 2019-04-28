using SimplePersonsApi.DataAccess;
using SimplePersonsApi.Models;
using System;
using System.Collections.Generic;

namespace SimplePersonsApi.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly Context context;

        public PersonRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return context.Persons;
        }

        public Person Get(int id)
        {
            return context.Find<Person>(id);
        }

        public void Create(Person person)
        {
            Validate(person);

            context.Persons.Add(person);
            context.SaveChanges();
        }

        public void Update(int id, Person person)
        {
            var oldPerson = context.Find<Person>(id);

            if (oldPerson != null)
            {
                Validate(person);
                oldPerson.Forenames = person.Forenames;
                oldPerson.Surname = person.Surname;
                oldPerson.DateOfBirth = person.DateOfBirth;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var person = Get(id);
            if (person != null)
            {
                context.Persons.Remove(person);
                context.SaveChanges();
            }
        }

        private static void Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.Forenames))
            {
                throw new ArgumentNullException(nameof(person.Forenames));
            }

            if (string.IsNullOrWhiteSpace(person.Surname))
            {
                throw new ArgumentNullException(nameof(person.Surname));
            }

            if (person.DateOfBirth == null)
            {
                throw new ArgumentNullException(nameof(person.DateOfBirth));
            }
            else if (person.DateOfBirth < new DateTime(1753, 1, 1))
            {
                throw new ArgumentOutOfRangeException(nameof(person.DateOfBirth));
            }
        }

    }
}
