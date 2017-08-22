using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey FIZZBUZZ.");
            Console.WriteLine("Please enter a number.");
            int number = int.Parse(Console.ReadLine());
            if ( number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FIZZBUZZ!");
            }
            else if ( number % 3 == 0 )
            {
                Console.WriteLine("Fizz");
            }
            else if ( number % 5 == 0 )
                {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3 or 5.");
            }
        }
    }
}
