using System;
using System.ComponentModel.DataAnnotations;

namespace SimplePersonsApi.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        [Required]
        public string Forenames { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
