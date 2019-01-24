using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck mydeck = new Deck();
            Card mycard = new Card("","");

            int menu = 0;

            while(menu != 6)
            {
                Console.WriteLine("1 - Shuffle");
                Console.WriteLine("2 - Draw Card");
                Console.WriteLine("3 - Print Discard");
                Console.WriteLine("4 - Print Deck");
                Console.WriteLine("5 - Discard Card");
                Console.WriteLine("6 - Quit");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        mydeck.shuffle();

                        break;

                    case 2:

                        mycard = mydeck.Draw();

                        break;

                    case 3:

                        mydeck.PrintDiscard();

                        break;

                    case 4:

                        mydeck.PrintDeck();

                        break;

                    case 5:

                        mydeck.Discard(mycard);

                        break;




                }

               
            }

        }
    }
}
