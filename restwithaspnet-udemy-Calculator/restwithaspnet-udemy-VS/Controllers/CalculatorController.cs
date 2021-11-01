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
    public class CalculatorController : ControllerBase  // nome da rota e controller que o router pega (Calculator)
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{FirstNumber}/{SecondNumber}")]  //segunda parte, onde o 'SUM' o fez encontrar o GET - com os parametros de first e second number
        public IActionResult Sum(string FirstNumber, string SecondNumber)
        {
            if (IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
            {
                var sum = ConvertToDecimal(FirstNumber) + ConvertToDecimal(SecondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{FirstNumber}/{SecondNumber}")]  //segunda parte, onde o 'subtraction' o fez encontrar o GET - com os parametros de first e second number
        public IActionResult Subtraction(string FirstNumber, string SecondNumber)
        {
            if (IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
            {
                var sum = ConvertToDecimal(FirstNumber) - ConvertToDecimal(SecondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{FirstNumber}/{SecondNumber}")]  //segunda parte, onde o 'multiplication' o fez encontrar o GET - com os parametros de first e second number
        public IActionResult Multiplication(string FirstNumber, string SecondNumber)
        {
            if (IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
            {
                var sum = ConvertToDecimal(FirstNumber) * ConvertToDecimal(SecondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{FirstNumber}/{SecondNumber}")]  //segunda parte, onde o 'division' o fez encontrar o GET - com os parametros de first e second number
        public IActionResult Division(string FirstNumber, string SecondNumber)
        {
            if (IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
            {
                var sum = ConvertToDecimal(FirstNumber) / ConvertToDecimal(SecondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("mean/{FirstNumber}/{SecondNumber}")]  //segunda parte, onde o 'mean' o fez encontrar o GET - com os parametros de first e second number
        public IActionResult Mean(string FirstNumber, string SecondNumber)
        {
            if (IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
            {
                var sum = (ConvertToDecimal(FirstNumber) + ConvertToDecimal(SecondNumber)) / 2;
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("square-root/{FirstNumber}")]  //segunda parte, onde o 'square-root' o fez encontrar o GET - com os parametros de first number
        public IActionResult SquareRoot(string FirstNumber)
        {
            if (IsNumeric(FirstNumber))
            {
                var squareRoot = Math.Sqrt((double)ConvertToDecimal(FirstNumber)); // logica diferente, usa o Math.sqrt(double)
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Invalid Input");
        }
        private bool IsNumeric(string strNumber)
        {
            double number;
            bool IsNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return IsNumber;
        }
        private decimal ConvertToDecimal(string strNumber)
        {
            decimal DecimalValue;
            if (decimal.TryParse(strNumber, out DecimalValue))
            {
                return DecimalValue;
            }
            return 0;
        }


    }
}
