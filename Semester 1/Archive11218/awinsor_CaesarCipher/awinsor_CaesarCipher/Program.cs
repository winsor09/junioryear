using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrstring = "";
            int shift = 0, menu = 0;
            while (menu != -1)
            {

                Console.Clear();
                Console.WriteLine("*********************");
                Console.WriteLine("1. Encrypt");
                Console.WriteLine("2. Decrypt");
                Console.WriteLine("3. Brute Force Decrypt");
                Console.WriteLine("-1. End Program.");
                Console.WriteLine("*********************\n");
                menu = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (menu)
                {
                    case 1:
                        Console.Write("Enter a string to encrypt: ");
                        usrstring = Console.ReadLine();
                        

                        Console.Write("\nEnter a shift value: ");
                        shift = int.Parse(Console.ReadLine());
                        Console.Write("\nYour encrypted code is: ");

                        Encrypt(usrstring, shift);

                        break;

                    case 2:

                        Console.Write("Enter a string to decrypt: ");
                        usrstring = Console.ReadLine();
                       

                        Console.Write("\nEnter the original shift value: ");
                        shift = int.Parse(Console.ReadLine());

                        Decrypt(usrstring, shift);

                        break;

                    case 3:

                        Console.Write("Enter a string to decrypt by brute force: ");
                        usrstring = Console.ReadLine();
                        

                        BruteForce(usrstring);
                        break;
                }
                Console.ReadLine();
            }
        }

        static void Encrypt(string usrstring, int shift)
        {
            int sum = 0;



            for (int i = 0; i < usrstring.Length; i++)
            {

                int myint = usrstring[i];


                sum = myint + shift;

                if (sum > 122)
                {
                    sum = sum - 26;
                }
                if (sum < 97)
                {
                    sum = sum + 26;
                }


                char encryption = (char)sum;
                Console.Write(encryption);
            }

        }

        static void Decrypt(string usrstring, int shift)
        {

            int sum = 0;

            Console.Write("\nYour decrypted word is: ");
            for (int i = 0; i < usrstring.Length; i++)
            {

                int myint = usrstring[i];


                sum = myint - shift;

                if (sum > 122)
                {
                    sum = sum - 26;
                }
                if (sum < 97)
                {
                    sum = sum + 26;
                }


                char encryption = (char)sum;
                Console.Write(encryption);
            }



        }

        static void BruteForce(string usrstring)
        {

            int sum = 0;

                for (int i = 0; i < 25; i++)
                {
                    for(int j = 0; j < usrstring.Length; j++)
                    {

                        int myint = usrstring[j];


                        sum = myint - i;

                        if (sum > 122)
                        {
                            sum = sum - 26;
                        }
                        if (sum < 97)
                        {
                            sum = sum + 26;
                        }


                        char encryption = (char)sum;
                        Console.Write(encryption);
                    }

                    Console.WriteLine();
                }

        }
    }
}
