using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_DeckOfCards
{
    class Card
    {
        public string suit = "";
        public string face = "";

        public Card(string suit,string face)
        {
            this.suit = suit;
            this.face = face;
        }

        public void print()
        {
            Console.WriteLine("-----------------\n|  " + face + " of " + suit + "  |\n-----------------");
        }
    }
}
