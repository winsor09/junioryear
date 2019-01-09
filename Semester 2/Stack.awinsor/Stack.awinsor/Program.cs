using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.awinsor
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            int menu = 0;
            stack mystack = new stack();


            while (menu != 5)
            {
                Console.WriteLine("1 - Pop");
                Console.WriteLine("2 - Push");
                Console.WriteLine("3 - Peek");
                Console.WriteLine("4 - Print");
                Console.WriteLine("5 - End");

                Console.Write("\n\nPlease Choose an Option from the menu above: ");

                menu = int.Parse(Console.ReadLine());



                switch (menu)
                {
                    case 1:

                        Console.WriteLine(mystack.Pop());
                        Console.ReadLine();

                        break;

                    case 2:

                        Console.Write("Please choose a number to push to the stack: ");
                        val = int.Parse(Console.ReadLine());
                        mystack.Push(val);

                        Console.ReadLine();

                        break;

                    case 3:

                        Console.WriteLine(mystack.Peek());

                        Console.ReadLine();

                        break;

                    case 4:

                        mystack.Print();

                        Console.ReadLine();

                        break;
                }

                
            }
            
        }
    }
}
