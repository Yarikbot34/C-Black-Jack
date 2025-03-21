using System;
using System.Windows.Forms;

namespace BlackJack_0._2._1.Properties
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        

        private void fastGameButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(1);
            gameForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}