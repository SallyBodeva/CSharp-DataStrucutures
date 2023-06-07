using System;


public class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string newText = Encrypt(text);
        Console.WriteLine(newText);

    }

    private static string Encrypt(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = (char)(text[i] + 3);
        }
        return new string(chars);
    }
}

