using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck : Hand
    {
        public Deck(bool shuffled)
        {
            Cards = new List<Card>();

            var suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };

            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Cards.Add(new Card(i, suit));
                }
            }

            if (shuffled)
            {
                Shuffle();
            }
        }
    }
}
