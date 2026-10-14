using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hand_Evaluation_2___C_
{
    internal class Card
    {
        public String Face { get; } // Card’s face ("Ace", "Deuce", ...)
        public String Suit { get; } // Card’s suit ("Hearts", "Diamonds", ...)

        // two-parameter constructor initializes card's Face and Suit
        public Card(String face, String suit)
        {
            Face = face; // initialize face of card
            Suit = suit; // initialize suit of card
        }

        // return string representation of Card
        public override String ToString() => $"{Face,2} {Suit}  ";
    }
}
