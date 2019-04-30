using System;
using System.ComponentModel.DataAnnotations;

namespace SimplePersonsApi.Models
{
    public class Person
    {
        public Person(string forenames, string surname, DateTime dateOfBirth)
        {
            Forenames = forenames ?? throw new ArgumentNullException(nameof(forenames));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));

            if (DateOfBirth < new DateTime(1753, 1, 1))
            {
                throw new ArgumentOutOfRangeException(nameof(dateOfBirth));
            }

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
