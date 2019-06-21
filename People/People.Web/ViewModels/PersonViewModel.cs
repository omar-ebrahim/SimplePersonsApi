using System;

namespace People.Web.ViewModels
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
