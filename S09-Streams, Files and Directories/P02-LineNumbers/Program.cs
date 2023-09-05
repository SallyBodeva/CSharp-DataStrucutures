using System;
using System.IO;
using System.Text;

namespace P02_LineNumbers
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "C:\\Users\\EliteBook\\Desktop\\test.txt";
            StreamReader reader = new StreamReader(filePath);
            string outputfile = "C:\\Users\\EliteBook\\Desktop\\ouput.txt";
            StreamWriter writer = new StreamWriter(outputfile);
            StringBuilder sb = new StringBuilder();
            int count = 1;
            int lettersCount = 0;
            int marksCount = 0;
            using (reader)
            {
                using (writer)
                {
                    string line;
                    string outputline;

                    while (true)
                    {
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                         foreach (var item in line)
                         {
                             if (char.IsLetter(item))
                             {
                                 lettersCount++;
                             }
                             if (char.IsPunctuation(item))
                             {
                                 marksCount++;
                             }
                         }
                        outputline = $"Line {count}: {line} ({lettersCount})({marksCount})";
                        count++;
                        lettersCount = 0;
                        marksCount = 0;

                        writer.WriteLine(outputline);
                    }
                }
            }

        }
    }
}
