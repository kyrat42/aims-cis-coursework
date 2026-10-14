using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hand_Evaluation_2___C_
{
    internal class DeckOfCards
    {
        // create one Random object to share among DeckOfCards objects
        private static Random randomNumbers = new Random();

        private const int NumberOfCards = 52; // number of cards in a deck
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0; // index of next Card to be dealt (0-51)

        // constructor fills deck of Cards
        public DeckOfCards()
        {
            String[] faces = {"A", "2", "3", "4", "5", "6",
         "7", "8", "9", "10", "J", "Q", "K"};
            // I had to modify these because the unicode chars weren't working for me
            String[] suits = { "H",
            "D", "C",
            "S" };

            // populate deck with Card objects                         
            for (var count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }


        // shuffle deck of Cards with one-pass algorithm
        public void Shuffle()
        {
            // after shuffling, dealing should start at deck[0] again
            currentCard = 0; // reinitialize currentCard

            // for each Card, pick another random Card and swap them
            for (var first = 0; first < deck.Length; ++first)
            {
                // select a random number between 0 and 51 
                var second = randomNumbers.Next(NumberOfCards);

                // swap current Card with randomly selected Card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        // deal one Card
        public Card DealCard()
        {
            // determine whether Cards remain to be dealt
            if (currentCard < deck.Length)
            {
                return deck[currentCard++]; // return current Card in array
            }
            else
            {
                return null; // indicate that all Cards were dealt
            }
        }
    }
}
