using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        public Card(string stringVals, string suits, int vals)
        {
            stringVal = stringVals;
            suit = suits;
            val = vals;
        }
    }
    class Deck
    {
        public List<Card> cards = new List<Card>();
        public string[] suits= {"Spades","Clubs","Diamonds","Hearts"};
        public string[] ranks= {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        public Deck()
        {
            Reset();
        }
        public Card Deal()
        {
            Card deal = cards[0];
            cards.RemoveAt(0);
            return deal;
        }
        public void Reset()
        {
            cards = new List<Card>();
            foreach (string suit in suits)
            {
                int value = 0;
                foreach(string rank in ranks)
                {
                    cards.Add(new Card(rank, suit, ++value));
                }
            }
        }
        public Deck Shuffle()
        {
            int shuff = cards.Count;
            Card lastCard;
            int randomNum;
            Random rand = new Random();
            while (shuff>0)
            {
                randomNum = rand.Next(0,52);
                lastCard = cards[--shuff];
                cards[shuff] = cards[randomNum];
                cards[randomNum] = lastCard;
            }
            return this;
        }
        public void Write()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine($"This is the {card.stringVal} of {card.suit}");
            }
        }
    }
    class Player
    {
        public string Name;
        public List<Card> Hand = new List<Card>();
        public Player(string name)
        {
            this.Name = name;
        }
        public Card draw(Deck deck)
        {
            Card hand = deck.Deal();
            Hand.Add(hand);
            return hand;
        }
        public Card Discard(int index)
        {
            if (Hand.Count > index)
            {
                Card discard = Hand[index];
                Hand.RemoveAt(index);
                return discard;
            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            // myDeck.Write();
            // myDeck.Shuffle();
            // myDeck.Write();
            // myDeck.Reset();
            // myDeck.Write();
            myDeck.Shuffle();
            // Console.WriteLine(myDeck.Deal().stringVal);
            // Console.WriteLine(myDeck.Deal().stringVal);
            // Console.WriteLine(myDeck.cards.Count);
            Player Richard = new Player("Richard");
            Richard.draw(myDeck);
            Richard.draw(myDeck);
            Console.WriteLine(Richard.Discard(0).val);
            Console.WriteLine(Richard.Discard(0).val);
        }
    }
}
