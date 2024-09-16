using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly FizzBuzzService _fizzBuzzService;
        public FizzBuzzController(FizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] FizzBuzzModel input)
        {
            var result = _fizzBuzzService.ProcessFizzBuzz(input.Value);
            return Ok(result);
        }
    }
}
