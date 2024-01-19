using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteOfficeTechnicalTest
{
    public static class Challenge2
    {
        // Write a C# method that accepts an array of integers as input and returns the largest number in
        // the array.For example, if the input array is [1, 4, 2, 7, 3], the method should return 7
        public static void CallerMethod()
        {
            int[] inputArray = { -4, -5, -3, -2, -1 };
            int res = GetLargestNumber(inputArray);
            Console.WriteLine(res);
        }


        public static int GetLargestNumber(int[] inputArray)
        {
            //initializing it by first number will help us in finding -ve numbers as well
            //also it will skip the first loop of 0 index and we can start from 1
            int largestNumber = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > largestNumber)
                    largestNumber = inputArray[i];
            }
            return largestNumber;
        }
    }
}
