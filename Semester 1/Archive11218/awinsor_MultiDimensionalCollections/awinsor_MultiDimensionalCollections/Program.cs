using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_MultiDimensionalCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] multiDimensionalArray = new int[10, 5];

            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++ )
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    multiDimensionalArray[i, j] = i * j;
                }
            }
            Print2DArray(multiDimensionalArray);


            int[][] jaggedArray = new int[10][];

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j;
                }
            }
            Print2dJaggedArray(jaggedArray);

            Console.ReadLine();
        }

        static void Print2DArray(int[,] multiDimensionalArray)
        {
            
            for(int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
               

                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    Console.Write("|" + multiDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Print2dJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {


                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("|" + jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
