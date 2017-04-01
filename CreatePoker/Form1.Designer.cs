namespace CreatePoker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Photolst = new System.Windows.Forms.ImageList(this.components);
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.Card9 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Shuffle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MoneyPlayer = new System.Windows.Forms.Label();
            this.MoneyBot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MoneyOpponent = new System.Windows.Forms.Label();
            this.BetAmmount = new System.Windows.Forms.TextBox();
            this.Bet = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.Fold = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Pot = new System.Windows.Forms.Label();
            this.AllIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Check1 = new System.Windows.Forms.Button();
            this.Check2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            this.SuspendLayout();
            // 
            // Photolst
            // 
            this.Photolst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Photolst.ImageStream")));
            this.Photolst.TransparentColor = System.Drawing.Color.Transparent;
            this.Photolst.Images.SetKeyName(0, "2_Clubs.jpg");
            this.Photolst.Images.SetKeyName(1, "2_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(2, "2_Hearts.jpg");
            this.Photolst.Images.SetKeyName(3, "2_Spades.jpg");
            this.Photolst.Images.SetKeyName(4, "3_Clubs.jpg");
            this.Photolst.Images.SetKeyName(5, "3_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(6, "3_Hearts.jpg");
            this.Photolst.Images.SetKeyName(7, "3_Spades.jpg");
            this.Photolst.Images.SetKeyName(8, "4_Clubs.jpg");
            this.Photolst.Images.SetKeyName(9, "4_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(10, "4_Hearts.jpg");
            this.Photolst.Images.SetKeyName(11, "4_Spades.jpg");
            this.Photolst.Images.SetKeyName(12, "5_Clubs.jpg");
            this.Photolst.Images.SetKeyName(13, "5_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(14, "5_Hearts.jpg");
            this.Photolst.Images.SetKeyName(15, "5_Spades.jpg");
            this.Photolst.Images.SetKeyName(16, "6_Clubs.jpg");
            this.Photolst.Images.SetKeyName(17, "6_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(18, "6_Hearts.jpg");
            this.Photolst.Images.SetKeyName(19, "6_Spades.jpg");
            this.Photolst.Images.SetKeyName(20, "7_Clubs.jpg");
            this.Photolst.Images.SetKeyName(21, "7_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(22, "7_Hearts.jpg");
            this.Photolst.Images.SetKeyName(23, "7_Spades.jpg");
            this.Photolst.Images.SetKeyName(24, "8_Clubs.jpg");
            this.Photolst.Images.SetKeyName(25, "8_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(26, "8_Hearts.jpg");
            this.Photolst.Images.SetKeyName(27, "8_Spades.jpg");
            this.Photolst.Images.SetKeyName(28, "9_Clubs.jpg");
            this.Photolst.Images.SetKeyName(29, "9_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(30, "9_Hearts.jpg");
            this.Photolst.Images.SetKeyName(31, "9_Spades.jpg");
            this.Photolst.Images.SetKeyName(32, "10_Clubs.jpg");
            this.Photolst.Images.SetKeyName(33, "10_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(34, "10_Hearts.jpg");
            this.Photolst.Images.SetKeyName(35, "10_Spades.jpg");
            this.Photolst.Images.SetKeyName(36, "Jack_Clubs.jpg");
            this.Photolst.Images.SetKeyName(37, "Jack_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(38, "Jack_Hearts.jpg");
            this.Photolst.Images.SetKeyName(39, "Jack_Spades.jpg");
            this.Photolst.Images.SetKeyName(40, "Queen_Clubs.jpg");
            this.Photolst.Images.SetKeyName(41, "Queen_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(42, "Queen_Hearts.jpg");
            this.Photolst.Images.SetKeyName(43, "Queen_Spades.jpg");
            this.Photolst.Images.SetKeyName(44, "King_Clubs.jpg");
            this.Photolst.Images.SetKeyName(45, "King_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(46, "King_Hearts.jpg");
            this.Photolst.Images.SetKeyName(47, "King_Spades.jpg");
            this.Photolst.Images.SetKeyName(48, "Ace_Clubs.jpg");
            this.Photolst.Images.SetKeyName(49, "Ace_Diamonds.jpg");
            this.Photolst.Images.SetKeyName(50, "Ace_Hearts.jpg");
            this.Photolst.Images.SetKeyName(51, "Ace_Spades.jpg");
            // 
            // Card1
            // 
            this.Card1.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card1.Location = new System.Drawing.Point(12, 68);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(105, 150);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // Card2
            // 
            this.Card2.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card2.Location = new System.Drawing.Point(11, 224);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(105, 150);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 1;
            this.Card2.TabStop = false;
            // 
            // Card3
            // 
            this.Card3.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card3.Location = new System.Drawing.Point(319, 152);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(105, 150);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 2;
            this.Card3.TabStop = false;
            // 
            // Card4
            // 
            this.Card4.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card4.Location = new System.Drawing.Point(430, 152);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(105, 150);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4.TabIndex = 3;
            this.Card4.TabStop = false;
            // 
            // Card6
            // 
            this.Card6.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card6.Location = new System.Drawing.Point(652, 152);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(105, 150);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card6.TabIndex = 4;
            this.Card6.TabStop = false;
            // 
            // Card8
            // 
            this.Card8.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card8.Location = new System.Drawing.Point(1022, 68);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(105, 150);
            this.Card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card8.TabIndex = 5;
            this.Card8.TabStop = false;
            // 
            // Card9
            // 
            this.Card9.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card9.Location = new System.Drawing.Point(1022, 224);
            this.Card9.Name = "Card9";
            this.Card9.Size = new System.Drawing.Size(105, 150);
            this.Card9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card9.TabIndex = 6;
            this.Card9.TabStop = false;
            // 
            // Card5
            // 
            this.Card5.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card5.Location = new System.Drawing.Point(541, 152);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(105, 150);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5.TabIndex = 7;
            this.Card5.TabStop = false;
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // Card7
            // 
            this.Card7.Image = global::CreatePoker.Properties.Resources.Backface_Blue;
            this.Card7.Location = new System.Drawing.Point(763, 152);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(105, 150);
            this.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card7.TabIndex = 8;
            this.Card7.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1039, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Opponent\'s hand";
            // 
            // Shuffle
            // 
            this.Shuffle.BackColor = System.Drawing.Color.Aqua;
            this.Shuffle.Location = new System.Drawing.Point(489, 384);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(193, 62);
            this.Shuffle.TabIndex = 11;
            this.Shuffle.Text = "New hand";
            this.Shuffle.UseVisualStyleBackColor = false;
            this.Shuffle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your hand";
            // 
            // MoneyPlayer
            // 
            this.MoneyPlayer.AutoSize = true;
            this.MoneyPlayer.BackColor = System.Drawing.Color.White;
            this.MoneyPlayer.Location = new System.Drawing.Point(37, 409);
            this.MoneyPlayer.Name = "MoneyPlayer";
            this.MoneyPlayer.Size = new System.Drawing.Size(31, 13);
            this.MoneyPlayer.TabIndex = 14;
            this.MoneyPlayer.Text = "1000";
            // 
            // MoneyBot
            // 
            this.MoneyBot.AutoSize = true;
            this.MoneyBot.BackColor = System.Drawing.Color.White;
            this.MoneyBot.Location = new System.Drawing.Point(1096, 409);
            this.MoneyBot.Name = "MoneyBot";
            this.MoneyBot.Size = new System.Drawing.Size(31, 13);
            this.MoneyBot.TabIndex = 15;
            this.MoneyBot.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(29, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Your Money";
            // 
            // MoneyOpponent
            // 
            this.MoneyOpponent.AutoSize = true;
            this.MoneyOpponent.Location = new System.Drawing.Point(1042, 384);
            this.MoneyOpponent.Name = "MoneyOpponent";
            this.MoneyOpponent.Size = new System.Drawing.Size(96, 13);
            this.MoneyOpponent.TabIndex = 17;
            this.MoneyOpponent.Text = "Opponent\'s Money";
            // 
            // BetAmmount
            // 
            this.BetAmmount.Location = new System.Drawing.Point(12, 482);
            this.BetAmmount.Multiline = true;
            this.BetAmmount.Name = "BetAmmount";
            this.BetAmmount.Size = new System.Drawing.Size(89, 35);
            this.BetAmmount.TabIndex = 18;
            this.BetAmmount.Text = "0";
            this.BetAmmount.TextChanged += new System.EventHandler(this.Bet_Ammount_TextChanged);
            // 
            // Bet
            // 
            this.Bet.BackColor = System.Drawing.Color.Aqua;
            this.Bet.Location = new System.Drawing.Point(112, 482);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(79, 35);
            this.Bet.TabIndex = 20;
            this.Bet.Text = "Bet";
            this.Bet.UseVisualStyleBackColor = false;
            this.Bet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Aqua;
            this.Check.Location = new System.Drawing.Point(112, 441);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(78, 35);
            this.Check.TabIndex = 21;
            this.Check.Text = "Flip Cards";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Fold
            // 
            this.Fold.BackColor = System.Drawing.Color.Aqua;
            this.Fold.Location = new System.Drawing.Point(197, 483);
            this.Fold.Name = "Fold";
            this.Fold.Size = new System.Drawing.Size(78, 34);
            this.Fold.TabIndex = 22;
            this.Fold.Text = "Fold";
            this.Fold.UseVisualStyleBackColor = false;
            this.Fold.Click += new System.EventHandler(this.Fold_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "POT";
            // 
            // Pot
            // 
            this.Pot.AutoSize = true;
            this.Pot.BackColor = System.Drawing.Color.White;
            this.Pot.Location = new System.Drawing.Point(565, 68);
            this.Pot.Name = "Pot";
            this.Pot.Size = new System.Drawing.Size(13, 13);
            this.Pot.TabIndex = 24;
            this.Pot.Text = "0";
            // 
            // AllIn
            // 
            this.AllIn.BackColor = System.Drawing.Color.Aqua;
            this.AllIn.Location = new System.Drawing.Point(197, 441);
            this.AllIn.Name = "AllIn";
            this.AllIn.Size = new System.Drawing.Size(78, 36);
            this.AllIn.TabIndex = 25;
            this.AllIn.Text = "ALL IN";
            this.AllIn.UseVisualStyleBackColor = false;
            this.AllIn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Enter Bet Ammount";
            // 
            // Check1
            // 
            this.Check1.BackColor = System.Drawing.Color.Aqua;
            this.Check1.Location = new System.Drawing.Point(114, 442);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(77, 35);
            this.Check1.TabIndex = 27;
            this.Check1.Text = "Flip next";
            this.Check1.UseVisualStyleBackColor = false;
            this.Check1.Click += new System.EventHandler(this.Check1_Click);
            // 
            // Check2
            // 
            this.Check2.BackColor = System.Drawing.Color.Aqua;
            this.Check2.Location = new System.Drawing.Point(113, 441);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(78, 35);
            this.Check2.TabIndex = 28;
            this.Check2.Text = "Flip next";
            this.Check2.UseVisualStyleBackColor = false;
            this.Check2.Click += new System.EventHandler(this.Check2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1150, 529);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllIn);
            this.Controls.Add(this.Pot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Fold);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.BetAmmount);
            this.Controls.Add(this.MoneyOpponent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MoneyBot);
            this.Controls.Add(this.MoneyPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Card7);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card9);
            this.Controls.Add(this.Card8);
            this.Controls.Add(this.Card6);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jaxton Goller\'s Create Project";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList Photolst;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.PictureBox Card9;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Shuffle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MoneyPlayer;
        private System.Windows.Forms.Label MoneyBot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MoneyOpponent;
        private System.Windows.Forms.TextBox BetAmmount;
        private System.Windows.Forms.Button Bet;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Fold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Pot;
        private System.Windows.Forms.Button AllIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Check1;
        private System.Windows.Forms.Button Check2;
    }
}

