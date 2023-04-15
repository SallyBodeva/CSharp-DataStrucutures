using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        HashSet<string> cars = new HashSet<string>();
        while (true)
        {
            string[] cmd = Console.ReadLine().Split(", ");
            if (cmd[0] == "END")
            {
                break;
            }
            switch (cmd[0])
            {
                case "IN":
                    cars.Add(cmd[1]);
                    break;

                case "OUT":
                    cars.Remove(cmd[1]);
                    break;
            }
        }
        if (cars.Any())
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
        
    }
}

