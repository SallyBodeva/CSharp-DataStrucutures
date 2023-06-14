using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


public class Graph<T>
{
    private Dictionary<T, List<T>> adjacencyList;
    private int count;

    public int Count { get => adjacencyList.Count; }
    public Graph()
    {
        adjacencyList = new Dictionary<T, List<T>>();
    }
    public void AddVertex(T vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<T>();
        }
    }
    public void AddEdge(T source, T destination)
    {
        if (!adjacencyList.ContainsKey(source))
        {
            adjacencyList[source] = new List<T>();
        }
        if (!adjacencyList.ContainsKey(destination))
        {
            adjacencyList[destination] = new List<T>();
        }
        adjacencyList[source].Add(destination);
        adjacencyList[destination].Add(source);
    }
    public void RemoveVertex(T vertex)
    {
        if (adjacencyList.ContainsKey(vertex))
        {
            List<T> neihgbors = adjacencyList[vertex];
            foreach (var item in neihgbors)
            {
                adjacencyList[item].Remove(vertex);
            }
        }
        adjacencyList.Remove(vertex);
    }
    public void RemoveEdge(T source, T destionation)
    {
        if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destionation))
        {
            adjacencyList[source].Remove(destionation);
            adjacencyList[destionation].Remove(source);
        }
    }
    public void Test(T vetrex)
    {
        Console.WriteLine(String.Join(" ", adjacencyList[vetrex]));
    }
    public List<T> GetNeihghbors(T vertex)
    {
        if (adjacencyList.ContainsKey(vertex))
        {
            return adjacencyList[vertex];
        }
        return new List<T>();
    }
    public List<T> GetVertixes()
    {
        return adjacencyList.Keys.ToList();
    }
    public bool HasEdge(T source, T destination)
    {
        if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destination))
        {
            if (adjacencyList[source].Contains(destination) && adjacencyList[destination].Contains(source))
            {
                return true;
            }
        }
        return false;
    }
}
