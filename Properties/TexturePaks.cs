using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using CardLib;

namespace BlackJack_0._2._1.Properties
{
    public partial class TexturePaks : Form
    {
        public TexturePaks()
        {
            InitializeComponent();
            string dirPaks = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CardTextures");
            String[] Paks = Directory.GetDirectories(dirPaks);
            Console.WriteLine("Paks found: " + Paks.Length);
            if (Paks.Length > 1)
            {
                Button[] buttons = new Button[Paks.Length];
                Point pos = new Point(300, 100);
                for (int i = 0; i < Paks.Length; i++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 40);
                    btn.BackColor = SystemColors.ActiveCaption;
                    btn.Text = Paks[i].Substring(Paks[i].LastIndexOf("\\") + 1);
                    btn.Location = pos;
                    pos = new Point(pos.X, pos.Y + 50);
                    btn.Click += setPack;
                    this.Controls.Add(btn);
                    btn.Show();
                    Console.WriteLine("Button is showed");
                    buttons[i] = btn;
                }
            }
            
        }

        private void setPack(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string Pak = btn.Text;
            Data.texturePack = "CardTextures/" + Pak;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Close();
        }
    }
}