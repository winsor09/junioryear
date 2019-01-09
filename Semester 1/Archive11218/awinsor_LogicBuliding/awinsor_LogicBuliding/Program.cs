using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_LogicBuliding
{
    class Program
    {
        static void Main(string[] args)
        {


            //create an int that counts how many times the user has guessed
            int numguess = 0;

            //set an int to a random between 0 - 1000
            Random rand = new Random();
            int rlnum = rand.Next(0, 1000);

            //create an int for the user to input guess into
            int usrgss = 0;
            
            //promt user to guess a number between 0 - 1000
            Console.Write("Please guess anumber between 0 - 1000: ");

            //create a WHILE LOOP until the users guess is equal to the correct number
            while (usrgss != rlnum)
            {

                
                //accept user input
                usrgss = int.Parse(Console.ReadLine());

                //if statement that if the guess is too low outputs that user's guess is "too low guess again"
                if (usrgss < rlnum)
                {
                    Console.Clear();
                    Console.WriteLine("Your guess was too low, guess again(0 - 1000).");
                }

                //if statement that if the guess is too high outputs that user's guess is "too high guess again"
                if (usrgss > rlnum)
                {
                    Console.Clear();
                    Console.WriteLine("Your guess was too high, guess again(0 - 1000).");
                }
               
                //else statement telling the user if they guessed the number exactly right
                if(usrgss == rlnum)
                {
                    Console.Clear();
                    Console.WriteLine("You guessed the number exactly right. Good job.");
                }

                //blank line
                Console.WriteLine();
                
                //add 1 to the int counting guesses
                numguess++;


            }

            //outside of the loop out put how many times it to the user to guess the correct number
            Console.WriteLine("You guessed " + numguess + " times.");
            
            //pause the system until user hits any key
            Console.ReadLine();

            
             
        }
    }
}
