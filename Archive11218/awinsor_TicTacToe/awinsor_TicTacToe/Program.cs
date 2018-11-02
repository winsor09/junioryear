using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            bool win = false;
            char[,] array = new char[3, 3];


            Console.WriteLine("Player 1 it's you are X's ");
            Console.WriteLine("Player 2 it's you are O's\nDo you understand ? ");

            while (win != true)
            {

                Console.Clear();


                DrawBoard(array);


                Console.WriteLine("Player 1 it's your turn, choose a coordinate : ");
                Console.Write("X Coordinate: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Y Coordinate: ");
                y = int.Parse(Console.ReadLine());

                ProccessTurn(bool);
                    array[x, y] = 'X';


                Console.Clear();
                DrawBoard(array);



                Console.WriteLine("Player 2 it's your turn, choose a coordinate : ");
                Console.Write("X Coordinate: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Y Coordinate: ");
                y = int.Parse(Console.ReadLine());

                array[x, y] = 'O';

            }

            Console.ReadLine();
        }

        public static void DrawBoard(char[,] array)
        {
            
            for (int i = 0; i < array.GetLength(0); i++)
            {


                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("|" + array[i, j] + " ");
                }

                Console.WriteLine("|");
            }
        }

        public static bool ProccessTurn(char[,] array, int x, int y)
        {
            bool isopen = false;

            if (array[x, y] != 'X' || array[x, y] != 'O')
            {
                isopen = true;
            }

            else
            {
                isopen = false;
            }

            return isopen;
        }
    }
}
