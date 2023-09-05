using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P01_EvenLines
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "C:\\Users\\EliteBook\\Desktop\\test.txt";
            StreamReader sr = new StreamReader(filePath);
            using (sr)
            {
                string line;
                int count = 0;
                while (true)
                {
                    line = sr.ReadLine();
                    if (count % 2 == 0)
                    {
                        if (line == null)
                        {
                            break;
                        }
                        line=line
                            .Replace("-", "@")
                            .Replace(",", "@")
                            .Replace(".", "@")
                            .Replace("!", "@")
                            .Replace("?", "@");
                        string[] words = line.Split(" ");
                        Array.Reverse(words);
                        Console.WriteLine(string.Join(" ",words));
                    }
                    count++;
                }
            }
        }
    }
}
