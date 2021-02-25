using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzRV
{
    public static class FizzBuzz
    {
		public static string Ask(int number)
		{
			if (number == 0)
			{	
				throw new ArgumentException("0");
			}

			if (number < 0)
			{
				throw new ArgumentException("Negative");
			}

			if (number % 3 == 0)
			{
				return "Fizz";
			}

			if (number % 5 == 0)
			{
				return "Buzz";
			}

			return "";
		}

	}
}
