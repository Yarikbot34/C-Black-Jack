using System;
using System.Windows.Forms;
using BlackJack_0._2._1.Properties;

namespace BlackJack_0._2._1.Images
{
    public partial class FormChangeDiff : Form
    {
        public FormChangeDiff()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Close();
        }

        private void buttonDiffEasy_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(1);
            gameForm.Show();
            this.Hide();
        }

        private void buttonDiffMedium_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(2);
            gameForm.Show();
            this.Hide();
        }

        private void buttonDiffHard_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(3);
            gameForm.Show();
            this.Hide();
        }
    }
}