using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using People.Api.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SimplePersonsApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            serviceCollection.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("PersonsDatabase")));
            SetUpDependencyInjection(serviceCollection);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        /// <summary>
        /// Using reflection to create dependencies
        /// </summary>
        private static void SetUpDependencyInjection(IServiceCollection serviceCollection)
        {
            // Handlers
            GetTypes("People.Api.Handlers").ToList().ForEach(x => serviceCollection.AddScoped(x.GetInterface($"I{x.Name}"), x));

            // Services
            GetTypes("People.Api.Services").ToList().ForEach(x => serviceCollection.AddScoped(x.GetInterface($"I{x.Name}"), x));

            // Repositories
            GetTypes("People.Api.Repositories").ToList().ForEach(x => serviceCollection.AddScoped(x.GetInterface($"I{x.Name}"), x));
        }

        private static IEnumerable<System.Type> GetTypes(string assemblyName)
        {
            return Assembly.GetExecutingAssembly().ExportedTypes.Where(x => x.IsClass && x.IsPublic && x.Namespace == assemblyName);
        }
    }
}
