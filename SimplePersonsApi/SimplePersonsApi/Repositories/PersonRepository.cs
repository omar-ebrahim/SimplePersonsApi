﻿using SimplePersonsApi.DataAccess;
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

        public Person Create(Person person)
        {
            context.Persons.Add(person);
            context.SaveChanges();
            return person;
        }

        public Person Update(int id, Person person)
        {
            var oldPerson = context.Find<Person>(id);
            oldPerson.Forenames = person.Forenames;
            oldPerson.Surname = person.Surname;
            oldPerson.DateOfBirth = person.DateOfBirth;
            context.SaveChanges();
            return oldPerson;
        }

        public bool Delete(int id)
        {
            var person = Get(id);
            if (person != null)
            {
                context.Persons.Remove(person);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}