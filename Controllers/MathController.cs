using CalculatorApp.DTO;
using CalculatorApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly ICalculate _calculate;

        public MathController(ICalculate calculate)
        {
            _calculate = calculate;
        }

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
                switch (e)
                {
                    case InvalidOperationException _:
                        return BadRequest(e.Message);
                    default:
                        return StatusCode(500, e.Message);
                }
            }

        }


    }
}
