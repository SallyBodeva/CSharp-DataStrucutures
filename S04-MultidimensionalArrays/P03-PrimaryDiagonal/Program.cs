using System;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        int sum = 0;
        ReadArray(matrix);
        sum = SumOfElements(matrix, sum);
        Console.WriteLine(sum);

    }

    private static int SumOfElements(int[,] matrix, int sum)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    sum += matrix[i, j];
                }
            }
        }

        return sum;
    }

    private static void ReadArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = elements[j];
            }
        }
    }
}

