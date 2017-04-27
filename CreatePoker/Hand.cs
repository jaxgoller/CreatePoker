using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePoker
{
    class Hand
    {
        Card[] cards = new Card[7];
        public int player;
        public Hand(River river, Pocket pocket)
        {
            // a hand is a collection of river and pocket for each player 
            for (int i = 0; i < 2; i++)
            {
                cards[i] = pocket.Cards[i];
                Console.WriteLine(cards[i].Num);
            }
            for (int i = 0; i < 5; i++)
            {
                cards[i+2] = river.Cards[i];
            }
            //every hand must have player so copying pocket's player to hand's player =) (dosen't have multiple hands)
           player = pocket.Player;
        }
        public int Score()
        {
            int score;
            if (hasonepair() && Has2Pair() == false && HasFullHouse() !=true)

            {
                score = 1;
                Console.Write("Has pair");
                System.Windows.Forms.MessageBox.Show("Has a Pair");
            }
            else
            {
                if (hastwopair())
                {
                    score = 2;
                    Console.Write("Has 2 Pair");
                    System.Windows.Forms.MessageBox.Show("Has 2 Pairs");
                }
                else
                {
                    if (Has3ofAKind())
                    {
                        score = 3;
                        Console.Write("Has 3 of a kind");
                    }
                    else
                    {
                        if (HasStraight())
                        {
                            score = 4;
                            Console.WriteLine("has straight");
                        }
                        else if (Hasflush())
                        {
                            score = 5;
                            Console.WriteLine("has flush");
                        }
                        else if (HasFullHouse())
                        {
                            score = 6;
                            Console.WriteLine("has Full House");
                        }
                        else if (Has4ofAKind())
                        {
                            score = 7;
                            Console.WriteLine("has 4 of a kind");
                        }
                        else if (HasStraightFlush())
                        {
                            score = 8;
                            Console.WriteLine("Has a straight flush");
                        }
                        else
                        {
                            score = 0;
                        }
                    }
                }
            }
            Console.WriteLine(score);
            return score;
        }
        public bool Has3ofAKind()
        {
            int[] number = new int[13];
            for (int i=0; i<7; i++)
            {
                int n = cards[i].Num;
                number[n]++;
            }
            for (int i=0; i<13; i++)
            {
                if (number[i] == 3)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Has4ofAKind()
        {
            int[] number = new int[13];
            for (int i = 0; i < 7; i++)
            {
                int n = cards[i].Num;
                number[n]++;
            }
            for (int i = 0; i < 13; i++)
            {
                if (number[i] == 4)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasFullHouse ()
        {
            //bool three = false;
            //bool pair = false;
            //int[] number = new int[13];
            //for (int i = 0; i < 7; i++)
            //{
            //    int n = cards[i].Num;
            //    number[n]++;
            //}
            //for (int i = 0; i < 13; i++)
            //{
            //    if (number[i] == 3)
            //    {
            //        three = true;
            //    }
            //    if (number[i] == 2)
            //    {
            //        pair = true;            }
            //}
            //return three && pair;
            return Has3ofAKind() && hasonepair();
        }
        public bool hasonepair()
        {
            bool pair = false;
            int[] number = new int[13];
            for (int i = 0; i < 7; i++)
            {
                int n = cards[i].Num;
                number[n]++;
            }
            for (int i = 0; i < 13; i++)
            {
                if ( number[i] == 2)
                {
                    pair = true;
                }
            }
            return pair;
        }
        public bool hastwopair()
        {
            bool first = false;
            bool second = false;
            int[] number = new int[13];
            for (int i = 0; i < 7; i++)
            {
                int n = cards[i].Num;
                number[n]++;
            }
            for (int i = 0; i < 13; i++)
            {
                if (number[i] == 2)
                {
                    first = true;
                }
                if (number[i] == 2 && first)
                {
                    second = true;
                }
            }
            return second && first;
        }
        public bool Hasflush()
        {
            int clubs = 0;
            int hearts = 0;
            int diamonds = 0;
            int spades = 0;
            for (int i=0; i<7; i++)
            {
                if (cards[i].Suit.Name == "Clubs")
                {
                    clubs++;
                }
                else  if (cards[i].Suit.Name == "Hearts")
                {
                    hearts++;
                }
                else if (cards[i].Suit.Name == "Diamonds")
                {
                    diamonds++;
                }
                else if (cards[i].Suit.Name == "Spades")
                {
                    spades++;
                }
            }
            return clubs == 5 || hearts == 5 || diamonds == 5 || spades == 5;
        }
        public int highCard()
        {
            int High = -1;
            for (int i=0; i<7; i++)
            {
                if (cards[i].Num > High)
                {
                    High = cards[i].Num;
                }
            }
            return High;
        }
        public bool HasStraight()
        {
            int[] number = new int[13];
            for (int i = 0; i < 7; i++)
            {
                int n = cards[i].Num;
                number[n]++;
            }
            for (int i=0; i<9; i++)
            {
                if (number[i] == 1 && number[i + 1] == 1 && number[i + 2] == 1 && number[i + 3] == 1 && number[i + 4] == 1)
                {
                    return true;
                }
            }
            // ace low straight
            if (number[0] == 1 && number[1] == 1 && number[2] == 1 && number[3] == 1 && number[12] == 1)
            {
                return true;
            }
            return false;
        }
        public bool HasStraightFlush()
        {
            return Hasflush() && HasStraight();
        }
        public bool Has2Pair()
        {
            bool pair1 = false;
            bool pair2 = false;
            int num1 = -1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 7; j++)
                {
                    if (cards[i].Num == cards[j].Num && cards[i].Num != num1)
                    {
                        if (num1 == -1)
                        {
                            pair1 = true;
                            num1 = cards[i].Num;
                        }
                        else
                        {
                            pair2 = true;
                        }
                    }
                }
            }
            if (pair1 == true && pair2 == true)
            {
                return true;
            }
            return false;
        }
    }
}

