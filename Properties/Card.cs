using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Drawing;
using System.IO;


namespace CardLib
{
    public class Card
    {
        public bool hiden = false;
        public byte id = 0;
        public byte suit = 0;
        private Dictionary<byte, string> cards = new Dictionary<byte, string>()
        {
            { 0, "1" },
            { 1, "2" },
            { 2, "3" },
            { 3, "4" },
            { 4, "5" },
            { 5, "6" },
            { 6, "7" },
            { 7, "8" },
            { 8, "9" },
            { 9, "10" },
            { 10, "Валет" },
            { 11, "Дама" },
            { 12, "Король" },
            { 13, "Туз" }
        };

        private Dictionary<byte, string> suits = new Dictionary<byte, string>()
        {
            { 0, "Черви" },
            { 1, "Пики" },
            { 2, "Бубны" },
            { 3, "Крести" }
        };

        private Dictionary<byte, byte> price = new Dictionary<byte, byte>()
        {
            { 0, 1 },
            { 1, 2 },
            { 2, 3 },
            { 3, 4 },
            { 4, 5 },
            { 5, 6 },
            { 6, 7 },
            { 7, 8 },
            { 8, 9 },
            { 9, 10 },
            { 10, 10 },
            { 11, 10 },
            { 12, 10 },
            { 13, 11 }
        };
        

        public Card(byte inputId, byte inputSuit)
        {
            id = inputId;
            suit = inputSuit;
        }
        
        public string CardName()
        {
            return cards[id] + " " + suits[suit];
        }
        

        public int GetPrice()
        {
            return price[id];
        }

        public Image CardImage()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Формируем полный путь к изображению 0.png
            string imagePath = Path.Combine(basePath, "Images", "0.png");
            Image cardImage = Image.FromFile(imagePath);

            if (!hiden)
            {
                // Формируем полный путь к изображению с учетом масти и идентификатора
                string cardName = $"{id}.png";
                string suitPath = Path.Combine(basePath, "Images", suit.ToString(), cardName);
                cardImage = Image.FromFile(suitPath);
            }
            return cardImage;
        }
    }
}