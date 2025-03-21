using System.ComponentModel;

namespace BlackJack_0._2._1.Images
{
    partial class FormChangeDiff
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
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonDiffHard = new System.Windows.Forms.Button();
            this.buttonDiffMedium = new System.Windows.Forms.Button();
            this.buttonDiffEasy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(276, 229);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(247, 42);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "В меню";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonDiffHard
            // 
            this.buttonDiffHard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDiffHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiffHard.Location = new System.Drawing.Point(276, 181);
            this.buttonDiffHard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDiffHard.Name = "buttonDiffHard";
            this.buttonDiffHard.Size = new System.Drawing.Size(247, 42);
            this.buttonDiffHard.TabIndex = 8;
            this.buttonDiffHard.Text = "Реальность";
            this.buttonDiffHard.UseVisualStyleBackColor = false;
            this.buttonDiffHard.Click += new System.EventHandler(this.buttonDiffHard_Click);
            // 
            // buttonDiffMedium
            // 
            this.buttonDiffMedium.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDiffMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiffMedium.Location = new System.Drawing.Point(276, 134);
            this.buttonDiffMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDiffMedium.Name = "buttonDiffMedium";
            this.buttonDiffMedium.Size = new System.Drawing.Size(247, 42);
            this.buttonDiffMedium.TabIndex = 7;
            this.buttonDiffMedium.Text = "Средняя";
            this.buttonDiffMedium.UseVisualStyleBackColor = false;
            this.buttonDiffMedium.Click += new System.EventHandler(this.buttonDiffMedium_Click);
            // 
            // buttonDiffEasy
            // 
            this.buttonDiffEasy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDiffEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiffEasy.Location = new System.Drawing.Point(276, 87);
            this.buttonDiffEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDiffEasy.Name = "buttonDiffEasy";
            this.buttonDiffEasy.Size = new System.Drawing.Size(247, 42);
            this.buttonDiffEasy.TabIndex = 6;
            this.buttonDiffEasy.Text = "Легкая";
            this.buttonDiffEasy.UseVisualStyleBackColor = false;
            this.buttonDiffEasy.Click += new System.EventHandler(this.buttonDiffEasy_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "BlackJack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChangeDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonDiffHard);
            this.Controls.Add(this.buttonDiffMedium);
            this.Controls.Add(this.buttonDiffEasy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormChangeDiff";
            this.Text = "Выбор сложности";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button buttonDiffHard;
        private System.Windows.Forms.Button buttonDiffMedium;
        private System.Windows.Forms.Button buttonDiffEasy;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}