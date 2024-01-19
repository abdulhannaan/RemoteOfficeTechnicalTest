using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteOfficeTechnicalTest
{
    public static class Challenge4
    {
        //Write a C# method that accepts an integer n as input and prints the numbers from 1 to n. For
        //each multiple of 3, print "Fizz" instead of the number.For each multiple of 5, print "Buzz"
        //instead of the number. For each multiple of both 3 and 5, print "FizzBuzz" instead of the
        //number.
        public static void CallerMethod()
        {
            int inputNumber = 20;
            FizzBuzz(inputNumber);
        }


        public static void FizzBuzz(int inputNumber)
        {
            for (int i = 1; i <= inputNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
