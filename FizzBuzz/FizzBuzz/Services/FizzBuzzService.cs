using FizzBuzz.Interfaces;
using FizzBuzz.Constants;
namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {   
        /// <summary>
        /// This method of FizzBuzzService Class accept the array of input and process it and returns the response as per FizzBuzz rules.
        /// </summary>
        /// <param name="fizzBuzz"></param>
        /// <returns></returns>
        public List<string> ProcessFizzBuzz(string[] fizzBuzz)
        {
            var results = new List<string>();
            foreach (var value in fizzBuzz)
            {
                if (string.IsNullOrEmpty(value))
                {
                    results.Add(FizzBuzzConstants.Invalid_Item);
                    continue;
                }
                if (!int.TryParse(value, out var number))
                {
                    results.Add(FizzBuzzConstants.Invalid_Item);
                    continue;
                }
                if (number % FizzBuzzConstants.Divisor_Three == 0 && number % FizzBuzzConstants.Divisor_Five == 0)
                {
                    results.Add(FizzBuzzConstants.Fizz_Buzz);
                }
                else if (number % FizzBuzzConstants.Divisor_Three == 0)
                {
                    results.Add(FizzBuzzConstants.Fizz);
                }
                else if (number % FizzBuzzConstants.Divisor_Five == 0)
                {
                    results.Add(FizzBuzzConstants.Buzz);
                }
                else
                {
                    results.Add($"Divided {number} by {FizzBuzzConstants.Divisor_Three}\n Divided {number} by {FizzBuzzConstants.Divisor_Five}");
                }
            }
            return results;
        }
    }
}
