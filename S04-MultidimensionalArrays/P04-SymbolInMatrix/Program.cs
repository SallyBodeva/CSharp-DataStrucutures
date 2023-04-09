using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, 1];
        ReadArray(matrix);
        char searchedSymbol = char.Parse(Console.ReadLine());
        SerchingForSymbol(matrix, searchedSymbol);
    }

    private static void SerchingForSymbol(string[,] matrix, char searchedSymbol)
    {
        int symbolRow = -1;
        int symbolColumn = -1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                foreach (var item in matrix[i,j])
                {
                    if (item == searchedSymbol)
                    {
                        symbolRow = i;
                        symbolColumn = matrix[i, j].IndexOf(searchedSymbol);
                        Console.WriteLine($"({symbolRow}, {symbolColumn})");
                    }
                }
            }
        }
        if (symbolRow == -1 && symbolColumn == -1)
        {
            Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
        }
    }

    private static void ReadArray(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string element = Console.ReadLine();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] =element;
            }
        }
    }
}

