//using System;
//using System.Linq;

//public class Program
//{
//    static void Main()
//    {
//        int[] rowsAndCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
//        int[,] matrix = new int[rowsAndCol[0], rowsAndCol[1]];
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            int[] elemntsOnRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//            int insertIndex = 0;

//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                matrix[i, j] = elemntsOnRow[insertIndex];
//                insertIndex++;
//            }
//        }

//        for (int k = 0; k < matrix.GetLength(1); k++)
//        {
//            int colSum = 0;
//            for (int i = 0; i < matrix.GetLength(0); i++)
//            {
//                colSum += matrix[i, k];
//            }
//            colSums[j] = colSum;
//            indexOfColumn += 1;
//            Console.WriteLine(sumCol);
//        }
//    }
//}
