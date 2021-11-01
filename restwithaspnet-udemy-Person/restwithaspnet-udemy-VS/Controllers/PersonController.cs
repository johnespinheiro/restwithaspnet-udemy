using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restwithaspnet_udemy_VS.Controllers
{
    [ApiController]
    [Route("[controller]")]  //primeira parte url - pega o controller ( calculator )
    public class PersonController : ControllerBase  // nome da rota e controller que o router pega (Calculator)
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{FirstNumber}/{SecondNumber}")]  //segunda parte, onde o 'SUM' o fez encontrar o GET - com os parametros de first e second number
        public IActionResult Sum(string FirstNumber, string SecondNumber)
        {
            return BadRequest("Invalid Input");
        }
    }
}
