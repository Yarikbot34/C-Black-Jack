using System;
using System.Windows.Forms;
using BlackJack_0._2._1.Images;

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

        private void buttonDifficulty_Click(object sender, EventArgs e)
        {
            FormChangeDiff formChangeDiff = new FormChangeDiff();
            formChangeDiff.Show();
            this.Hide();
        }

        private void buttonWhatNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Обновление 0.2\n-Возможность выбора сложности\n-Список обновлений\nИсправленные ошибки:\n-Интерфейс блокируется после конца игры");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}