using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> bombNumber = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int bomb = bombNumber[0];
        int bombPower = bombNumber[1];
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == bomb)
            {
                int removedIndex = i;
                for (int j = 0; j < bombPower; j++)
                {
                    nums.RemoveAt(removedIndex - 1);
                    nums.RemoveAt(removedIndex);
                    removedIndex--;
                }
                nums.Remove(bomb);
            }
        }
        Console.WriteLine(nums.Sum());
    }
}

