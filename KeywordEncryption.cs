using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor_and_Decryptor
{
    class KeywordEncryption
    {
        //Checks if the character is a space; if so, returns true
        private bool IsWhiteSpace(char ch)
        {
            bool isWhiteSpace = false;
            if ((ch.ToString()).Equals(" "))
            {
                isWhiteSpace = true;
            }
            return isWhiteSpace;
        }

        //Checks if character is punctuation; if so, returns true
        private bool IsPunctuation(char ch)
        {
            bool isPunctuation = false;
            String[] punctuation = { ",", ".", "/", "?", ":", ";", "<", ">", "'", "@", "#", "~", "[", "]", "{", "}", "!", "\"", "£", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "\\", "|", "`", "¬" };
            foreach (string s in punctuation)
            {
                if ((ch.ToString()).Equals(s))
                {
                    isPunctuation = true;
                }
            }
            return isPunctuation;
        }

        //Checks if character is number; if so, returns true
        private bool IsNumber(char ch)
        {
            bool isNumber = false;
            String[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            foreach (string number in numbers)
            {
                if ((ch.ToString()).Equals(number))
                {
                    isNumber = true;
                }
            }
            return isNumber;
        }

        private char AddChars(char initialChar, char keyChar)
        {
            int initialVal = char.ToUpper(initialChar) - 64;
            int keyVal = char.ToUpper(keyChar) - 64;
            int combinedVal = initialVal + keyVal;
            combinedVal %= 27;
            combinedVal++;
            char finalChar = (char)(combinedVal + 64);
            return finalChar;
        }

        private char SubChars(char initialChar, char keyChar)
        {
            int initialVal = char.ToUpper(initialChar) - 64;
            int keyVal = char.ToUpper(keyChar) - 64;
            int combinedVal = initialVal - keyVal;
            if (combinedVal <= 0)
            {
                combinedVal += 26;
            }
            char finalChar = (char)(combinedVal + 64);
            return finalChar;
        }

        private List<String> ArrayToList(string[] original)
        {
            List<String> final = new List<string>();
            for (int i = 0; i < original.Length; i++)
            {
                final.Add(original[i]);
            }
            return final;
        }
        public List<String> Encrypt(List<String> firstText, string keyword)
        {
            string allText = String.Join("@'@#@#@#@!><", firstText);
            string[] splitters = { "@'@#@#@#@!><" };
            string newText = "";
            List<String> newTextList = new List<String>();
            Char[] keywordChars = new Char[keyword.Length];
            for (int i = 0; i < keyword.Length; i++)
            {
                keywordChars[i] = keyword[i];
            }
            int count = 0;
            for (int i = 0; i < allText.Length; i++)
            {
                if (IsWhiteSpace(allText[i]) || IsNumber(allText[i]) || IsPunctuation(allText[i]))
                {
                    newText += (allText[i]);
                }
                else
                {
                    newText += AddChars(allText[i], keyword[count]);
                }
                count++;
                count %= ((keyword.Length) - 1);
            }
            string[] newTextArray = newText.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            newTextList = ArrayToList(newTextArray);
            return newTextList;
        }

        public List<String> Decrypt(List<String> firstText, string keyword)
        {
            string allText = String.Join("@'@#@#@#@!><", firstText);
            string[] splitters = { "@'@#@#@#@!><" };
            string newText = "";
            List<String> newTextList = new List<String>();
            Char[] keywordChars = new Char[keyword.Length];
            for (int i = 0; i < keyword.Length; i++)
            {
                keywordChars[i] = keyword[i];
            }
            int count = 0;
            for (int i = 0; i < allText.Length; i++)
            {
                if (IsWhiteSpace(allText[i]) || IsNumber(allText[i]) || IsPunctuation(allText[i]))
                {
                    newText += (allText[i]);
                }
                else
                {
                    newText += SubChars(allText[i], keyword[count]);
                }
                count++;
                count %= ((keyword.Length) - 1);
            }
            string[] newTextArray = newText.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            newTextList = ArrayToList(newTextArray);
            return newTextList;
        }
    }
}
//FIX KE (ENCRYPT AND) DECRYPT
//CHANGE DEFAULT TO ALL DISABLED OPTIONS
//ADD CLEAR BUTTON (AFTER MERGING)