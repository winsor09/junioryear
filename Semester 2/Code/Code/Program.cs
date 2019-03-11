using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Splosion("bite");

            Console.ReadLine();
        }

        static void Splosion(string splosh)
        {
            splosh.ToList();
            for (int i = 0; i < splosh.Count() + 1; i++)
            {
                for (int ji = 0; ji < i; ji++)
                {
                    Console.Write(splosh[ji]);
                }

            }
        }
    }
}
