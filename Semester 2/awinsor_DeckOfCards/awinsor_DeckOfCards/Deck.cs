using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_DeckOfCards
{
    class Deck
    {
        List<Card> deck = new List<Card>();
        List<Card> discard = new List<Card>();

        public void shuffle()
        {
            deck.Add(new Card("Ace", "Spades"));
            deck.Add(new Card("Two", "Spades"));
            deck.Add(new Card("Three", "Spades"));
            deck.Add(new Card("Four", "Spades"));
            deck.Add(new Card("Five", "Spades"));
            deck.Add(new Card("Six", "Spades"));
            deck.Add(new Card("Seven", "Spades"));
            deck.Add(new Card("Eight", "Spades"));
            deck.Add(new Card("Nine", "Spades"));
            deck.Add(new Card("Ten", "Spades"));
            deck.Add(new Card("Jack", "Spades"));
            deck.Add(new Card("Queen", "Spades"));
            deck.Add(new Card("King", "Spades"));
            deck.Add(new Card("Ace",  "Diamonds"));
            deck.Add(new Card("Two",  "Diamonds"));
            deck.Add(new Card("Three", "Diamonds"));
            deck.Add(new Card("Four", "Diamonds"));
            deck.Add(new Card("Five", "Diamonds"));
            deck.Add(new Card("Six",  "Diamonds"));
            deck.Add(new Card("Seven", "Diamonds"));
            deck.Add(new Card("Eight", "Diamonds"));
            deck.Add(new Card("Nine", "Diamonds"));
            deck.Add(new Card("Ten",  "Diamonds"));
            deck.Add(new Card("Jack", "Diamonds"));
            deck.Add(new Card("Queen", "Diamonds"));
            deck.Add(new Card("King", "Diamonds"));
            deck.Add(new Card("Ace",  "Clubs"));
            deck.Add(new Card("Two",  "Clubs"));
            deck.Add(new Card("Three", "Clubs"));
            deck.Add(new Card("Four", "Clubs"));
            deck.Add(new Card("Five", "Clubs"));
            deck.Add(new Card("Six",  "Clubs"));
            deck.Add(new Card("Seven", "Clubs"));
            deck.Add(new Card("Eight", "Clubs"));
            deck.Add(new Card("Nine", "Clubs"));
            deck.Add(new Card("Ten",  "Clubs"));
            deck.Add(new Card("Jack", "Clubs"));
            deck.Add(new Card("Queen", "Clubs"));
            deck.Add(new Card("King", "Clubs"));
            deck.Add(new Card("Ace", "Hearts"));
            deck.Add(new Card("Two", "Hearts"));
            deck.Add(new Card("Three", "Hearts"));
            deck.Add(new Card("Four", "Hearts"));
            deck.Add(new Card("Five", "Hearts"));
            deck.Add(new Card("Six", "Hearts"));
            deck.Add(new Card("Seven", "Hearts"));
            deck.Add(new Card("Eight", "Hearts"));
            deck.Add(new Card("Nine", "Hearts"));
            deck.Add(new Card("Ten", "Hearts"));
            deck.Add(new Card("Jack", "Hearts"));
            deck.Add(new Card("Queen", "Hearts"));
            deck.Add(new Card("King", "Hearts"));

            Random rand = new Random();
            deck = deck.OrderBy(t => rand.Next()).ToList();


            discard.Clear();
        }

        public Card Draw()
        {
            if (deck.Count > 1)
            {
                Card dumdum = deck[deck.Count - 1];

                deck.RemoveAt(deck.Count - 1);

                return dumdum;
            }

            else
            return null;
        }

        public void Discard(Card c)
        {
            discard.Add(c);
        }

        public void PrintDeck()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                deck[i].print();
            }
        }

        public void PrintDiscard()
        {
            for (int i = 0; i < discard.Count; i++)
            {
                discard[i].print();
            }
        }

    }
}
