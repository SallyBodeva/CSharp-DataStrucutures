using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Dictionary<double, int> repetedNums = new Dictionary<double, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (repetedNums.ContainsKey(nums[i]))
            {
                repetedNums[nums[i]]++;
            }
            else
            {
                repetedNums.Add(nums[i], 1);
            }
        }
        foreach (var item in repetedNums)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{item.Key} - {item.Value} times");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
