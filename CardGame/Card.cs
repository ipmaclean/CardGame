using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public string Suit { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; } = "red_back.png";
        public bool IsFaceUp { get; set; } = false;

        public Card(int value, string suit)
        {
            Value = value;

            switch (value)
            {
                case 1:
                    Name = "Ace";
                    break;
                case 11:
                    Name = "Jack";
                    break;
                case 12:
                    Name = "Queen";
                    break;
                case 13:
                    Name = "King";
                    break;
                default:
                    Name = value.ToString();
                    break;
            }

            Suit = suit;

            if (value != 10)
            {
                FrontImage = string.Format("{0}{1}.png", Name[0], Suit[0]);
            }
            else
            {
                FrontImage = string.Format("10{0}.png", Suit[0]);
            }   
        }
    }
}
