using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RemoteOfficeTechnicalTest
{
    public static class Challenge1
    {
        // Write a C# method that accepts a string as input and returns the string in reverse order. For
        // example, if the input is "hello world", the method should return "dlrow olleh".
        public static void CallerMethod()
        {
            string inputString = "hello world";
            string result = ReverseString(inputString);
            Console.WriteLine(result);
        }

        public static string ReverseString(string inputString)
        {
            StringBuilder outputBuilder = new StringBuilder();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                outputBuilder.Append(inputString[i]);
            }
            return outputBuilder.ToString();
        }
    }
}
