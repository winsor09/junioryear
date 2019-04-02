using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsorquizzzzzzzz
{
    class Program
    {
        static void Main(string[] args)
        {

            string bit = "hello";

            StringBit(bit);
            Console.ReadLine();
        }

        static void StringBit(string bit)
        {

            for (int i = 0; i < bit.Length; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write(bit[i]);
                }
            }

        }
    }
}
