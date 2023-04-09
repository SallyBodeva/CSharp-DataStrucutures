using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Stack<int> elements = new Stack<int>(nums);
        while (true)
        {
            string[] command = Console.ReadLine().Split(" ");
            if (command[0].ToLower()=="end")
            {
                Console.WriteLine($"Sum: {elements.Sum()}");
                break;
            }
            switch (command[0].ToLower())
            {
                case "add":
                    elements.Push(int.Parse(command[1]));
                    elements.Push(int.Parse(command[2]));
                    break;
                case "remove":
                    int count = int.Parse(command[1]);
                    if (count<=elements.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            elements.Pop();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

