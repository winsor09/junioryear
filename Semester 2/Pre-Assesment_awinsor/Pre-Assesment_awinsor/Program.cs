using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Assesment_awinsor
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            while(menu != 9)
            {

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("1 - Print Hello World");
                Console.WriteLine("2 - Add two user input integers together");
                Console.WriteLine("3 - Calulcate the area of a circle given just the radius from user input");
                Console.WriteLine("4 - Calculate the area of a triangle given the length of all three sides from user input");
                Console.WriteLine("5 - Given an integer n from user input, draw a square using the ASCII character 'X' that has the width of n");
                Console.WriteLine("6 - Given an integer n from user input, draw a hollow square using the ASCII character 'X' that has a width of n");
                Console.WriteLine("7 - Given two integer variables from user input, swap their values");
                Console.WriteLine("8 - Reverse a string from user input using a for loop");
                Console.WriteLine("9 - End the program");




                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        Console.WriteLine("Hello World");
                        break;

                    case 2:

                        int u1 = 0;
                        int u2 = 0;

                        Console.WriteLine("User input 1: ");
                        u1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("User input 2: ");
                        u2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(u1 + u2);

                        break;

                    case 3:

                        int r = 0;
                        Console.WriteLine("Please enter a value for a radius of a circle: ");
                        r = int.Parse(Console.ReadLine());
                        Console.WriteLine(Math.PI*Math.Pow(r, 2));
                        break;

                    case 4:

                        int a = 0;
                        int b = 0;
                        int c = 0;
                    
                        Console.WriteLine("Please enter a value for side_a of the triangle: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter a value for side_b of the triangle: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter a value for side_c of the triangle: ");
                        c = int.Parse(Console.ReadLine());

                        int sqrt = ((a + b + c) / 2);

                        Console.WriteLine(Math.Sqrt(sqrt * (sqrt - a)*(sqrt - b)*(sqrt - c)));
                        break;

                    case 5:

                        int n = 0;

                        Console.WriteLine("User input 1: ");
                        n = int.Parse(Console.ReadLine());


                        for (int i = 0; i < n ; i++)
                        {
                            for (int j = 0; j < n ; j++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 6:

                        int q = 0;

                        Console.WriteLine("User input 1: ");
                        q = int.Parse(Console.ReadLine());


                        for (int i = 0; i < q; i++)
                        {
                            for (int j = 0; j < q; j++)
                            {
                                if (i == 0)
                                {
                                    Console.Write("X");
                                }
                                else if (i != 0 && i != q - 1 && (j == 0 || j == q - 1))
                                {
                                    Console.Write("X");
                                }
                                else if (i == q - 1)
                                {
                                    Console.Write("X");
                                }
                                else
                                { Console.Write(" "); }
                                   

                            }
                            Console.WriteLine();
                        }
                        break;

                    case 7:

                        int us1 = 0;
                        int us2 = 0;
                        int temp = 0;

                        Console.WriteLine("User input 1: ");
                        us1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("User input 2: ");
                        us2 = int.Parse(Console.ReadLine());

                        temp = us1;
                        us1 = us2;
                        us2 = temp;

                        Console.WriteLine("User input 1: " + us1);
                        Console.WriteLine("User input 1: " + us2);

                        break;

                    case 8:

                       
                        string plndrm = "";
                  

                        Console.WriteLine("Please type a sentence.");
                        plndrm = Console.ReadLine();
                        
                        
                        for (int i = plndrm.Length -1; i >= 0; i--)
                        {

                            Console.Write(plndrm[i]);


                        }
                        break;

                
                }
            }

        }
    }
}
