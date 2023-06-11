using System;
using System.Drawing;

namespace P03_LargestConnectedArea
{
    public class Program
    {
        static void Main()
        {
            char[,] matrix = ReadMatrix();

            PtintMatrix(matrix);

        }

        private static char[,] ReadMatrix()
        {
            int col = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            char[,] matrix = new char[row, col];
            for (int i = 0; i < row; i++)
            {
                string colInfo = Console.ReadLine();
                if (colInfo.Length != col)
                {
                    throw new ArgumentException("Invalid matrix info");
                }
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = colInfo[j];
                }
            }

            return matrix;
        }

        private static void PtintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        //public static int FindArea(int row, int col, bool[,] visited)
        //{
        //    if (row >= size || row < 0 || col >= size || col < 0)
        //    {
        //        return 0;
        //    }
        //    if (visited[row, col])
        //    { return 0; }
        //    if (matrix[row, col] != '-')
        //    { return 0; }
        //    visited[row, col] = true; 
        //    var areaSize = 1;
        //    areaSize += FindArea(row + 1, col);
        //    areaSize += FindArea(row - 1, col);
        //    areaSize += FindArea(row, col + 1); 
        //    areaSize += FindArea(row, col - 1); 
        //    return areaSize;
        //}



    }
}
