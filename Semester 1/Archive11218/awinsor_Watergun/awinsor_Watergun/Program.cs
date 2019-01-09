using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_Watergun
{
    class Program
    {
        static void Main(string[] args)
        {
            Watergun player1 = new Watergun();
            Watergun player2 = new Watergun();

            float amount = 0;
            string choice = "";

            while (player1.isWet == false && player2.isWet == false)
            {

            
                Console.WriteLine("Player1: You are a " + (player1.capacity * 100) + "% full in the tank.\nWould you like to reload or shoot ?(\"reload\" or \"shoot\": ");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "reload":

                        player1.Reload();

                        break;


                    case "shoot":

                        Console.WriteLine("Input a value to shoot(a decimal): ");
                        amount = float.Parse(Console.ReadLine());
                        player2.isWet = player1.Shoot(amount);

                        break;


                }

                Console.WriteLine("Player2: You are a " + (player2.capacity * 100) + "% full in the tank.\nWould you like to reload or shoot ?(\"reload\" or \"shoot\": ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "reload":

                        player2.Reload();

                        break;


                    case "shoot":

                        Console.WriteLine("Input a value to shoot(a decimal): ");
                        amount = float.Parse(Console.ReadLine());
                        player1.isWet = player2.Shoot(amount);

                        break;


                }

                if (player1.isWet == true)
                {
                    Console.WriteLine("Player2 WINS!!");
                }

                if (player2.isWet == true)
                {
                    Console.WriteLine("Player1 Wins!!");
                }
                if (player2.isWet == true && player1.isWet == true)
                {
                    Console.WriteLine("You both lost. You Guys Suck.");
                }
                Console.ReadLine();
            }

            
        }
    }
}
