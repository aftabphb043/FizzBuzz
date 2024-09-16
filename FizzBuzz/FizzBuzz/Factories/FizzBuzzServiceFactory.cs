using FizzBuzz.Interfaces;
using FizzBuzz.Services;

namespace FizzBuzz.Factories
{
    public class FizzBuzzServiceFactory
    {
        public static IFizzBuzzService Create()
        {
            return new FizzBuzzService();
        }
    }
}
