using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        string line = Console.ReadLine();
        Stack<char> reverseSting = new Stack<char>();
        foreach (var item in line)
        {
            reverseSting.Push(item);
        }
        while (reverseSting.Count!=0)
        {
            char element = reverseSting.Pop();
            Console.Write(element);
        }
    }
}


