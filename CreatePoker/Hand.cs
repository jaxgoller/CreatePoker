﻿using System;
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
            if (HasPair() == true && Has2Pair() == false)
            {
                score = 1;
                Console.Write("Has pair");
                System.Windows.Forms.MessageBox.Show("Has a Pair");
            }
            else
            {
                if (Has2Pair() == true && Has3Pair() == false)
                {
                    score = 2;
                    Console.Write("Has 2 Pair");
                }
                else
                {
                    if (Has3Pair() == true)
                    {
                        score = 3;
                        Console.Write("Has 3 Pair");
                    }
                    score = 0;
                    Console.Write("no pairs detected");
                }
            }
            Console.WriteLine(score);
            return 0;
        }
        public bool HasPair()
        {
            //only has six because the last card will have been checked against all other cards
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 7; j++)
                    if (cards[i].Num == cards[j].Num)
                    {
                        Console.WriteLine(cards[i].Num);
                        return true;
                    }
            }
            return false;
        }
        public bool Has2Pair()
        {
            bool pair1=false;
            bool pair2 = false;
            int num1=-1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 7; j++)
                {
                    if (cards[i].Num == cards[j].Num && cards[i].Num!=num1)
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
            if (pair1==true && pair2 == true)
            {
                return true;
            }
            return false;
        }
        public bool Has3Pair()
        {
            bool pair1 = false;
            bool pair2 = false;
            bool pair3 = false;
            int num1 = -1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 7; j++)
                {
                    //whats going on here
                    if (cards[i].Num == cards[j].Num && cards[i].Num != num1)
                    {
                        if (num1 == -1)
                        {
                            pair1 = true;
                            num1 = 0;
                        }
                        else
                        {
                            if (num1 == 0)
                            {
                                pair2 = true;
                            }
                            else
                            {
                                pair3 = true;
                            }
                        }
                    }
                }
            }
            if (pair1 == true && pair2 == true && pair3 == true)
            {
                return true;
            }
            return false;
        }
    }
}
