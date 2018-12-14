using System;
using System.Collections.Generic;

namespace CSP.Dart
{
    public class CardDemo
    {
        public static void Run()
        {
            var deck = new Deck();

            deck.PrintCards();
        }
    }

    public class Deck
    {
        public List<Card> cards { get; set; }

        public Deck()
        {
            this.cards = new List<Card>();

            foreach (var suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (var rank in (Rank[])Enum.GetValues(typeof(Rank)))
                {
                    this.cards.Add(new Card(suit, rank));
                }
            }
        }

        public void PrintCards()
        {
            foreach (var card in this.cards)
            {
                Console.WriteLine($"{card.Rank.ToString()} of {card.Suit.ToString()}");
            }
        }
    }

    public class Card
    {
        public Suit Suit { get; set; }

        public Rank Rank { get; set; }

        public Card(Suit suit, Rank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }
    }

    public enum Suit
    {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    public enum Rank
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}