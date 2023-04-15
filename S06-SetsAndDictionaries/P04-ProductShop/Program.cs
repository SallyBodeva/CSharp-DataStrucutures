using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    static void Main()
    {
        SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();
        while (true)
        {
            string[] info = Console.ReadLine().Split(", ").ToArray();
            if (info[0]== "Revision")
            {
                foreach (var shop in shops)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"{shop.Key}->");
                    foreach (var product in shop.Value)
                    {
                        sb.AppendLine($"Product: {product.Key}, Price: {product.Value}");
                    }
                    Console.WriteLine(sb.ToString().TrimEnd());
                }
                break;
            }
            if (shops.ContainsKey(info[0]))
            {
                shops[info[0]].Add(info[1], double.Parse(info[2]));
            }
            else
            {
                shops[info[0]] = new Dictionary<string, double>();
                shops[info[0]].Add(info[1], double.Parse(info[2]));
            }
        }
    }
}

