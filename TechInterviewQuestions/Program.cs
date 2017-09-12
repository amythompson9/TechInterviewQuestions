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
            //Console.WriteLine("Hey FIZZBUZZ.");
            //Console.WriteLine("Please enter a number.");
            //int number = int.Parse(Console.ReadLine());
            //if ( number % 3 == 0 && number % 5 == 0)
            //{
            //    Console.WriteLine("FIZZBUZZ!");
            //}
            //else if ( number % 3 == 0 )
            //{
            //    Console.WriteLine("Fizz");
            //}
            //else if ( number % 5 == 0 )
            //    {
            //    Console.WriteLine("Buzz");
            //}
            //else
            //{
            //    Console.WriteLine("This number is not divisible by 3 or 5.");
            //}

            //Print out all prime numbers that are less than 100 to the Console 0 and 1 are not prime numbers


            //for (int i = 1; i <= 100 ; i++)
            //{
                
            //    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)

            //        Console.WriteLine(i);
            //}

            bool IsPrime = true;
            Console.WriteLine("Prime numbers: ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.WriteLine(i);
                }
                IsPrime = true;
            }

            
        }
    }
}
