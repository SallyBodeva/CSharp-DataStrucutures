using System;
using System.Text;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int [] train = new int[n];
        for (int i = 0; i < n; i++)
        {
            int wagon = int.Parse(Console.ReadLine());
            train[i] = wagon;
        }
        Print(train);
        Console.WriteLine(SumArray(train));
    }
    public static void Print (int[] array)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            sb.Append(array[i]);
            sb.Append(" ");
        }
        Console.WriteLine(sb.ToString());
    }
    public static int SumArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
}

