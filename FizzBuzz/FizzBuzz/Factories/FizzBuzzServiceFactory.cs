using FizzBuzz.Interfaces;
using FizzBuzz.Services;

namespace FizzBuzz.Factories
{
    public class FizzBuzzServiceFactory
    {
        public static IFizzBuzzService Craete()
        {
            return new FizzBuzzService();
        }
    }
}
