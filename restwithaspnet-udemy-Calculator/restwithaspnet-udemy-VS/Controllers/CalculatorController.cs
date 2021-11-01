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
        public IActionResult Get(string FirstNumber, string SecondNumber)
        {
            if (IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
            {
                var sum = ConvertToDecimal(FirstNumber) + ConvertToDecimal(SecondNumber);
                return Ok(sum.ToString());
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
