using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_CaesarCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            int answr = 0;

            while (answr != -1)
            {
                Console.Clear();
                menu();

                answr = int.Parse(Console.ReadLine());
                
                switch(answr)
                {

                    case 1:

                        UppercaseASCIICode();

                        break;

                    case 2:

                        LowerCase();

                        break;

                    case 3:

                        IntToChar();

                        break;
                }

            

                Console.ReadLine();

            }
        }

        static void menu()
        {
            Console.WriteLine("****************");
            Console.WriteLine("1. UpperCase");
            Console.WriteLine("2. LowerCase");
            Console.WriteLine("3. Char");
            Console.WriteLine("-1. End program.");
            Console.WriteLine("****************");
        }

        static void LowerCase()
        {
            int charint = 0;

            string alph = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Lowercase Letters");

            for (int i = 0; i < 26; i++)
            {
                Console.Write(alph[i]);

                charint = alph[i];
                Console.WriteLine(" = " + charint);

            }
            Console.WriteLine("\n\n");

        }


        static void UppercaseASCIICode()
        {
            int charint = 0;
            string ALPH = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("Uppercase Letters");

            for (int i = 0; i < 26; i++)
            {
                Console.Write(ALPH[i]);

                charint = ALPH[i];
                Console.WriteLine(" = " + charint);

            }
        }


        static void IntToChar()
        {
            char mychar = ' ';

            for (int i = 0; i < 13001; i++)
            {

                mychar = (char)i;
                Console.Write(mychar);

            }
            
        }
    }
}
