using System.Collections.Generic;
using System.Threading.Tasks;

namespace People.Web.Shared
{
    public interface IGetAllService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
    }
}
