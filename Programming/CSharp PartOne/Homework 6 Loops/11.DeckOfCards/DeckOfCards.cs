using System;

class DeckOfCards
{
    static void Main()
    {
        string card = "of";
        for (int dye = 1; dye <= 4; dye++)
        {

            string color = string.Empty;
            switch (dye)
            {
                case 1:
                    color = card + " " + "clubs"; break;
                case 2:
                    color = card + " " + "diamonds"; break;
                case 3:
                    color = card + " " + "hearts"; break;
                case 4:
                    color = card + " " + "spades"; break;

            }
            for (int cards = 1; cards <= 13; cards++)
            {
                string cardName = string.Empty;
                switch (cards)
                {
                    case 1:
                        cardName = "Ace" + " " + color; break;
                    case 2:
                        cardName = "Two" + " " + color; break;
                    case 3:
                        cardName = "Three" + " " + color; break;
                    case 4:
                        cardName = "Four" + " " + color; break;
                    case 5:
                        cardName = "Five" + " " + color; break;
                    case 6:
                        cardName = "Six" + " " + color; break;
                    case 7:
                        cardName = "Seven" + " " + color; break;
                    case 8:
                        cardName = "Eight" + " " + color; break;
                    case 9:
                        cardName = "Nine" + " " + color; break;
                    case 10:
                        cardName = "Ten" + " " + color; break;
                    case 11:
                        cardName = "Jack" + " " + color; break;
                    case 12:
                        cardName = "Queen" + " " + color; break;
                    case 13:
                        cardName = "King" + " " + color; break;
                }
                Console.WriteLine(cardName);
            }
        }
    }
}    

