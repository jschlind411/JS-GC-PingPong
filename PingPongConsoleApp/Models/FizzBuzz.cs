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
            else if (number == 5)
            {
                return "Buzz";
            }

            return "FizzBuzz";
        }
    }
}
