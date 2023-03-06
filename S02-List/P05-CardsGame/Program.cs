using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<int> cardsFirstPlayer = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> cardsSecondPlayer = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int n = cardsFirstPlayer.Count;
        for (int i = 0; i < n; i++)
        {
            if (cardsFirstPlayer.Count==0)
            {
                Console.WriteLine($"First player wins! Sum: {cardsFirstPlayer.Sum()}");
                break;
            }
            if (cardsSecondPlayer.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {cardsSecondPlayer.Sum()}");
                break;
            }
            if (cardsFirstPlayer[i] > cardsSecondPlayer[i])
            {
                cardsFirstPlayer.Add(cardsFirstPlayer[i]);
                cardsFirstPlayer.Add(cardsSecondPlayer[i]);
                cardsSecondPlayer.RemoveAt(i);
            }
            else if (cardsFirstPlayer[i] < cardsSecondPlayer[i])
            {
                cardsSecondPlayer.Add(cardsSecondPlayer[i]);
                cardsSecondPlayer.Add(cardsFirstPlayer[i]);
                cardsFirstPlayer.RemoveAt(i);
            }
            else
            {
                cardsFirstPlayer.RemoveAt(i);
                cardsSecondPlayer.RemoveAt(i);
            }
        }
    }
}

