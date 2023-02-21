using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> nums2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int n = 5;
        Console.WriteLine(String.Join(" ",MyList.IncreaseWith(nums,nums2,n)));
    }
}

