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
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonApplyGame = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.buttonApplyBet = new System.Windows.Forms.Button();
            this.buttonClearBet = new System.Windows.Forms.Button();
            this.inputBet = new System.Windows.Forms.TextBox();
            this.labelBallance = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "BlackJack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Controls.Add(this.buttonApplyGame);
            this.panel1.Controls.Add(this.buttonAddCard);
            this.panel1.Controls.Add(this.buttonApplyBet);
            this.panel1.Controls.Add(this.buttonClearBet);
            this.panel1.Controls.Add(this.inputBet);
            this.panel1.Controls.Add(this.labelBallance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 256);
            this.panel1.TabIndex = 6;
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(5, 135);
            this.labelScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(114, 37);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "0";
            // 
            // buttonApplyGame
            // 
            this.buttonApplyGame.Location = new System.Drawing.Point(61, 180);
            this.buttonApplyGame.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApplyGame.Name = "buttonApplyGame";
            this.buttonApplyGame.Size = new System.Drawing.Size(55, 25);
            this.buttonApplyGame.TabIndex = 6;
            this.buttonApplyGame.Text = "Хватит";
            this.buttonApplyGame.UseVisualStyleBackColor = true;
            this.buttonApplyGame.Click += new System.EventHandler(this.buttonApplyGame_Click);
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Location = new System.Drawing.Point(5, 180);
            this.buttonAddCard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(55, 25);
            this.buttonAddCard.TabIndex = 5;
            this.buttonAddCard.Text = "Ещё карту";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // buttonApplyBet
            // 
            this.buttonApplyBet.Location = new System.Drawing.Point(61, 97);
            this.buttonApplyBet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonApplyBet.Name = "buttonApplyBet";
            this.buttonApplyBet.Size = new System.Drawing.Size(56, 29);
            this.buttonApplyBet.TabIndex = 4;
            this.buttonApplyBet.Text = "Принять";
            this.buttonApplyBet.UseVisualStyleBackColor = true;
            this.buttonApplyBet.Click += new System.EventHandler(this.buttonApplyBet_Click_1);
            // 
            // buttonClearBet
            // 
            this.buttonClearBet.Location = new System.Drawing.Point(5, 97);
            this.buttonClearBet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonClearBet.Name = "buttonClearBet";
            this.buttonClearBet.Size = new System.Drawing.Size(56, 29);
            this.buttonClearBet.TabIndex = 3;
            this.buttonClearBet.Text = "Отмена";
            this.buttonClearBet.UseVisualStyleBackColor = true;
            this.buttonClearBet.Click += new System.EventHandler(this.buttonClearBet_Click);
            // 
            // inputBet
            // 
            this.inputBet.BackColor = System.Drawing.SystemColors.GrayText;
            this.inputBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBet.Location = new System.Drawing.Point(5, 50);
            this.inputBet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputBet.Name = "inputBet";
            this.inputBet.Size = new System.Drawing.Size(114, 53);
            this.inputBet.TabIndex = 2;
            this.inputBet.Text = "Ставка";
            // 
            // labelBallance
            // 
            this.labelBallance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBallance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBallance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBallance.Location = new System.Drawing.Point(5, 10);
            this.labelBallance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBallance.Name = "labelBallance";
            this.labelBallance.Size = new System.Drawing.Size(114, 37);
            this.labelBallance.TabIndex = 0;
            this.labelBallance.Text = "500$";
            // 
            // userCard1
            // 
            this.userCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard1.Location = new System.Drawing.Point(167, 200);
            this.userCard1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(66, 85);
            this.userCard1.TabIndex = 7;
            // 
            // userCard2
            // 
            this.userCard2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard2.Location = new System.Drawing.Point(237, 200);
            this.userCard2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.userCard2.Name = "userCard2";
            this.userCard2.Size = new System.Drawing.Size(66, 85);
            this.userCard2.TabIndex = 8;
            // 
            // userCard3
            // 
            this.userCard3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard3.Location = new System.Drawing.Point(307, 200);
            this.userCard3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.userCard3.Name = "userCard3";
            this.userCard3.Size = new System.Drawing.Size(66, 85);
            this.userCard3.TabIndex = 9;
            // 
            // userCard4
            // 
            this.userCard4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard4.Location = new System.Drawing.Point(377, 200);
            this.userCard4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.userCard4.Name = "userCard4";
            this.userCard4.Size = new System.Drawing.Size(66, 85);
            this.userCard4.TabIndex = 10;
            // 
            // userCard5
            // 
            this.userCard5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCard5.Location = new System.Drawing.Point(447, 200);
            this.userCard5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.userCard5.Name = "userCard5";
            this.userCard5.Size = new System.Drawing.Size(66, 85);
            this.userCard5.TabIndex = 11;
            // 
            // crupieCard5
            // 
            this.crupieCard5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.crupieCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard5.Location = new System.Drawing.Point(447, 51);
            this.crupieCard5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.crupieCard5.Name = "crupieCard5";
            this.crupieCard5.Size = new System.Drawing.Size(66, 85);
            this.crupieCard5.TabIndex = 16;
            // 
            // crupieCard4
            // 
            this.crupieCard4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.crupieCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard4.Location = new System.Drawing.Point(377, 51);
            this.crupieCard4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.crupieCard4.Name = "crupieCard4";
            this.crupieCard4.Size = new System.Drawing.Size(66, 85);
            this.crupieCard4.TabIndex = 15;
            // 
            // crupieCard3
            // 
            this.crupieCard3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.crupieCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard3.Location = new System.Drawing.Point(307, 51);
            this.crupieCard3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.crupieCard3.Name = "crupieCard3";
            this.crupieCard3.Size = new System.Drawing.Size(66, 85);
            this.crupieCard3.TabIndex = 14;
            // 
            // crupieCard2
            // 
            this.crupieCard2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.crupieCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard2.Location = new System.Drawing.Point(237, 51);
            this.crupieCard2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.crupieCard2.Name = "crupieCard2";
            this.crupieCard2.Size = new System.Drawing.Size(66, 85);
            this.crupieCard2.TabIndex = 13;
            // 
            // crupieCard1
            // 
            this.crupieCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.crupieCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crupieCard1.Location = new System.Drawing.Point(167, 51);
            this.crupieCard1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.crupieCard1.Name = "crupieCard1";
            this.crupieCard1.Size = new System.Drawing.Size(66, 85);
            this.crupieCard1.TabIndex = 12;
            // 
            // gameResult
            // 
            this.gameResult.Enabled = false;
            this.gameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameResult.Location = new System.Drawing.Point(124, 51);
            this.gameResult.Name = "gameResult";
            this.gameResult.Size = new System.Drawing.Size(412, 254);
            this.gameResult.TabIndex = 17;
            this.gameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameResult.Click += new System.EventHandler(this.gameResult_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(536, 305);
            this.Controls.Add(this.crupieCard5);
            this.Controls.Add(this.userCard5);
            this.Controls.Add(this.crupieCard4);
            this.Controls.Add(this.userCard4);
            this.Controls.Add(this.crupieCard3);
            this.Controls.Add(this.userCard3);
            this.Controls.Add(this.crupieCard2);
            this.Controls.Add(this.userCard2);
            this.Controls.Add(this.crupieCard1);
            this.Controls.Add(this.userCard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameResult);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "GameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label gameResult;

        private System.Windows.Forms.Label labelScore;

        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.Button buttonApplyGame;

        private System.Windows.Forms.Button buttonClearBet;
        private System.Windows.Forms.Button buttonApplyBet;

        private System.Windows.Forms.TextBox inputBet;

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