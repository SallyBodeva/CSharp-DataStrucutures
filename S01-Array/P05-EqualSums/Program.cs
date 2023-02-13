using System;
using System.Linq;

namespace P05_EqualSums
{
    public class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] leftNums = null;
            int[] rigthNums = null;
            int index = -1;
            bool isNot = false;
            for (int i = 0; i < nums.Length; i++)
            {
                leftNums = new int[i + 1];
                Array.Copy(nums, 0, leftNums, 0, i);
                rigthNums = new int[nums.Length - (i + 1)];
                Array.Copy(nums, i + 1, rigthNums, 0, nums.Length - (i + 1));
                if (leftNums.Sum() == rigthNums.Sum())
                {
                    index = i;
                    break;
                }
            }
            if (index<0)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
