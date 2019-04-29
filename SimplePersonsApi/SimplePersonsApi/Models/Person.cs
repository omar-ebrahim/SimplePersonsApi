using System;
using System.ComponentModel.DataAnnotations;

namespace SimplePersonsApi.Models
{
    public class Person
    {
        public Person(string forenames, string surname, DateTime dateOfBirth)
        {
            Forenames = forenames;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public int PersonID { get; set; }

        [Required]
        public string Forenames { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
