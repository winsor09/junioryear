using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            while (menu != -1)
            {
                Console.Clear();
                Console.WriteLine("***************************");
                Console.WriteLine("1. Prints 3X3");
                Console.WriteLine("2. Prints 3X6");
                Console.WriteLine("3. Prints 6X3");
                Console.WriteLine("-1. End Program.");
                Console.WriteLine("***************************");

                Console.Write("\n\nChoose an option from the menu to choose what happens: ");
                menu = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");

                switch(menu)
                {

                    case 1:

                        ThreeeByThree(3, 3);
                        Console.ReadLine();

                        break;

                    case 2:

                        ThreeeByThree(3, 6);
                        Console.ReadLine();

                        break;

                    case 3:

                        ThreeeByThree(6, 3);
                        Console.ReadLine();

                        break;
                }

            }
        }

        static void ThreeeByThree(int size, int size_)
        {
            for(int i = 0; i < size; i++ )
            {
                for(int j = 0; j < size_; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        


    }
}
