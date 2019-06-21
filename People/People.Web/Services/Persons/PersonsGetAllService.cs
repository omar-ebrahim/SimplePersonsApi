using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using People.Api.Models;

namespace People.Web.Services.Persons
{
    public class PersonsGetAllService : BaseService<IEnumerable<Person>>
    {
        public PersonsGetAllService(HttpClient client) : base(client)
        {
        }
    }
}
