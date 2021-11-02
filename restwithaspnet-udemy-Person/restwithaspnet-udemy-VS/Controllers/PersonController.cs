using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restwithaspnet_udemy_VS.Model;
using restwithaspnet_udemy_VS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restwithaspnet_udemy_VS.Controllers
{
    [ApiController]
    [Route("[controller]")]  //primeira parte url - pega o controller
    public class PersonController : ControllerBase  
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonService _PersonService;
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _PersonService = personService;
        }

        [HttpGet]  //
        public IActionResult Get()
        {
            return Ok(_PersonService.FindAll());
        }
        
        [HttpGet("{id}")]  //
        public IActionResult Get(long id)
        {
            var person = _PersonService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }        
        [HttpPost]  //
        public IActionResult Post([FromBody] Person person)
        {

            if (person == null) return BadRequest();
            return Ok(_PersonService.Create(person));
        }        
        [HttpPut]  //
        public IActionResult Put([FromBody] Person person)
        {

            if (person == null) return BadRequest();
            return Ok(_PersonService.Update(person));
        }
        [HttpDelete("{id}")]  //
        public IActionResult Delete(long id)
        {
            _PersonService.Delete(id);
            return NoContent();
        }
    }
}
