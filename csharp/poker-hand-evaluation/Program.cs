// Kyra Thomas
// 12/3/2023
// Poker Hand Evaluation
// 2nd attempt after forgetting everything I know over break

using Poker_Hand_Evaluation_2___C_;

class EvaluatePokerHand
{
    private static DeckOfCards myDeckOfCards;
    static void Main()
    {
        myDeckOfCards = new DeckOfCards();
        myDeckOfCards.Shuffle();

        /* test code to display all cards in order 
        for (var i = 0; i < 52; i++)
        {
            Console.Write($"{myDeckOfCards.DealCard(), -19}");
            if ((i + 1) % 4 == 0)
                Console.WriteLine();
        }
        */

        Card[] hand1 = new Card[5];
        Card[] hand2 = new Card[5];

        // sampleHand is hardcoded for testing
        Card[] sampleHand = new Card[5];

        // hardcoding sampleHand
        sampleHand[0] = new Card("2", "H");
        sampleHand[1] = new Card("6", "S");
        sampleHand[2] = new Card("3", "H");
        sampleHand[3] = new Card("4", "C");
        sampleHand[4] = new Card("5", "D");

        DealHand(hand1);
        DealHand(hand2);

        Console.Write("Left Hand:  ");
        PrintHand(hand1);
        Console.WriteLine();
        Console.Write("Right Hand: ");
        PrintHand(hand2);

        Console.WriteLine("\n\nHand values:");
        Console.WriteLine("Left: " + handResultString(hand1));
        Console.WriteLine("Right: " + handResultString(hand2));

        Console.WriteLine("\n\nResults:");
        if (handResult(hand1) < handResult(hand2))
            Console.WriteLine("Left hand is better.");
        else if (handResult(hand2) < handResult(hand1))
            Console.WriteLine("Right hand is better.");
        else
            Console.WriteLine("Tie");

    }

    static void DealHand(Card[] hand)
    {
        for (int i = 0; i < 5; i++)
        {
            hand[i] = myDeckOfCards.DealCard();
        }
    }

    static void PrintHand(Card[] hand)
    {
        foreach (Card card in hand)
        {
            Console.Write(card);
        }
    }

    // returns the number of pairs in the hand
    // 6 = 4 of a kind
    // 4 = full house
    // 3 = 3 of a kind
    // 2 = 2 pairs
    // 1 = 1 pair
    // use this in a switch statement
    static int HandPairs(Card[] hand)
    {
        int[] count = new int[5];

        for (int i = 0; i < 5 - 1; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (hand[i].Face == hand[j].Face)
                    count[i]++;
            }
        }

        int sum = 0;
        for (int i = 0; i < 5; i++)
            sum += count[i];

        return sum;
    }

    static bool isFlush(Card[] hand)
    {
        for (int i = 0; i < 5 - 1; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (hand[i].Suit != hand[j].Suit)
                    return false;
            }
        }

        return true;
    }

    static int faceValue(Card card)
    {
        int faceValue;
        
        if (Int32.TryParse(card.Face, out faceValue))
            return faceValue;
        else
        {
            switch (card.Face)
            {
                case ("J"):
                    return 11;
                case ("Q"):
                    return 12;
                case ("K"):
                    return 13;
                case ("A"):
                    return 14;
                default:
                    return -1;
            }
        }
    }

    static int findHighest(Card[] hand)
    {
        int highest = faceValue(hand[0]);

        for (int i = 1; i < 5; i++)
        {
            if (faceValue(hand[i]) > highest)
                highest = faceValue(hand[i]);
        }

        return highest;
    }

    static int findLowest(Card[] hand)
    {
        int lowest = faceValue(hand[0]);

        for (int i = 1; i < 5; i++)
        {
            if (faceValue(hand[i]) < lowest)
                lowest = faceValue(hand[i]);
        }

        return lowest;
    }

    static bool isStraight(Card[] hand)
    {
        bool foundNext = false, contains2 = false, containsA = false;
        int lowest = findLowest(hand);
        int highest = findHighest(hand);

        int[] handValues = new int[hand.Length];

        // does the hand contain an ace?
        for (int i = 0; i < 5; i++)
        {
            if (hand[i].Face == "A")
            {
                containsA = true;
                break;
            }
        }

        // if the hand contains an ace
        // determine if the ace will be  a 1 or a 14
        // since the default for a is 14, if there is a 2, the a will be overridden as a 1 for the purposes of a straight
        if (containsA)
        {
            // does the hand contain a 2?
            for (int i = 0; i < 5; i++)
            {
                if (hand[i].Face == "2")
                {
                    contains2 = true;
                    break;
                }
            }

            if (contains2)
                lowest = 1;
        }

        // probably need to convert the hand into an int array of the faceValue before running the code below so it 
        // doesn't get messed up by the ace if applicable
        for (int i = 0; i < 5; i++)
        {
            handValues[i] = faceValue(hand[i]);
            if (hand[i].Face == "A" && contains2)
                handValues[i] = 1;
        }

        // this isn't working right
        for (int i = 0; i < 5 - 1; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (handValues[j] == lowest + 1)
                {
                    foundNext = true;
                    lowest++;        // incrementing to check for the next num in sequence
                }
            }
            if (!foundNext)
                break;
        }

        return foundNext;
    }

    static int handResult(Card[] hand)
    {
        if (HandPairs(hand) == 6)
            return 1;
        else if (isStraight(hand))
            return 2;
        else if (isFlush(hand))
            return 3;
        else if (HandPairs(hand) == 4)
            return 4;
        else if (HandPairs(hand) == 3)
            return 5;
        else if (HandPairs(hand) == 2)
            return 6;
        else if (HandPairs(hand) == 1)
            return 7;
        else
            return 8;

        return 0;
    }

    static string handResultString(Card[] hand)
    {
        switch (handResult(hand))
        {
            case 1:
                return "A full house";
                break;
            case 2:
                return "A straight";
                break;
            case 3:
                return "A flush";
                break;
            case 4:
                return "Four of a kind";
                break;
            case 5:
                return "Three of a kind";
                break;
            case 6:
                return "Two pairs";
                break;
            case 7:
                return "One pair";
                break;
            default:
                return "None";
        }
    }
}