using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        string[] emails = Console.ReadLine().Split(", ").ToArray();
        int matchesCount = 0;
        for (int i = 0; i < emails.Length; i++)
        {
            string currentword = emails[i];
            if (currentword.Length >= 3 && currentword.Length <= 16)
            {
                for (int j = 0; j < currentword.Length; j++)
                {
                    char currentChar = currentword[j];
                    if (char.IsLetter(currentChar) || char.IsDigit(currentChar) || currentChar == '-' || currentChar == '_')
                    {
                        matchesCount++;
                    }
                }
                if (matchesCount == currentword.Length)
                {
                    Console.WriteLine(currentword);
                }
                matchesCount = 0;
            }
        }
    }
}

