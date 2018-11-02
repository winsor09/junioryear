using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int answr = 0;

            while (answr != 22)
            {
                Console.Clear();    //clear screen

                //menu
                Console.WriteLine("*****************************");
                Console.WriteLine("1 -      Small square");
                Console.WriteLine("2 -      3X3 square");
                Console.WriteLine("3 -      5X4 square");
                Console.WriteLine("4 -      leftward triangle");
                Console.WriteLine("5 -      \\ through square");
                Console.WriteLine("6 -      / through square");
                Console.WriteLine("7 -      Rightward triangle");
                Console.WriteLine("8 -      Square with X through it");
                Console.WriteLine("9 -      Pyramid");
                Console.WriteLine("22 -     Exit Program");  
                Console.WriteLine("*****************************");
                

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                //telling user to enter choice for menu
                Console.Write("Choose an option from the menu (enter the number): ");
                answr = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine();

                switch (answr)
                {

                    case 1:

                        //small square
                        Console.Write("X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();
                     
                        
                        break;

                    case 2:

                        //3X3 square
                                    for (int i = 0; i < 3; i++)
                                    {
                                        for (int j = 0; j < 3; j++)
                                        {
                                            Console.Write("X");
                                        }
                                        Console.WriteLine();
                                    }

                                    Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();
                        
                        break;


                    case 3:

                        //5X4 square
                        
                                    for (int i = 0; i < 4; i++)
                                    {
                                         for (int j = 0; j < 5; j++)
                                         {
                                             Console.Write("X");
                                         }
                                         Console.WriteLine();
                                    }
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();
                        

                        break;

                    case 4:

                        //leftward triangle
                                    for (int i = 0; i < 6; i++)
                                    {
                                        for (int j = 0; j < i; j++)
                                        {
                                            Console.Write("X");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();
                        
                        break;

                    case 5:
                        // '\' square
                                    for (int i = 0; i < 5; i++)
                                    {
                                        for (int j = 0; j < 5; j++)
                                        {
                                            if (i == j)
                                            {
                                                Console.Write(" ");
                                            }

                                            else
                                                Console.Write('X');

                                        }

                                        Console.WriteLine();
                                    }
                        



                        Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();
                        
                        break;

                    case 6:

                        // '/' square
                                    for (int i = 0; i < 5; i++)
                                    {
                                        for (int j = 0; j < 5; j++)
                                        {
                                            if (4 - j == i)
                                            {
                                                Console.Write(" ");
                                            }

                                            else
                                                Console.Write('X');

                                        }

                                        Console.WriteLine();
                                    }
                                    Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();
                        
                        break;


                    case 7:
                        //Rightward triangle
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (3 - j >= i)
                                {
                                    Console.Write(" ");
                                }

                                else
                                    Console.Write('X');

                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();
                        
                        break;


                    case 8:

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (4 - j == i || j == i)
                                {
                                    Console.Write(" ");
                                }

                                else
                                    Console.Write('X');

                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();

                        break;


                         case 9:
                         int q = 3  / 2 + 1;

                        //pyramid
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                if (j >= q - i && j <= q + i)
                                {
                                    Console.Write("X");
                                }

                                else
                                Console.Write(" ");
                            }

                            

                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press Enter to clear screen...");
                        Console.ReadKey();
                        break;
                }

            }






            Console.WriteLine();
            
            
        }
    }
}
