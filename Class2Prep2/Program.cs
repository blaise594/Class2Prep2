using System;
using System.Collections.Generic;

namespace Class2Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>
            {
                "two",
                "four",
                "six",
                "eight",
                "ten",
                "twelve",
                "fourteen",
                "sixteen",
                "eighteen",
                "twenty"


            };
            string[] numbers = stringList.ToArray();
            fiveletters(numbers);
        }
        static void fiveletters(string[] numbers)
        {
            foreach (string number in numbers)
            {
                string length = number.Length.ToString();
                if (length == "5")
                {
                    Console.WriteLine(number);
                    Console.ReadLine();
                }
            }
        }
    }
}
