using System;
using System.Linq;

namespace MyArrayOperations
{
    public class Program
    {
        static void Main()
        {
            int[] test = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine(MyArray.AbsValueBiggerThanAverageCount(test));
        }
    }
}
