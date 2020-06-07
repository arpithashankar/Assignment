using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deckofcards
{
  
      class Program
        {
            static void Main(string[] args)
            {
                Deck mydeck = new Deck();
           
            foreach (Card c in mydeck.Cards)
            {
                Console.WriteLine(c);
                

            }
          

           






        }
    }

    class Deck
    {
        Card[] cards = new Card[52];
        string[] numbers = new string[] {"A", "2", "3", "4", "5", "6", "7", "8", "9","10", "J", "Q", "K" };
        public Deck()
        {
            int i = 0;
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Clubs, s);
                i++;

            }
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Spades, s);
                i++;

            }

        
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Hearts, s);
                i++;

            }
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Diamonds, s);
                i++;

            }
        }

        public Card[] Cards
        {
            get
            {
                return cards;


            }
        }
    }

    enum Suits
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }

    class Card
    {
        protected Suits suit;
        protected string cardvalue;
        public Card()
        {
        }
        public Card(Suits suit2, string cardvalue2)
        {
            suit = suit2;
            cardvalue = cardvalue2;
        }
        public override string ToString()
        {
            return string.Format("{0} of {1}", cardvalue, suit);
        }


       
    }

}
