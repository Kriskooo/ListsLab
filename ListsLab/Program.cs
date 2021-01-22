﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace ListsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    double sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i);
                    numbers.Insert(i, sum);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}