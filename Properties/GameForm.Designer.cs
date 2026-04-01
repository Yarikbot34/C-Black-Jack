using System.ComponentModel;

namespace BlackJack_0._2._1.Properties
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllInButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBet = new System.Windows.Forms.NumericUpDown();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonApplyBet = new System.Windows.Forms.Button();
            this.buttonClearBet = new System.Windows.Forms.Button();
            this.labelBallance = new System.Windows.Forms.Label();
            this.buttonApplyGame = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.userCard1 = new System.Windows.Forms.Panel();
            this.userCard2 = new System.Windows.Forms.Panel();
            this.userCard3 = new System.Windows.Forms.Panel();
            this.userCard4 = new System.Windows.Forms.Panel();
            this.userCard5 = new System.Windows.Forms.Panel();
            this.crupieCard5 = new System.Windows.Forms.Panel();
            this.crupieCard4 = new System.Windows.Forms.Panel();
            this.crupieCard3 = new System.Windows.Forms.Panel();
            this.crupieCard2 = new System.Windows.Forms.Panel();
            this.crupieCard1 = new System.Windows.Forms.Panel();
            this.gameResult = new System.Windows.Forms.Label();
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = "BlackJack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.AllInButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputBet);
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Controls.Add(this.buttonApplyBet);
            this.panel1.Controls.Add(this.buttonClearBet);
            this.panel1.Controls.Add(this.labelBallance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 669);
            this.panel1.TabIndex = 6;
            // 
            // AllInButton
            // 
            this.AllInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AllInButton.FlatAppearance.BorderSize = 0;
            this.AllInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllInButton.Location = new System.Drawing.Point(9, 304);
            this.AllInButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AllInButton.Name = "AllInButton";
            this.AllInButton.Size = new System.Drawing.Size(143, 76);
            this.AllInButton.TabIndex = 11;
            this.AllInButton.Text = "ALL IN";
            this.AllInButton.UseVisualStyleBackColor = false;
            this.AllInButton.Click += new System.EventHandler(this.AllInButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 70);
            this.label3.TabIndex = 10;
            this.label3.Text = "Счёт:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 70);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ставка:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputBet
            // 
            this.inputBet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBet.Increment = new decimal(new int[] { 25, 0, 0, 0 });
            this.inputBet.Location = new System.Drawing.Point(48, 200);
            this.inputBet.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.inputBet.Name = "inputBet";
            this.inputBet.Size = new System.Drawing.Size(244, 89);
            this.inputBet.TabIndex = 8;
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(9, 457);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(283, 56);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "0";
            // 
            // buttonApplyBet
            // 
            this.buttonApplyBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonApplyBet.FlatAppearance.BorderSize = 0;
            this.buttonApplyBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyBet.Location = new System.Drawing.Point(158, 304);
            this.buttonApplyBet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonApplyBet.Name = "buttonApplyBet";
            this.buttonApplyBet.Size = new System.Drawing.Size(134, 76);
            this.buttonApplyBet.TabIndex = 4;
            this.buttonApplyBet.Text = "Принять";
            this.buttonApplyBet.UseVisualStyleBackColor = false;
            this.buttonApplyBet.Click += new System.EventHandler(this.buttonApplyBet_Click_1);
            // 
            // buttonClearBet
            // 
            this.buttonClearBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearBet.FlatAppearance.BorderSize = 0;
            this.buttonClearBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearBet.Location = new System.Drawing.Point(8, 200);
            this.buttonClearBet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonClearBet.Name = "buttonClearBet";
            this.buttonClearBet.Size = new System.Drawing.Size(34, 89);
            this.buttonClearBet.TabIndex = 3;
            this.buttonClearBet.Text = "X";
            this.buttonClearBet.UseVisualStyleBackColor = false;
            this.buttonClearBet.Click += new System.EventHandler(this.buttonClearBet_Click);
            // 
            // labelBallance
            // 
            this.labelBallance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBallance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBallance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBallance.Location = new System.Drawing.Point(8, 15);
            this.labelBallance.Name = "labelBallance";
            this.labelBallance.Size = new System.Drawing.Size(284, 110);
            this.labelBallance.TabIndex = 0;
            this.labelBallance.Text = "500$";
            // 
            // buttonApplyGame
            // 
            this.buttonApplyGame.Location = new System.Drawing.Point(600, 600);
            this.buttonApplyGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApplyGame.Name = "buttonApplyGame";
            this.buttonApplyGame.Size = new System.Drawing.Size(80, 40);
            this.buttonApplyGame.TabIndex = 6;
            this.buttonApplyGame.Text = "Пас";
            this.buttonApplyGame.UseVisualStyleBackColor = true;
            this.buttonApplyGame.Visible = false;
            this.buttonApplyGame.Click += new System.EventHandler(this.buttonApplyGame_Click);
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCard.Location = new System.Drawing.Point(600, 545);
            this.buttonAddCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(80, 40);
            this.buttonAddCard.TabIndex = 5;
            this.buttonAddCard.Text = "+";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Visible = false;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // userCard1
            // 
            this.userCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard1.Location = new System.Drawing.Point(330, 455);
            this.userCard1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(180, 260);
            this.userCard1.TabIndex = 7;
            // 
            // userCard2
            // 
            this.userCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard2.Location = new System.Drawing.Point(440, 455);
            this.userCard2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.userCard2.Name = "userCard2";
            this.userCard2.Size = new System.Drawing.Size(180, 260);
            this.userCard2.TabIndex = 8;
            // 
            // userCard3
            // 
            this.userCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard3.Location = new System.Drawing.Point(550, 455);
            this.userCard3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.userCard3.Name = "userCard3";
            this.userCard3.Size = new System.Drawing.Size(180, 260);
            this.userCard3.TabIndex = 9;
            // 
            // userCard4
            // 
            this.userCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard4.Location = new System.Drawing.Point(660, 455);
            this.userCard4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.userCard4.Name = "userCard4";
            this.userCard4.Size = new System.Drawing.Size(180, 260);
            this.userCard4.TabIndex = 10;
            // 
            // userCard5
            // 
            this.userCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard5.Location = new System.Drawing.Point(770, 455);
            this.userCard5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.userCard5.Name = "userCard5";
            this.userCard5.Size = new System.Drawing.Size(180, 260);
            this.userCard5.TabIndex = 11;
            // 
            // crupieCard5
            // 
            this.crupieCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.crupieCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard5.Location = new System.Drawing.Point(986, 90);
            this.crupieCard5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.crupieCard5.Name = "crupieCard5";
            this.crupieCard5.Size = new System.Drawing.Size(180, 260);
            this.crupieCard5.TabIndex = 16;
            // 
            // crupieCard4
            // 
            this.crupieCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.crupieCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard4.Location = new System.Drawing.Point(888, 90);
            this.crupieCard4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.crupieCard4.Name = "crupieCard4";
            this.crupieCard4.Size = new System.Drawing.Size(180, 260);
            this.crupieCard4.TabIndex = 15;
            // 
            // crupieCard3
            // 
            this.crupieCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.crupieCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard3.Location = new System.Drawing.Point(702, 90);
            this.crupieCard3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.crupieCard3.Name = "crupieCard3";
            this.crupieCard3.Size = new System.Drawing.Size(180, 260);
            this.crupieCard3.TabIndex = 14;
            // 
            // crupieCard2
            // 
            this.crupieCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.crupieCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard2.Location = new System.Drawing.Point(516, 90);
            this.crupieCard2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.crupieCard2.Name = "crupieCard2";
            this.crupieCard2.Size = new System.Drawing.Size(180, 260);
            this.crupieCard2.TabIndex = 13;
            // 
            // crupieCard1
            // 
            this.crupieCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.crupieCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard1.Location = new System.Drawing.Point(330, 90);
            this.crupieCard1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.crupieCard1.Name = "crupieCard1";
            this.crupieCard1.Size = new System.Drawing.Size(180, 260);
            this.crupieCard1.TabIndex = 12;
            // 
            // gameResult
            // 
            this.gameResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameResult.Enabled = false;
            this.gameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameResult.Location = new System.Drawing.Point(186, 75);
            this.gameResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameResult.Name = "gameResult";
            this.gameResult.Size = new System.Drawing.Size(992, 669);
            this.gameResult.TabIndex = 17;
            this.gameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameResult.Click += new System.EventHandler(this.gameResult_Click);
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.Location = new System.Drawing.Point(1031, 13);
            this.buttonToMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(135, 48);
            this.buttonToMenu.TabIndex = 8;
            this.buttonToMenu.Text = "В меню";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            this.buttonToMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.buttonApplyGame);
            this.Controls.Add(this.crupieCard2);
            this.Controls.Add(this.buttonAddCard);
            this.Controls.Add(this.buttonToMenu);
            this.Controls.Add(this.crupieCard5);
            this.Controls.Add(this.userCard5);
            this.Controls.Add(this.crupieCard4);
            this.Controls.Add(this.userCard4);
            this.Controls.Add(this.crupieCard3);
            this.Controls.Add(this.userCard3);
            this.Controls.Add(this.userCard2);
            this.Controls.Add(this.crupieCard1);
            this.Controls.Add(this.userCard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "GameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputBet)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AllInButton;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.Button buttonToMenu;

        private System.Windows.Forms.Label gameResult;

        private System.Windows.Forms.Label labelScore;

        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.Button buttonApplyGame;

        private System.Windows.Forms.Button buttonClearBet;
        private System.Windows.Forms.Button buttonApplyBet;

        private System.Windows.Forms.NumericUpDown inputBet;

        private System.Windows.Forms.Label labelBallance;

        private System.Windows.Forms.Panel userCard2;
        private System.Windows.Forms.Panel userCard3;
        private System.Windows.Forms.Panel userCard4;
        private System.Windows.Forms.Panel userCard5;
        private System.Windows.Forms.Panel crupieCard5;
        private System.Windows.Forms.Panel crupieCard4;
        private System.Windows.Forms.Panel crupieCard3;
        private System.Windows.Forms.Panel crupieCard2;
        private System.Windows.Forms.Panel crupieCard1;

        private System.Windows.Forms.Panel userCard1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}