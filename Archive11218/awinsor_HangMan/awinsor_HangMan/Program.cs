using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_HangMan
{
    class Program
    {
        static void Main(string[] args)
        {

            

            bool correct = true;
            char gss;
            int numgss = 6;
            Random rand = new Random();
            


            //random array of words
            string[] Array = new string[20];
            Array[0] = "unarmed";
            Array[1] = "string";
            Array[2] = "business";
            Array[3] = "rude";
            Array[4] = "object";
            Array[5] = "nice";
            Array[6] = "pets";
            Array[7] = "deserted";
            Array[8] = "outstanding";
            Array[9] = "uppity";
            Array[10] = "impossible";
            Array[11] = "puzzling";
            Array[12] = "ignore";
            Array[13] = "riddle";
            Array[14] = "mailbox";
            Array[15] = "grain";
            Array[16] = "love";
            Array[17] = "punishment";
            Array[18] = "battle";
            Array[19] = "courageous";
            

            string wrd = Array[rand.Next(0, 20)];
            
            List<char> gss_ = new List<char>();

            do 
            {
               
                Console.Clear();

                Console.WriteLine("THIS IS HANGMAN. you have 6 guesses.");
                Console.WriteLine();
                correct = true;

                for (int i = 0; i < wrd.Length; i++)
                {
                    if (gss_.Contains(wrd[i]))
                    {
                        Console.Write(wrd[i]);
                    }
                    else
                    {
                        Console.Write("_");
                        correct = false;
                    }

                }

                if (correct == false)
                {
                    Console.WriteLine();

                    Console.WriteLine("-" + numgss + " guesses left.");

                    Console.Write("Guessed Characters: ");
                    for (int i = 0; i < gss_.Count(); i++)
                    {
                        Console.Write(gss_[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine();

                    //promting user to guess
                    Console.WriteLine("Guess:");
                    int j = 0;
                    gss = char.Parse(Console.ReadLine());
                    gss_.Add(gss);


                    if (!wrd.Contains(gss))
                    {
                        numgss--;
                    }

                    for (int i = 0; i < wrd.Length; i++)
                    {
                        if (gss_.Contains(wrd[i]))
                        {
                            Console.Write(wrd[i]);
                        }
                        else
                        {
                            Console.Write("_");
                        }

                    }


                }

                if(correct == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("You won.");
                    Console.ReadLine();
                }

                if (numgss == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("You suck. You lost at the easiest game in the world. \nIt's litteraly a child's game. \nAND.YOU.LOST.\nThat's just how much you suck at life.\nBu-Bye.");
                    Console.ReadLine();
                }


            }
            while(numgss > 0 && correct == false);





        }
    }
}
