using System;


public class Program
{
    static void Main()
    {
        Graph<int> g = new Graph<int>();
        g.AddVertex(3);
        g.AddVertex(4);
        g.AddVertex(5);
        g.AddVertex(6);
        g.AddVertex(7);

        g.AddEdge(4, 5);
        g.AddEdge(5, 6);
        g.AddEdge(6, 7);
        //int count1 = g.Count;
        //Console.WriteLine(count1) ;
        //g.Test(5);
        //g.RemoveVertex(4);
        //int count2 = g.Count;
        //Console.WriteLine(count2);
        //g.Test(5);
        //Console.WriteLine(string.Join(" ",g.GetVertixes()));
        //Console.WriteLine(string.Join(" ",g.GetNeihghbors(23)));
        //Console.WriteLine(string.Join(" ", g.GetVertixes()));
        Console.WriteLine(g.HasEdge(4,5));
    }
}

