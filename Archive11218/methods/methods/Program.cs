using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu
            int answr = 0;
            while( answr != 4)
            {
                Console.Clear();
                Console.WriteLine("*************************************");
                Console.WriteLine("1 - Add 5 + 6, and print results.");
                Console.WriteLine("2 - Add 11 + 13, and print results.");
                Console.WriteLine("3 - Add 3 + 9, and print results.");
                Console.WriteLine("4 - Exit Program");
                Console.WriteLine("*************************************");

                Console.WriteLine();
                Console.Write("Enter an option from above: ");
                answr = int.Parse(Console.ReadLine());

                    switch (answr)
                    {
                        case 1:

                            AddFiveSix();
                            Console.ReadLine();
                            break;

                        case 2:
                            AddElevenThirteen();
                            Console.ReadLine();
                            break;
                        
                        case 3:
                            AddThreeNine();
                            Console.ReadLine();
                            break;
                    }

            }

        }
        static void AddFiveSix()
        {

            Console.WriteLine("5 + 6 = " +  (5 + 6));

        }

        static void AddElevenThirteen()
        {
            Console.WriteLine("11 + 13 = " + (11 + 13));

        }

        static void AddThreeNine()
        {
            Console.WriteLine("3 + 9 = " + (3 + 9));
        }
    }
}
