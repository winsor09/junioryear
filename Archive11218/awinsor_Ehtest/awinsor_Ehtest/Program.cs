using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_Ehtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = 0;
            int num = 0;

            Console.Write("Please enter a number to divide : ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number to divide by : ");
            R = int.Parse(Console.ReadLine());

            
            Radix(num, R);


            Console.ReadLine();
        }

        static void Radix(int num, int R)
        {
            int r = 0;
            int q = 0;

            q = num / R;
            r = num % R;
            
            
            if (q != 0)
            {
                Radix(q, R);
            }

            char c = (char)(r + '0');
            
            Console.Write(c);


        }
    }
}
