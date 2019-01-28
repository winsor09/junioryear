using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_awinsor
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            int menu = 0;
            Queue myqueue = new Queue();


            while (menu != 5)
            {
                Console.WriteLine("1 - DeQueue");
                Console.WriteLine("2 - EnQueue");
                Console.WriteLine("3 - Peek");
                Console.WriteLine("4 - Print");
                Console.WriteLine("5 - End");

                Console.Write("\n\nPlease Choose an Option from the menu above: ");

                menu = int.Parse(Console.ReadLine());



                switch (menu)
                {
                    case 1:
                        int myint = myqueue.DeQueue();
                        Console.WriteLine(myint);
                        if (myint == -1)
                        {
                            Console.WriteLine("There are no numbers in queue. please choose another option from the menu.");
                        }
                        Console.ReadLine();

                        break;

                    case 2:

                        Console.Write("Please choose a number to enqueue to the queue: ");
                        val = int.Parse(Console.ReadLine());
                        myqueue.EnQueue(val);

                        Console.ReadLine();

                        break;

                    case 3:

                        Console.WriteLine(myqueue.Peek());

                        Console.ReadLine();

                        break;

                    case 4:

                        myqueue.Print();

                        Console.ReadLine();

                        break;
                }


            }

        }
    }
}
