using System;
using System.Collections.Generic;

namespace labb16
{
    // Enums
    public enum GameStatus
    {
        Won, Lost, Playing, Tie, BlackJack
    }
    public enum SuitType
    {
        Club, Diamond, Heart, Spade
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Card
    {
        public int Value { get; set; }
        public SuitType suit { get; set; }
        public int BlackJackValue { get; set; }


    }

    class Deck
    {
        public int _nrOfDecks;
        public List<Card> _Cards = new List<Card>();
    }

    class Player
    {
        public Card LastDrawnCard { get; set; }
        public int LowValue { get; set; }
        public int HighValue { get; set; }
        public int BestValue { get; set; }
    }
}
