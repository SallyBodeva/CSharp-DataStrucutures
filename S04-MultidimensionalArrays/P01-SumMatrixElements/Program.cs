using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] rowsAndCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int[,] matrix = new int[rowsAndCol[0], rowsAndCol[1]];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] elemntsOnRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int insertIndex = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = elemntsOnRow[insertIndex];
                insertIndex++;
            }
        }
        Console.WriteLine(rowsAndCol[0]);
        Console.WriteLine(rowsAndCol[1]);
        Console.WriteLine(SumOfElemnts(matrix));
    }

    private static int SumOfElemnts(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }
}

