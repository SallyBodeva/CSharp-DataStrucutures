using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();
        for (int i = 0; i < n; i++)
        {
            string[] info = Console.ReadLine().Split(' ').ToArray();
            string studentName = info[0];
            decimal grade = decimal.Parse(info[1]);
            if (studentsGrades.ContainsKey(studentName))
            {
                studentsGrades[studentName].Add(grade);
            }
            else
            {
               studentsGrades[studentName] = new List<decimal>();
               studentsGrades[studentName].Add(grade);
            }
        }
        foreach (var student in studentsGrades)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{student.Key}");
            sb.Append(" -> ");
            foreach (var grade in student.Value)
            {
                sb.Append($"{grade:f2} ");
            }
            sb.AppendLine($"(avg: {student.Value.Average():f2})");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}

