using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteOfficeTechnicalTest
{
    public class Challenge3
    {        
        // Write a C# method that accepts an integer as input and returns true if the number is a prime,
        // and false if it is not.A prime number is a positive integer greater than 1 that has no positive
        // integer divisors other than 1 and itself
        public static void CallerMethod()
        {
            int inputNumber = 1741;
            bool result = PrimeNumber(inputNumber);
            Console.WriteLine(result);
        }


        public static bool PrimeNumber(int inputNumber)
        {
            if (inputNumber == 1) return false;
            if (inputNumber == 2) return true;
            if (inputNumber % 2 == 0) return false;


            int boundry = (int)Math.Sqrt(inputNumber);
            if (boundry % 2 == 0)
                boundry = +1;

            for (int i = 3; i <= boundry; i += 2)
            {
                if (inputNumber % i == 0)
                    return false;
            }


            return true;

        }
    }
}
