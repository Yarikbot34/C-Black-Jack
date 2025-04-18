using System.ComponentModel;

namespace BlackJack_0._2._1.Properties
{
    partial class MenuForm
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
            this.fastGameButton = new System.Windows.Forms.Button();
            this.buttonDifficulty = new System.Windows.Forms.Button();
            this.buttonWhatNew = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "BlackJack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fastGameButton
            // 
            this.fastGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fastGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastGameButton.Location = new System.Drawing.Point(233, 70);
            this.fastGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastGameButton.Name = "fastGameButton";
            this.fastGameButton.Size = new System.Drawing.Size(247, 42);
            this.fastGameButton.TabIndex = 1;
            this.fastGameButton.Text = "Быстрый старт";
            this.fastGameButton.UseVisualStyleBackColor = false;
            this.fastGameButton.Click += new System.EventHandler(this.fastGameButton_Click);
            // 
            // buttonDifficulty
            // 
            this.buttonDifficulty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDifficulty.Location = new System.Drawing.Point(233, 117);
            this.buttonDifficulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDifficulty.Name = "buttonDifficulty";
            this.buttonDifficulty.Size = new System.Drawing.Size(247, 42);
            this.buttonDifficulty.TabIndex = 2;
            this.buttonDifficulty.Text = "Выбор сложности";
            this.buttonDifficulty.UseVisualStyleBackColor = false;
            this.buttonDifficulty.Click += new System.EventHandler(this.buttonDifficulty_Click);
            // 
            // buttonWhatNew
            // 
            this.buttonWhatNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonWhatNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhatNew.Location = new System.Drawing.Point(233, 164);
            this.buttonWhatNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWhatNew.Name = "buttonWhatNew";
            this.buttonWhatNew.Size = new System.Drawing.Size(247, 42);
            this.buttonWhatNew.TabIndex = 3;
            this.buttonWhatNew.Text = "Что нового?";
            this.buttonWhatNew.UseVisualStyleBackColor = false;
            this.buttonWhatNew.Click += new System.EventHandler(this.buttonWhatNew_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(233, 212);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(247, 42);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(233, 258);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(247, 42);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Проверить обновления";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonWhatNew);
            this.Controls.Add(this.buttonDifficulty);
            this.Controls.Add(this.fastGameButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonUpdate;

        private System.Windows.Forms.Button fastGameButton;
        private System.Windows.Forms.Button buttonDifficulty;
        private System.Windows.Forms.Button buttonWhatNew;
        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}