using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame
{
    public class Hand
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public void Shuffle()
        {
            var shuffledCards = Cards.OrderBy(a => Guid.NewGuid());
            Cards = shuffledCards.ToList();
        }

        public Card Deal(bool faceUp)
        {
            Card currentCard = Cards.Last();
            Cards.Remove(currentCard);

            currentCard.IsFaceUp = faceUp;

            return currentCard;
        }
    }
}

