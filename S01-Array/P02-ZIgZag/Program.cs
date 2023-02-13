using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstRow = new int[n];
        int[] secondRow = new int[n];
        for (int i = 0; i < n; i++)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if (i%2==0)
            {
                firstRow[i] = nums[0];
                secondRow[i] = nums[1];
            }
            else
            {
                firstRow[i] = nums[1];
                secondRow[i] = nums[0];
            }
        }
        Console.WriteLine(String.Join(" ",firstRow));
        Console.WriteLine(String.Join(" ",secondRow));
    }
}
