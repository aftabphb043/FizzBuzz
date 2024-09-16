using FizzBuzz.Interfaces;

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
                    results.Add("Invalid Item");
                    continue;
                }
                if (!int.TryParse(value, out var number))
                {
                    results.Add("Invalid Item");
                    continue;
                }
                if (number % 3 == 0 && number % 5 == 0)
                {
                    results.Add("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    results.Add("Fizz");
                }
                else if (number % 5 == 0)
                {
                    results.Add("Buzz");
                }
                else
                {
                    results.Add($"Divided {number} by 3\n Divided {number} by 5 ");
                }
            }
            return results;
        }

    }
}
