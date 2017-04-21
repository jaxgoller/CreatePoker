using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatePoker
{
    public partial class Form1 : Form
        //Card Arrangement Bug fix: re order in list to be 2-A of each suit.
    {
        int[] deal = new int[9];
        Deck deck;
        Pocket Player0 = new Pocket();
        Pocket Player1 = new Pocket();
        River river = new River();
        Winner Winner;
        public Form1()
        {
            deck = new Deck();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Check.Visible = false;
            Check1.Visible = false;
            Check2.Visible = false;
        }
        //shuffle
        private void Button1_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            int cardcount = 0;
            if (deck.All_Dealt() == false)
            {
                PictureBox[] boxes = { Card1, Card2 };
                while (cardcount < 2)
                {
                    Card c = deck.Deal_Card();
                    Player1.Cards[cardcount] = c;
                    int index = c.Default_Pos;
                    boxes[cardcount].Image = Photolst.Images[index];
                    Console.WriteLine(Photolst.Images[index].ToString());
                    cardcount++;
                }
            }
            Shuffle.Visible = false;
            Check.Visible = true;
        }
        private void Bet_Ammount_TextChanged(object sender, EventArgs e)
        {

        }
        //Betting
        private void Bet_Click(object sender, EventArgs e)
        {
            int PlayMon = int.Parse(MoneyPlayer.Text);
            int BotMon = int.Parse(MoneyBot.Text);
            int BetNum = int.Parse(BetAmmount.Text);
            int PotNum = int.Parse(Pot.Text);
            if (PlayMon > 0)
            {
                if (BetNum <= PlayMon)
                {
                    PlayMon = PlayMon - BetNum;
                    string MonPlay = PlayMon.ToString();
                    BotMon = BotMon - BetNum;
                    string MonBot = BotMon.ToString();
                    MoneyBot.Text = (MonBot);
                    MoneyPlayer.Text = (MonPlay);
                    BetNum = BetNum + PotNum + BetNum;
                    string bet = BetNum.ToString();
                    Pot.Text = (bet);
                }

            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (deck.All_Dealt() == false)
            {
                PictureBox[] boxes = { Card3, Card4, Card5 };
                int cardcount = 0;
                while (cardcount < 3)
                {
                    Card c = deck.Deal_Card();
                    river.Cards[cardcount] = c;
                    int index = c.Default_Pos;
                    boxes[cardcount].Image = Photolst.Images[index];
                    cardcount++;

                }
                Check.Visible = false;
                Check1.Visible = true;
            }
        }
        //All in
        private void button1_Click_1(object sender, EventArgs e)
        {
            int PlayMon = int.Parse(MoneyPlayer.Text);
            int BotMon = int.Parse(MoneyBot.Text);
            int PotNum = int.Parse(Pot.Text);
            PotNum = PotNum + PlayMon+BotMon;
            PlayMon = 0;
            BotMon = 0;
            string MonBot = BotMon.ToString();
            string MonPlay = PlayMon.ToString();
            MoneyBot.Text = (MonBot);
            MoneyPlayer.Text = (MonPlay);

            string bet = PotNum.ToString();
            Pot.Text = (bet);
        }

        private void Fold_Click(object sender, EventArgs e)
        {
            int PotNum = int.Parse(Pot.Text);
            int OppMon = int.Parse(MoneyBot.Text);
            OppMon = OppMon + PotNum;
            PotNum = 0;
            string Zero = PotNum.ToString();
            Pot.Text = Zero;
            string opponent = OppMon.ToString();
            MoneyBot.Text = opponent;
        }

        private void Card5_Click(object sender, EventArgs e)
        {

        }

        private void Check1_Click(object sender, EventArgs e)
        {
            if (deck.All_Dealt() == false)
            {
                PictureBox[] boxes = { Card6};
                int cardcount = 0;
                while (cardcount < 1)
                {
                    Card c = deck.Deal_Card();
                    river.Cards[3] = c;
                    int index = c.Default_Pos;
                    boxes[cardcount].Image = Photolst.Images[index];
                    cardcount++;
                }
                Check2.Visible = true;
                Check1.Visible = false;
            }
        }

        private void Check2_Click(object sender, EventArgs e)
        {
            if (deck.All_Dealt() == false)
            {
                PictureBox[] boxes = { Card7, Card8, Card9 };
                int cardcount = 0;
                while (cardcount < 3)
                {
                    Card c = deck.Deal_Card();
                    if (cardcount == 0)
                    {
                        river.Cards[4] = c;
                    }
                    else
                    {
                        Player0.Cards[cardcount - 1] = c;
                    }
                    int index = c.Default_Pos;
                    boxes[cardcount].Image = Photolst.Images[index];
                    cardcount++;
                }
            }
            Check2.Visible = false;
            Hand p0hand = new Hand(river, Player0);
            p0hand.Score();
            Hand p1hand = new Hand(river, Player1);
            p1hand.Score();
        }

        private void Card1_Click(object sender, EventArgs e)
        {

        }
    }
}
