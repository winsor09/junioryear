using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_methodsNowYoutry
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            int[] array = new int[] { 1, 9, 7, 4, 0 };
            int[,] ARRAY = new int[,] { { 1, 9, 7, 4, 0 }, { 5, 6, 8, 4, 1 } };
            int[][] oops = new int[][] { new int[]{ 1, 9, 7, 4, 0, 9, 9 , 9, 2 }, new int[]{ 5, 6, 8, 4, 1 } };

            Print(a);

            Console.WriteLine();

            Print(array);

            Console.WriteLine();
            Console.WriteLine();

            Print(ARRAY);

            Console.WriteLine();

            Print(oops);

            Console.ReadLine();

        }

        public static void Print(int a)
        {
            
            Console.WriteLine("Integer " + a);

        }

        public static void Print(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {

                Console.Write("|" + array[i] + "|");
               
            }
        }

        public static void Print(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("|" + array[i, j] + "|");
                }
                Console.WriteLine();

            }

        }

        public static void Print(int[][] oops)
        {

            for (int i = 0; i < oops.Length; i++)
            {
                for (int j = 0; j < oops[i].Length; j++)
                {
                    Console.Write("|" + oops[i][j] + "|");
                }
                Console.WriteLine();

            }

        }

    }
}
