using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int minCount = Math.Min(firstNums.Count, secondNums.Count);
            List<int> result = new List<int>();
            int counter = 0;
            for (int i = 0; i < minCount; i++)
            {
                if (counter == minCount)
                {
                    break;
                }
                result.Add(firstNums[i]);
                result.Add(secondNums[i]);
                firstNums.RemoveAt(i);
                secondNums.RemoveAt(i);
                counter++;
                i = -1;
            }
            if (firstNums.Count > 0)
            {
                for (int i = 0; i < firstNums.Count; i++)
                {
                    result.Add(firstNums[i]);
                }
            }
            else if (secondNums.Count > 0)
            {
                for (int i = 0; i < secondNums.Count; i++)
                {
                    result.Add(secondNums[i]);
                }
            }
            Console.WriteLine(string.Join(' ',result));
        }
    }
}
