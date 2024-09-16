using FizzBuzz.Interfaces;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private const string Invalid_Item = "Invalid Item";
        private const string Fizz_Buzz = "FizzBuzz";
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const int Divisor_Three = 3;
        private const int Divisor_Five = 5;
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
                    results.Add(Invalid_Item);
                    continue;
                }
                if (!int.TryParse(value, out var number))
                {
                    results.Add(Invalid_Item);
                    continue;
                }
                if (number % Divisor_Three == 0 && number % Divisor_Five == 0)
                {
                    results.Add(Fizz_Buzz);
                }
                else if (number % Divisor_Three == 0)
                {
                    results.Add(Fizz);
                }
                else if (number % Divisor_Five == 0)
                {
                    results.Add(Buzz);
                }
                else
                {
                    results.Add($"Divided {number} by {Divisor_Three}\n Divided {number} by {Divisor_Five}");
                }
            }
            return results;
        }
    }
}
