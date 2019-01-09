using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riders
{
    class Program
    {
        static void Main(string[] args)
        {
            int answr = 0;
            int selectedseat = 0;

            int[] seats = new int[10]{ -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

            Random rand = new Random() ;
            while (answr != 4)
            {
                //making program neat
                Console.Clear();
                //menu
                Console.WriteLine("1 -      Put rider in random available seat.");
                Console.WriteLine("2 -      List available seats.");
                Console.WriteLine("3 -      Start ride, print out how many people were on the ride.");
                Console.WriteLine("4 -      exit program.");

                //promting user for an option
                Console.WriteLine();
                Console.Write("Enter a number to choose an option from the menu: ");
                answr = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                switch (answr)
                {
                    //finding an empty seat for a rider
                    case 1:
                        bool foundseat = false;

                        while (foundseat == false)
                        {
                            selectedseat = rand.Next(0, 10);

                            if (seats[selectedseat] == -1)
                            {
                                seats[selectedseat] = 1;
                                foundseat = true;

                                Console.WriteLine("Seat has been found. rider has been placed in the seat");
                            }
                            
                            
                        
                        }

                        Console.ReadLine();
                        break;

                    //outputing if seats are emtpy or taken
                    case 2:

                        Console.WriteLine("***  =  TAKEN");
                        Console.WriteLine("|   |  =  EMPTY");
                        Console.WriteLine();

                        int s = 1;
                        for(int i = 0; i < 10; i++)
                        {
                            

                            if (seats[i] == -1)
                            {
                                Console.WriteLine("Seat " + s + ", is EMPTY.|   |");
                                Console.WriteLine();
                            }


                            else
                            {
                                Console.WriteLine("Seat " + s + ", is TAKEN  ***");
                                Console.WriteLine();
                            }

                            s++;
                        }

                        Console.ReadLine();
                        break;
                  
                    //telling user ride has started and how many riders there are
                    case 3:

                        int ppl = 0;

                        Console.WriteLine("The ride has started.");

                        for (int i = 0; i < 10; i++)
                        {
                            if (seats[i] == -1)
                                ppl = ppl + 0;

                            else
                                ppl++;

                        }

                        Console.WriteLine("There are " + ppl + " people on the bus ride.");


                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}
