using System;

namespace Models
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }

            return "Buzz";
        }
    }
}
