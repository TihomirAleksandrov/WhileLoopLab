﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int input = 0;
            int sum = 0;

            while (sum < num)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine(sum);
        }
    }
}
