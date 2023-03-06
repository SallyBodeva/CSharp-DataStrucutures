using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int[,] nums = new int[3, 2];
        ReadArray(nums);
        PrintArray(nums);
        SumOfRows(nums);
    }
    public static void ReadArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                array[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }
    public static void PrintArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(array[row,col]+" ");
            }
            Console.WriteLine();
        }
    }
    public static void SumOfRows(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            int sum = 0;
            for (int col = 0; col < array.GetLength(1); col++)
            {
                sum += array[row, col];
                Console.Write(array[row, col] + " ");
            }
            Console.Write($" = {sum}");
            Console.WriteLine();
        }
    }
    public static void SumOfCol(int[,] array)
    {
        List<int> sumofCol = new List<int>();
        int index = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                int sum = 0;

                if (col==index)
                {
                    sum += array[row, col];
                }
            }
        }
        index++;
    }
}

