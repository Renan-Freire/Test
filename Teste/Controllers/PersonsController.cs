using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Interface;
using Teste.Models;
using Teste.DTO;
using Newtonsoft.Json;

namespace Teste.Controllers
{
    [Produces("application/json")]
    [Route("api/Persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {

        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("{id}")]
        public String GetPerson(int id, List<Person> listaPessoas)
        {
            var person = _personService.GetById(id, listaPessoas);

            string personJson = JsonConvert.SerializeObject(person);

            return personJson;
        }

        [HttpPost("incluir/{person}")]
        public IActionResult AddPerson([FromHeader] PersonDTO person, List<Person> listaPessoas)
        {
            try
            {
                _personService.AddPerson(person, listaPessoas);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
