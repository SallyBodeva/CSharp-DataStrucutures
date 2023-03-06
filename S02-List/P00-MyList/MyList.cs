using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;


public static class MyList
{
    public static string PrintList<T>(List<T> list, string separator = ", ")
    {
        if (list.Count == 0) { return string.Empty; }
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < list.Count - 1; i++)
        {
            sb.Append(list[i]);
            sb.Append(separator);
        }
        sb.Append(list[list.Count - 1]);
        return sb.ToString();
    }
    public static List<int> RandomList(int n, int min, int max)
    {
        List<int> randomNums = new List<int>();
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            int randomNum = random.Next(min, max);
            randomNums.Add(randomNum);
        }
        return randomNums;
    }
    public static List<double> RandomList(int n, double min, double max)
    {
        List<double> randomNums = new List<double>();
        Random random = new Random();
        int minNum = (int)Math.Ceiling(min);
        int maxNum = (int)Math.Floor(max);
        for (int i = 0; i < n; i++)
        {
            int randomNum = random.Next(minNum, maxNum);
            double randomD = random.NextDouble();
            randomNums.Add(Math.Round(randomNum * randomD, 2));
        }
        return randomNums;
    }
    public static List<bool> RandomBoolList(int n)
    {
        List<bool> bools = new List<bool>();
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            bools.Add(random.Next(0, 2) == 0 ? false : true);
        }
        return bools;
    }
    public static int GetMaxElement(List<int> nums)
    {
        int maxNum = int.MinValue;
        for (int i = 0; i < nums.Count; i++)
        {
            if (maxNum < nums[i])
            {
                maxNum = nums[i];
            }
        }
        return maxNum;
    }
    public static int GetSecondMax(List<int> list)
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > max)
            {
                max = list[i];
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > secondMax && list[i] < max)
            {
                secondMax = list[i];
            }
        }
        return secondMax;
    }
    public static double AverageValue(List<int> list)
    {
        double sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        return Math.Round((sum / list.Count), 2);
    }
    public static int AbsValue(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > 0) { sum += list[i]; }
            else { sum += (list[i]) * (-1); }
        }
        return sum;
    }
    public static int SumOfBiggerOf15AndDividedBy3(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > 15 && list[i] % 3 == 0) { sum += list[i]; }
        }
        return sum;
    }
    public static List<int> ListOfBiggerOf15AndDividedBy3(List<int> list)
    {
        List<int> nums = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > 15 && list[i] % 3 == 0) { nums.Add(list[i]); }
        }
        return nums;
    }
    public static int CountAbsValueBiggerThenAverage(List<int> list)
    {
        int count = 0;
        double sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        double average = sum / list.Count;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > 0)
            {
                if (list[i] > (average)) { count++; }
            }
            else
            {
                if (list[i] * (-1) > (average)) { count++; }
            }
        }
        return count;
    }
    public static List<int> ListAbsValueBiggerThenAverage(List<int> list)
    {
        double sum = 0;
        List<int> nums = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        double average = sum / list.Count;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > 0)
            {
                if (list[i] > (average)) { nums.Add(list[i]); }
            }
            else
            {
                if (list[i] * (-1) > (average)) { nums.Add(list[i]); }
            }
        }
        return nums;
    }
    public static List<int> BothElements(List<int> list1, List<int> list2)
    {
        List<int> list_1_2 = new List<int>();
        for (int i = 0; i < list1.Count; i++)
        {
            list_1_2.Add(list1[i]);
        }
        for (int i = list2.Count - 1; i >= 0; i--)
        {
            list_1_2.Add(list2[i]);
        }
        return list_1_2;
    }
    public static List<int> SumListElements(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < list1.Count; i++)
        {
            result.Add(list1[i] + list2[i]);
        }
        return result;
    }
    public static List<int> AddUpTo10(List<int> list)
    {
        List<int> changedList = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            changedList.Add(10 - list[i]);
        }
        return changedList;
    }
    public static List<int> IncreaseWith(List<int> list1, List<int> list2, int num)
    {
        List<int> changedList = new List<int>();
        for (int i = 0; i < list1.Count; i++)
        {
            changedList.Add(list1[i] + num);
        }
        for (int i = 0; i < list2.Count; i++)
        {
            changedList.Add(list2[i] + num);
        }
        return changedList;
    }
    //Задача 4
    public static int MaxElemnt(List<int> list)
    {
        return list.Max();
    }
    //Задача 6
    public static double AvgValue(List<int> list)
    {
        return Math.Round(list.Average(), 2);
    }
    //Задача 7
    public static int SumOfAbsValue(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += Math.Abs(list[i]);
        }
        return sum;
    }
    //Задача 10
    public static int AbsValueBuggerThanAvg(List<int> list)
    {
        int count = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (Math.Abs(list[i]) > list.Average())
            {
                count++;
            }
        }
        return count;
    }
    //Задача 15
    public static List<int> IncreaseByNum(List<int> list1, List<int> list2, int num)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < list1.Count; i++)
        {
            result.Add(list1[i]);
        }
        for (int i = 0; i < list2.Count; i++)
        {
            result.Add(list2[i]);
        }
        return result.Select(x => x + num).ToList();
    }
}

