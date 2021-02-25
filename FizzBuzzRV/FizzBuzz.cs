using System;

namespace FizzBuzzRV
{
    public class FizzBuzz
    {
		public static string Ask(int number)
		{
			// If the number is 0, a exception is thrown
			if (number == 0)
			{	
				throw new ArgumentException("0");
			}

			// If the number is negative, a exception is thrown
			if (number < 0)
			{
				throw new ArgumentException("Negative");
			}

			// If the number is a multiple of 3 and a multiple of 5 -> FizzBuzz
			if (number % 3 == 0 && number % 5 == 0)
			{
				return "FizzBuzz";
			}

			// If the number is a multiple of 3 -> Fizz
			if (number % 3 == 0)
			{
				return "Fizz";
			}

			// If the number is a multiple of 5 -> Buzz
			if (number % 5 == 0)
			{
				return "Buzz";
			}

			// If none of the above, repeat Alice's number
			return number.ToString();
		}
	}
}
