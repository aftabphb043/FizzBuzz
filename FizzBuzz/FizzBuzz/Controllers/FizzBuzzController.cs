﻿using FizzBuzz.Factories;
using FizzBuzz.Interfaces;
using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;
        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {            
            _fizzBuzzService = FizzBuzzServiceFactory.Create();
        }

        /// <summary>
        /// FizzBuzz Post method accept array of values and returns the response as per the FizzBuzz rules.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] FizzBuzzModel input)
        {
            var result = _fizzBuzzService.ProcessFizzBuzz(input.Value);
            return Ok(result);
        }
    }
}
