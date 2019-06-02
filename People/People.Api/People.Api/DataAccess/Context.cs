using Microsoft.EntityFrameworkCore;
using People.Api.Models;

namespace People.Api.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
