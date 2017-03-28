using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePoker
{
    class Deck
    {
        Suit[] Suits = new Suit[4];
        Card[] cards = new Card[52];
        Random gen = new Random();
        //This function Creates a Deck
        public Deck()
        {
            //Building Suits
            for(int i=0;i<4;i++)
            {
                Suits[i] = new Suit();
                if (i==0)
                {
                    Suits[i].Name = "Hearts";
                }
                if (i == 1)
                {
                    Suits[i].Name = "Diamonds";
                }
                if (i == 2)
                {
                    Suits[i].Name = "Clubs";
                }
                if (i == 3)
                {
                    Suits[i].Name = "Spades";
                }

            }
            //Building Cards
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards[i * 13 + j] = new Card();
                    cards[i * 13 + j].Num = j;
                    
                    cards[i * 13 + j].Suit = Suits[i];
                    cards[i * 13 + j].Default_Pos = i * 13 + j;
                    cards[i * 13 + j].Dealt = false;
                }
            }
        }
        public Card Deal_Card()
        {
            while (true)
            {
                int index = gen.Next(cards.Length);
                if (cards[index].Dealt == false)
                {
                    cards[index].Dealt = true;
                    return cards[index];
                }
            }
        }
        public void Shuffle()
        {
            for (int i=0; i < 52; i++)
            {
                cards[i].Dealt = false;
            }
        }
        // All_Dealt must be used every time before dealing a card because Deal_Card could go into an infinite loop
        public bool All_Dealt()
        {
            for (int i = 0; i < 52; i++)
            {
                if (cards[i].Dealt == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
