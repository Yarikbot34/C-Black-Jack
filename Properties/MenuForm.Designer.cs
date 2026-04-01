using System.ComponentModel;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fastGameButton = new System.Windows.Forms.Button();
            this.buttonDifficulty = new System.Windows.Forms.Button();
            this.buttonWhatNew = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.multiplayerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "BlackJack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fastGameButton
            // 
            this.fastGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fastGameButton.BackColor = System.Drawing.Color.Transparent;
            this.fastGameButton.FlatAppearance.BorderSize = 0;
            this.fastGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fastGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fastGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastGameButton.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fastGameButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fastGameButton.Location = new System.Drawing.Point(0, 210);
            this.fastGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastGameButton.Name = "fastGameButton";
            this.fastGameButton.Size = new System.Drawing.Size(464, 65);
            this.fastGameButton.TabIndex = 1;
            this.fastGameButton.Text = "Быстрый старт";
            this.fastGameButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fastGameButton.UseVisualStyleBackColor = true;
            this.fastGameButton.Click += new System.EventHandler(this.fastGameButton_Click);
            this.fastGameButton.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            this.fastGameButton.MouseHover += new System.EventHandler(this.MenuButton_MouseHover);
            // 
            // buttonDifficulty
            // 
            this.buttonDifficulty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.buttonDifficulty.FlatAppearance.BorderSize = 0;
            this.buttonDifficulty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDifficulty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDifficulty.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDifficulty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDifficulty.Location = new System.Drawing.Point(0, 279);
            this.buttonDifficulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDifficulty.Name = "buttonDifficulty";
            this.buttonDifficulty.Size = new System.Drawing.Size(464, 65);
            this.buttonDifficulty.TabIndex = 2;
            this.buttonDifficulty.Text = "Выбор сложности";
            this.buttonDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDifficulty.UseVisualStyleBackColor = false;
            this.buttonDifficulty.Click += new System.EventHandler(this.buttonDifficulty_Click);
            this.buttonDifficulty.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            this.buttonDifficulty.MouseHover += new System.EventHandler(this.MenuButton_MouseHover);
            // 
            // buttonWhatNew
            // 
            this.buttonWhatNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonWhatNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonWhatNew.FlatAppearance.BorderSize = 0;
            this.buttonWhatNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonWhatNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonWhatNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhatNew.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.buttonWhatNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonWhatNew.Location = new System.Drawing.Point(0, 348);
            this.buttonWhatNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWhatNew.Name = "buttonWhatNew";
            this.buttonWhatNew.Size = new System.Drawing.Size(464, 65);
            this.buttonWhatNew.TabIndex = 3;
            this.buttonWhatNew.Text = "Что нового?";
            this.buttonWhatNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWhatNew.UseVisualStyleBackColor = false;
            this.buttonWhatNew.Click += new System.EventHandler(this.buttonWhatNew_Click);
            this.buttonWhatNew.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            this.buttonWhatNew.MouseHover += new System.EventHandler(this.MenuButton_MouseHover);
            // 
            // exitButton
            // 
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(0, 555);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(464, 65);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выход";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.LeaveMenuButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.LeaveMenuButton_MouseHover);
            // 
            // multiplayerBtn
            // 
            this.multiplayerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiplayerBtn.BackColor = System.Drawing.Color.Transparent;
            this.multiplayerBtn.FlatAppearance.BorderSize = 0;
            this.multiplayerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.multiplayerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.multiplayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplayerBtn.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.multiplayerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplayerBtn.Location = new System.Drawing.Point(0, 417);
            this.multiplayerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiplayerBtn.Name = "multiplayerBtn";
            this.multiplayerBtn.Size = new System.Drawing.Size(464, 65);
            this.multiplayerBtn.TabIndex = 4;
            this.multiplayerBtn.Text = "Текстурпаки";
            this.multiplayerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.multiplayerBtn.UseVisualStyleBackColor = false;
            this.multiplayerBtn.Click += new System.EventHandler(this.button1_Click);
            this.multiplayerBtn.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            this.multiplayerBtn.MouseHover += new System.EventHandler(this.MenuButton_MouseHover);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Мультиплеер";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiplayerBtn);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonWhatNew);
            this.Controls.Add(this.buttonDifficulty);
            this.Controls.Add(this.fastGameButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button multiplayerBtn;

        private System.Windows.Forms.Button fastGameButton;
        private System.Windows.Forms.Button buttonDifficulty;
        private System.Windows.Forms.Button buttonWhatNew;
        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}