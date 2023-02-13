using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int rotation = int.Parse(Console.ReadLine());
        int insertIndex = 0;
        int[] rotatedNums = null;
        for (int i = 0; i < rotation; i++)
        {
            rotatedNums = nums;
            int Index = nums[0];
            Array.Copy(nums,1,rotatedNums,0,nums.Length-1);
            rotatedNums[nums.Length - 1] = Index;
        }
        Console.WriteLine(String.Join(" ",rotatedNums));
    }
}

