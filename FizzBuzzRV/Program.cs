using System;
using System.Threading;

namespace FizzBuzzRV
{
    class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        static void Main(string[] args)
        {
            var rnd = new Random();
            var answer = string.Empty;

            DisplayMessage("Welcome to Fizzbuzz ! Press any key to launch.\n");

            do
            {
                var number = rnd.Next(1, 200);
                answer = FizzBuzz.Ask(number);

                Console.WriteLine($"Number : {number.ToString().PadRight(10)} Answer : {answer}");

                Thread.Sleep(500);
            }
            while (answer != "FizzBuzz");

            DisplayMessage("\nYou won ! Press any key to quit !");
        }

        /// <summary>
        /// Display a message in the console
        /// </summary>
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
