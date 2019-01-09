using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowYouTry_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random rand = new Random();
            List<int> mylist = new List<int>();
            List<int> mylist_2 = new List<int>();
            int q = 1, e = 0;

            for (int i = 0; i < 10; i++)
            {
                mylist.Add(rand.Next());
                Console.WriteLine(mylist[i]);
            }

            Console.WriteLine();
            
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            while (q != 0)
            {
                
                q = int.Parse(Console.ReadLine());
                mylist_2.Add(q);
               
                
            }

            Console.WriteLine();

            for (int w = 0; w < mylist_2.Count - 1; w++)
            { 
                Console.Write(mylist_2[w] + ". ");
            }
            */

            int[] myArray = new int[10];
            List<int> mylist = new List<int>() {0,1,2,3,4,5,6,7,8,9};

            for (int i = mylist.Count - 1; i > 10; i--)
            {
                mylist.RemoveAt(i);
                
            }

            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i;
            }



            Console.WriteLine();
            Console.WriteLine("Please press any key to continue...");

            Console.ReadKey();
        }
    }
}
