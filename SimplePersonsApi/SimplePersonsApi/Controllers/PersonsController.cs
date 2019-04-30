using Microsoft.AspNetCore.Mvc;
using SimplePersonsApi.Handlers;
using SimplePersonsApi.Models;
using System;

namespace SimplePersonsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsGetAllHandler getAllHandler;
        private readonly IPersonsGetByIdHandler getByIdHandler;
        private readonly IPersonsCreateHandler createHandler;
        private readonly IPersonsPutHandler putHandler;
        private readonly IPersonsDeleteHandler deleteHandler;

        public PersonsController(IPersonsGetAllHandler getAllHandler, IPersonsGetByIdHandler getByIdHandler, IPersonsCreateHandler createHandler, IPersonsPutHandler putHandler, IPersonsDeleteHandler deleteHandler)
        {
            this.getAllHandler = getAllHandler ?? throw new ArgumentNullException(nameof(getAllHandler));
            this.getByIdHandler = getByIdHandler ?? throw new ArgumentNullException(nameof(getByIdHandler));
            this.createHandler = createHandler ?? throw new ArgumentNullException(nameof(createHandler));
            this.putHandler = putHandler ?? throw new ArgumentNullException(nameof(putHandler));
            this.deleteHandler = deleteHandler ?? throw new ArgumentNullException(nameof(deleteHandler));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(getAllHandler.Handle());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = getByIdHandler.Handle(id);
            if (person == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(person);
            }
        }

        [HttpPost]
        public IActionResult Post(Person person)
        {
            TryValidateModel(person);

            if (ModelState.IsValid)
            {
                return Ok(createHandler.Handle(person));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{personId}")]
        public IActionResult Put(int personId, [FromBody]Person person)
        {
            var personToEdit = getByIdHandler.Handle(personId);
            if (personToEdit == null)
            {
                return NotFound();
            }
            else
            {
                TryValidateModel(person);
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(putHandler.Put(personId, person));
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var person = getByIdHandler.Handle(id);
            if (person == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(deleteHandler.Handle(id));
            }
        }
    }
}
