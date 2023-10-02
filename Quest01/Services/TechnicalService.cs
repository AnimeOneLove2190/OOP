using System;
using System.Collections.Generic;
using System.Text;
using Quest01.Computers;

namespace Quest01.Services
{
    class TechnicalService
    {
        public string CheckWebcam(bool webcam)
        {
            if (webcam)
            {
                return "да";
            }
            else
            {
                return "нет";
            }
        }
        public string CheckType(TypeOfShell type)
        {
            if (type == TypeOfShell.Vertical)
            {
                return "вертикальный";
            }
            if (type == TypeOfShell.Horizontal)
            {
                return "горизонтальный";
            }
            return "квантовая суперпозиция";
        }
        public string CheckMaterial(BodyMaterial material)
        {
            if (material == BodyMaterial.Plastic)
            {
                return "пластик";
            }
            if (material == BodyMaterial.Metal)
            {
                return "металл";
            }
            if (material == BodyMaterial.Wood)
            {
                return "дерево";
            }
            return "антивещество";
        }
        public void WriteDictionary(Dictionary<char, int> dictionary)
        {
            foreach (KeyValuePair<char, int> symbol in dictionary)
            {
                Console.WriteLine($"{symbol.Key} - {symbol.Value}");
            }
        }
        public void WriteDictionary(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> symbol in dictionary)
            {
                Console.WriteLine($"{symbol.Key} - {symbol.Value}");
            }
        }
        public string ClearText(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в начальном сегменте ClearText");
                return null;
            }
            char[] copy = new char[text.Length];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = text[i];
            }
            const char Space = (char)32;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsPunctuation(text[i]))
                {
                    if (copy[i] == '-')
                    {
                        continue;
                    }
                    copy[i] = Space;
                }
            }
            string textCopy = new string(copy);
            textCopy = textCopy.ToLower();
            while (textCopy.Contains("  "))
            {
                textCopy = textCopy.Replace("  ", " ");
            }
            while (textCopy.Contains(" - "))
            {
                textCopy = textCopy.Replace(" - ", " ");
            }
            if (char.IsWhiteSpace(textCopy[0]))
            {
                textCopy = textCopy.Trim();
            }
            if (string.IsNullOrEmpty(textCopy))
            {
                Console.WriteLine("Сработала защита в последнем сегменте ClearText");
                return null;
            }
            return textCopy;
        }
    }
}
