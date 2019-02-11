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


            Console.WriteLine();
            Random rand = new Random();
            QueueGeneric<Currencies> currencies = new QueueGeneric<Currencies>();

            for (int i = 0; i < 10; i++)
            {
                currencies.EnQueue(new Currencies(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100)));

            }

            return;


            int val = 0;
            int menu = 0;
            QueueGeneric<float> myqueuef = new QueueGeneric<float>();
            QueueGeneric<string> myqueues = new QueueGeneric<string>();
            QueueGeneric<int> myqueuei = new QueueGeneric<int>();

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
                        int myint = myqueuei.DeQueue();
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
                        myqueuei.EnQueue(val);

                        Console.ReadLine();

                        break;

                    case 3:

                        Console.WriteLine(myqueuei.Peek());

                        Console.ReadLine();

                        break;

                    case 4:

                        myqueuei.Print();

                        Console.ReadLine();

                        break;
                }


            }

        }
    }
}
