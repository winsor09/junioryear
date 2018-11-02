using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string plndrm = "";

            Console.WriteLine("Please type a sentence out so it can be checked if it's a palindrome.");
            plndrm = Console.ReadLine();

            plndrm = plndrm.Replace(" ", "").Replace(".", "").Replace("'", "").Replace(",", "").Replace(";", "").Replace("!", "").Replace("?", "").Replace("\"", "").Replace(":", "").Replace("(", "").Replace(")", "").Replace("%", "").Replace("-", "").Replace("/", "").Replace("$", "");
            plndrm = plndrm.ToLower();
            
            for(int i = 0; i < plndrm.Length; i++)
            {
                if (plndrm[i] != plndrm[plndrm.Length - 1 - i ])
                {
                    i = plndrm.Length - 1;
                    Console.WriteLine("This is not a palindrome.");
                }

                else if (plndrm[i] == plndrm[plndrm.Length - 1 - i])
                {
                    if (i == plndrm.Length - 1)
                    {
                        Console.WriteLine("This is infact a palindrome.");
                    }

                }

                
            }

            Console.ReadLine();
        }
    }
}
