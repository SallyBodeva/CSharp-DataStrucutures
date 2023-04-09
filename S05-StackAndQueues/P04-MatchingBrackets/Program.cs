using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        string equation = Console.ReadLine();
        Stack<int> indexes = new Stack<int>();
        for (int i = 0; i < equation.Length; i++)
        {
            if (equation[i] == '(')
            {
                indexes.Push(i);
            }
            if (equation[i] == ')')
            {
                int closingBracket = i;
                int openBracketIndex = indexes.Pop();
                string closingBracketString = equation.Substring(openBracketIndex, (closingBracket - openBracketIndex)+1);
                Console.WriteLine(closingBracketString);
            }
        }
    }
}

