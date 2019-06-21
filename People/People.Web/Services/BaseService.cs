using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace People.Web.Services
{
    public abstract class BaseService<T> where T : class
    {
        private readonly HttpClient client;

        public BaseService(HttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        protected async Task<T> Get(string uri)
        {
            var response = await client.GetAsync(uri);
            return await response.Content.ReadAsAsync<T>();
        }
    }
}
