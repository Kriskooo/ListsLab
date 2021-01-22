using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "end")
            {
                if (commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                }
                else if (commands[0] == "Remove")
                {
                    numbers.Remove(int.Parse(commands[1]));
                }
                else if (commands[0] == "RemoveAt")
                {

                    numbers.RemoveAt(int.Parse(commands[1]));                  
                }
                else if (commands[0] == "Insert")
                {

                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
                commands.Clear();
                commands = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
