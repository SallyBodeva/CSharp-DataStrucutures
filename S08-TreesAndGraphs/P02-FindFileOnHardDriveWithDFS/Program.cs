using System;
using System.Data;
using System.IO;
using static System.Net.WebRequestMethods;


namespace P02_FindFileOnHardDriveWithDFS
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(FileSerach.Search("C:\\Users\\EliteBook\\Desktop\\SoftUni", "test.txt"));
        }
    }
    public static class FileSerach
    {
        public static string Search(string direcory, string fileName)
        {
            DirectoryInfo dir = new DirectoryInfo(direcory);
            FileInfo[] files = dir.GetFiles();
            foreach (var item in files)
            {
                if (item.Name==fileName)
                {
                    return $"{item.Name} is found in {dir.FullName}.";
                }
                else
                {
                    DirectoryInfo[] subDirectories = dir.GetDirectories();
                    foreach (var directory in subDirectories)
                    {
                        FileInfo[] subFiles = directory.GetFiles();
                        foreach (var file in subFiles)
                        {
                            if (file.Name==fileName)
                            {
                                return $"{item.Name} is found in {dir.FullName}."; ;
                            }
                        }
                    }
                }
            }
            return "File not found!";
        }
    }
}
