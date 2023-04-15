using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>();
        for (int i = 0; i < n; i++)
        {
            string[] info = Console.ReadLine().Split(' ');
            string continentName = info[0];
            string countryName = info[1];
            string city = info[2];
            if (!countries.ContainsKey(continentName))
            {
                countries[continentName] = new Dictionary<string, List<string>>();
            }
            if (!countries[continentName].ContainsKey(countryName))
            {
                countries[continentName][countryName] = new List<string>();
            }
            countries[continentName][countryName].Add(city);

        }
        foreach (var continent in countries)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                string capitalCities = string.Join(", ", country.Value);
                sb.AppendLine($"  {country.Key} -> {capitalCities}");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}

