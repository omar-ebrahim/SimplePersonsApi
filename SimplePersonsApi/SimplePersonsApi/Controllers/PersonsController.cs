using Microsoft.AspNetCore.Mvc;
using SimplePersonsApi.Services;
using System;

namespace SimplePersonsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsGetAllService personsGetAllService;

        public PersonsController(IPersonsGetAllService personsGetAllService)
        {
            this.personsGetAllService = personsGetAllService ?? throw new ArgumentNullException(nameof(personsGetAllService));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(personsGetAllService.Get());
        }
    }
}
