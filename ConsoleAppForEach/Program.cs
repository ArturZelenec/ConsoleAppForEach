using System;
using System.Collections.Generic;

namespace ConsoleAppForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int double array filling with random numbers
            int[,] numbers = new int[3, 6];
            Random random = new Random();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(1, 55);
                }
            }
            // iterating over an array with foreach
            foreach (int i in numbers)
            {
                Console.WriteLine("element: " + i);
            }
            Console.WriteLine("_______________________");

            // we create a List and iterating over an array with foreach
            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            foreach (int num in nums)
            {
                Console.WriteLine("Element: " + num);
            }
            
        }
    }
}
