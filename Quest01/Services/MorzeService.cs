using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01.Services
{
    class MorzeService
    {
        readonly Dictionary<char, string> charToMorze = new Dictionary<char, string>
            {
                { 'a', ".-" },
                { 'b', "-..." },
                { 'c', "-.-." },
                { 'd', "-.." },
                { 'e', "." },
                { 'f', "..-." },
                { 'g', "--." },
                { 'h', "...." },
                { 'i', ".." },
                { 'j', ".---" },
                { 'k', "-.-" },
                { 'l', ".-.." },
                { 'm', "--" },
                { 'n', "-." },
                { 'o', "---" },
                { 'p', ".--." },
                { 'q', "--.-" },
                { 'r', ".-." },
                { 's', "..." },
                { 't', "-" },
                { 'u', "..-" },
                { 'v', "...-" },
                { 'w', ".--" },
                { 'x', "-..-" },
                { 'y', "-.--" },
                { 'z', "--.." },
                { '1', ".----" },
                { '2', "..---" },
                { '3', "...--" },
                { '4', "....-" },
                { '5', "....." },
                { '6', "-...." },
                { '7', "--..." },
                { '8', "---.." },
                { '9', "----." },
                { '0', "-----" },
                { ' ', " "}
            };
        readonly Dictionary<string, char> morzeToChar = new Dictionary<string, char>
            {
                {".-", 'a' },
                {"-...", 'b' },
                {"-.-.", 'c' },
                {"-..", 'd' },
                {".", 'e' },
                {"..-.", 'f' },
                {"--.", 'g' },
                {"....", 'h' },
                {"..", 'i' },
                {".---", 'j' },
                {"-.-", 'k' },
                {".-..", 'l' },
                {"--", 'm' },
                {"-.", 'n' },
                {"---", 'o' },
                {".--.", 'p' },
                {"--.-", 'q' },
                {".-.", 'r' },
                {"...", 's' },
                {"-", 't' },
                {"..-", 'u' },
                {"...-", 'v' },
                {".--", 'w' },
                {"-..-", 'x' },
                {"-.--", 'y' },
                {"--..", 'z' },
                {".----", '1' },
                {"..---", '2' },
                {"...--", '3' },
                {"....-", '4' },
                {".....", '5' },
                {"-....", '6' },
                {"--...", '7' },
                {"---..", '8' },
                {"----.", '9' },
                {"-----", '0' },
                { " ", ' '}
            };
        public string TranslateIntoMorze(string textMessage)
        {
            if (string.IsNullOrEmpty(textMessage) || string.IsNullOrWhiteSpace(textMessage))
            {
                Console.WriteLine("Catch in TranslateIntoMorze");
                return null;
            }
            textMessage = textMessage.ToLower();
            var morzeMessage = string.Empty;
            for (int i = 0; i < textMessage.Length; i++)
            {
                if (charToMorze.ContainsKey(textMessage[i]))
                {
                    morzeMessage = $"{morzeMessage}{charToMorze[textMessage[i]]}/";
                }
                else
                {
                    Console.WriteLine($"Символа _{textMessage[i]}_ не существует в азбуке Морзе");
                }
            }
            return morzeMessage;
        }
        public string TranslateFromMorze(string morzeMessage)
        {
            if (string.IsNullOrEmpty(morzeMessage) || string.IsNullOrWhiteSpace(morzeMessage))
            {
                Console.WriteLine("Catch in TranslateIntoMorze");
                return null;
            }
            var morzeArray = morzeMessage.Split("/");
            morzeMessage = morzeMessage.ToLower();
            var textMessage = string.Empty;
            for (int i = 0; i < morzeArray.Length; i++)
            {
                if (morzeToChar.ContainsKey(morzeArray[i]))
                {
                    textMessage = $"{textMessage}{morzeToChar[morzeArray[i]]}";
                }
                else
                {
                    Console.WriteLine($"Комбинации _{morzeMessage[i]}_ не существует в азбуке Морзе");
                }
            }
            return textMessage;
        }
    }
}
