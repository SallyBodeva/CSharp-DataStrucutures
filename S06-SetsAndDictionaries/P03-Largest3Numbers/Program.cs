using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(nums);
        Array.Reverse(nums);
        try
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
        catch 
        {

        }
       
    }
}

