﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < number; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i}.{products[i - 1]}");
            }
        }
    }
}
