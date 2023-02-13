using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] rigthElements = null;
        int countTopIns = 0;
        int initialCountTopIns = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            rigthElements = new int[nums.Length - (i + 1)];
            Array.Copy(nums, i + 1, rigthElements, 0, nums.Length - (i + 1));
            int current = nums[i];
            for (int k = 0; k < rigthElements.Length; k++)
            {
                if (current > rigthElements[k])
                {
                    initialCountTopIns++;
                }
                if (initialCountTopIns == rigthElements.Length)
                {
                    countTopIns++;
                }
            }
            initialCountTopIns = 0;
        }
        int[] topIns = new int[countTopIns+1];
        // +1 because the last element will always be a top int
        int insetIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            rigthElements = new int[nums.Length - (i + 1)];
            Array.Copy(nums, i + 1, rigthElements, 0, nums.Length - (i + 1));
            int current = nums[i];
            int biggerNumCount = 0;
            for (int k = 0; k < rigthElements.Length; k++)
            {
                if (current > rigthElements[k])
                {
                    biggerNumCount+=1;
                }
            }
            if (biggerNumCount==rigthElements.Length)
            {
                topIns[insetIndex] = current;
                insetIndex++;
            }
        }
        Console.WriteLine(string.Join(" ", topIns));

    }
}
