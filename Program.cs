using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack_0._2._1.Properties;
using CrupieLib;
using StackLib;
using CardLib;

namespace BlackJack_0._2._1
{
    public static class Data
    {
        public static string texturePack = "CardTextures/Base";
        public static Point windowPosition = Point.Empty;
    }
    
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MenuForm menuForm = new MenuForm();
            Application.Run(menuForm);
        }
    }
}