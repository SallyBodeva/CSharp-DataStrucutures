using System;


public class Program
{
    static void Main()
    {
        string filePath = Console.ReadLine();
        int pointIndex = filePath.LastIndexOf('.');
        int slashIndex = filePath.LastIndexOf('\\');
        string fileExtension = filePath.Substring(pointIndex+1, filePath.Length-(pointIndex+1));
        string fileName = filePath.Substring(slashIndex+1,filePath.Length-(slashIndex+1)-fileExtension.Length-1);
        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"File extension: {fileExtension}");
    }
}

