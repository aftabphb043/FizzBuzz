namespace FizzBuzz.Tests;

using FizzBuzz.Factories;
using FizzBuzz.Interfaces;
using FizzBuzz.Services;
using Xunit;
public class FizzBuzzServiceTests
{
    private readonly IFizzBuzzService _service;

    public FizzBuzzServiceTests()
    {
        _service = FizzBuzzServiceFactory.Craete();
    }
    [Theory]
    [InlineData(new string[] {"1","3","5","","15","A","23"},new string[]
    {
          "Divided 1 by 3\n Divided 1 by 5 ",
          "Fizz",
          "Buzz",
          "Invalid Item",
          "FizzBuzz",
          "Invalid Item",
          "Divided 23 by 3\n Divided 23 by 5 "
    })]
    public void ProcessFizzBuzz_ShouldReturnExpectedResult(string[] input, string[] expected)
    {
        var result = _service.ProcessFizzBuzz(input);
        Assert.Equal(expected, result);
    }


}