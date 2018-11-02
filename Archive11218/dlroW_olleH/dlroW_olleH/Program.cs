using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlroW_olleH
{
    class Program
    {
        static void Main(string[] args)
        {
            string hllwrld = "Hello World";

            char[] inst = hllwrld;

            for(int i = 0; i <= hllwrld.Length; i++)
            {
                hllwrld[i] = inst[inst.Length - i];
            }

            Console.WriteLine(hllwrld);

        }
    }
}
