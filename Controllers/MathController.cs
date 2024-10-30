using CalculatorApp.Interfaces;
using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController(ICalculate calculate) : ControllerBase
    {
        private readonly ICalculate _calculate = calculate;

        [HttpPost]
        public IActionResult Post([FromBody] Rootobject rootObject)
        {
            try
            {
                var results = _calculate.Calculate(rootObject);
                return Ok(results);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidOperationException _ => BadRequest(e.Message),
                    _ => StatusCode(500, e.Message),
                };
            }

        }
    }
}
