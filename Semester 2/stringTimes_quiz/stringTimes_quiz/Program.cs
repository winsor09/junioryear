using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTimes_quiz
{
    class Program
    {
        static void Main(string[] args)
        {

            //string usrwrd = "";
            //int times = 0;

            //Console.WriteLine("Please enter a string that you would like to output: ");
            //usrwrd = Console.ReadLine();

            //Console.WriteLine("Please enter the number of times you would like to output your string: ");
            //times = int.Parse(Console.ReadLine());

            Console.WriteLine(stringTimes("Hi", 2));
            Console.WriteLine(stringTimes("Hi", 3));
            Console.WriteLine(stringTimes("Hi", 1));


            Console.ReadLine();

        }

        public static string stringTimes (string usrwrd, int times)
        {
            string v = "";
            for (int i = 0; i < times; i++)
            {
                 v = v + usrwrd;
            }
            return v;
            
        }
    }
}
