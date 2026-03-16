using System;
using System.Drawing;
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
                "Обновление 1.0\n-Исправление ИИ крупье\n-Изменение интерфейса\n-Убрали кнопку 'Проверить обновления'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TexturePaks texturePaks = new TexturePaks();
            texturePaks.Show();
            this.Hide();
        }
        
        private void MenuButton_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Font = new Font(button.Font, FontStyle.Underline^FontStyle.Bold);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Font = new Font(button.Font, FontStyle.Bold);
        }
        
        private void LeaveMenuButton_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Font = new Font(button.Font, FontStyle.Underline^FontStyle.Bold);
            button.ForeColor = Color.LightPink;
        }

        private void LeaveMenuButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Font = new Font(button.Font, FontStyle.Bold);
            button.ForeColor = Color.White;
        }
    }
}