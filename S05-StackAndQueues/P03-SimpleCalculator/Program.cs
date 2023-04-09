using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        string [] equation = Console.ReadLine().Split(' ');
        Stack<string> calculation = new Stack<string>(equation);
        int sum = 0;
        while (calculation.Count!=0)
        {
            int number = int.Parse(calculation.Pop());
            if (calculation.Count==0)
            {
                sum += number;
                break;
            }
            char mathOperation = char.Parse(calculation.Pop());
            switch (mathOperation)
            {
                case '+':
                    sum += number;
                    break;
                case '-':
                    sum -= number;
                    break;
            }
        }
        Console.WriteLine(sum);
    }
}


