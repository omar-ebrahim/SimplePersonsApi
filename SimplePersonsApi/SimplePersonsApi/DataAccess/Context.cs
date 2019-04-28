using Microsoft.EntityFrameworkCore;
using SimplePersonsApi.Models;

namespace SimplePersonsApi.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
