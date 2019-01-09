using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_CompentencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            int grade = 0, readinglvl = 0, numtcntby = 0, topnum = 0, intv = -1, sum = 0, newwwint = 0;
            int[] array = new int[10];
            List<string> stringList = new List<string>();
            string oops = "";

            while (menu != -1)
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("** Enter the number coorosponding to the action you want to make.");
                Console.WriteLine("** 1. Conditionals");
                Console.WriteLine("** 2. For Loops");
                Console.WriteLine("** 3. While Loops");
                Console.WriteLine("** 4. Arrays");
                Console.WriteLine("** 5. Lists");
                Console.WriteLine("** -1. End the program.");
                Console.WriteLine("************************************************");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        Console.Write("Enter your grade: ");
                        grade = int.Parse(Console.ReadLine());
                       
                        Console.Write("Enter your reading grade level: ");
                        readinglvl = int.Parse(Console.ReadLine());

                        if (grade > 8 && grade < 13)
                        {
                            Console.Write("You are in high school "); 
                            if(grade <= readinglvl)
                            {
                                Console.WriteLine("and you read at an appropriate level.");
                            }

                            if(grade > readinglvl)
                            {
                                Console.WriteLine("and you don't read at an appropriate level. Go Study.");
                            }
                        }

                        if (grade < 9 && grade > 5)
                        {
                            Console.Write("You are in middle school ");
                            if (grade <= readinglvl)
                            {
                                Console.WriteLine("and you read at an appropriate level.");
                            }

                            if (grade > readinglvl)
                            {
                                Console.WriteLine("and you don't read at an appropriate level. Go Study.");
                            }
                        }

                        if (grade < 6 && grade > 0)
                        {
                            Console.Write("You are in elementary school ");
                            if (grade <= readinglvl)
                            {
                                Console.WriteLine("and you read at an appropriate level.");
                            }

                            if (grade > readinglvl)
                            {
                                Console.WriteLine("and you don't read at an appropriate level. Go Study.");
                            }
                        }



                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 2:

                        Console.Write("Enter a number to count by: ");
                        numtcntby = int.Parse(Console.ReadLine());

                        Console.Write("Enter a number to count up to by " + numtcntby + ": ");
                        topnum = int.Parse(Console.ReadLine());

                        for (int i = 0; i <= topnum; i = i + numtcntby)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 3:

                        Console.WriteLine("Our sum starts at 0. enter integer values to add to, and print the sum. Enter 0 to stop adding.");

                        while (intv != 0)
                        {
                            Console.Write("Enter a value: ");
                            intv = int.Parse(Console.ReadLine());

                            Console.WriteLine("New sum = " + (sum = sum + intv));
                        }

                        Console.WriteLine("Exiting loop, your final sum = " + sum);

                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 4:

                        Console.WriteLine("You have an array the size of 10 and of type int. Enter values to populate the array.");

                        for(int i = 0; i < array.Length; i++)
                        {
                            newwwint = int.Parse(Console.ReadLine());
                            array[i] = newwwint;
                            Console.WriteLine(newwwint + " successfully added");
                        }

                        Console.WriteLine("All array values added. Here they are!");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.WriteLine("index " + i + " = " + array[i]);
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 5:

                        Console.WriteLine("You have a list of type string. Enter values to add to the list. Type end to stop adding and print out your list.");

                        while(oops != "end")
                        {
                            Console.Write("Enter a string: ");
                            oops = Console.ReadLine();
                            stringList.Add(oops);
                        }
                       
                        for(int i = 0; i < stringList.Count - 1; i++)
                        {
                            Console.WriteLine("index " + i + " = " + stringList[i]);
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case -1:

                        Console.Clear();
                        Console.WriteLine("Bye Bye. Program has ended");
                        Console.ReadLine();

                        break;



                }
            }
        }
    }
}
