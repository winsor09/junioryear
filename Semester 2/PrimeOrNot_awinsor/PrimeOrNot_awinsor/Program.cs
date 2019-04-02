using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNot_awinsor
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 7;

            Console.WriteLine(CheckForPrime(n));
            
            Console.ReadLine();

        }

        static bool CheckForPrime(int n, int divisor = 2)
        {
            if (n%divisor == 0)
            {
                return false;
            }

            if (divisor == (n-1))
            {
                return true;
            }

            return CheckForPrime(n, divisor +1);
        }
    }
}
