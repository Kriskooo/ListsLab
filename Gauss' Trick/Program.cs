using System;
using System.Collections.Generic;
using System.Linq;
namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            if (numbers.Count % 2 == 1)
            {
                for (int i = 0; i <= numbers.Count / 2; i++)
                {
                    if (i == numbers.Count / 2)
                    {
                        result.Add(numbers[i]);
                        break;
                    }
                    int sum = numbers[i] + numbers[numbers.Count - 1 - i];
                 
                    result.Add(sum);
                    sum = 0;
                   
                }
            }
            else if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    int sum = numbers[i] + numbers[numbers.Count - 1 - i];

                    result.Add(sum);
                    sum = 0;
                }

            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
