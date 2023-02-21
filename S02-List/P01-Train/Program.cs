using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int max = int.Parse(Console.ReadLine());
        while (true)
        {
            string[] info = Console.ReadLine().Split(" ");
            if (info[0]=="end")
            {
                Console.WriteLine(String.Join(" ",wagons));
                break;
            }
            switch (info[0])
            {
                case "Add":
                    wagons.Add(int.Parse(info[1]));
                    break;
                default:
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(info[0]) <=max)
                        {
                            wagons[i] += int.Parse(info[0]);
                            break;
                        }
                    }
                    break;
            }
        }
    }
}

