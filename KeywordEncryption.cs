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

        //Adds characters (encrypts characters)
        private char AddChars(char initialChar, char keyChar)
        {
            //Gets values of both characters
            int initialVal = char.ToUpper(initialChar) - 64;
            int keyVal = char.ToUpper(keyChar) - 64;
            int combinedVal = initialVal + keyVal;
            //Makes characters 'wrap around' from Z to A
            if (combinedVal > 26)
            {
                combinedVal %= 27;
                combinedVal++;
            }
            char finalChar = (char)(combinedVal + 64);
            return finalChar;
        }

        //Subtracts characters (decrypts characters)
        private char SubChars(char initialChar, char keyChar)
        {
            //Gets values of both characters
            int initialVal = char.ToUpper(initialChar) - 64;
            int keyVal = char.ToUpper(keyChar) - 64;
            int combinedVal = initialVal - keyVal;
            //Makes characters 'wrap around' from A to Z
            if (combinedVal <= 0)
            {
                combinedVal += 26;
            }
            char finalChar = (char)(combinedVal + 64);
            return finalChar;
        }

        //Converts an array of strings to a list of strings
        private List<String> ArrayToList(string[] original)
        {
            List<String> final = new List<string>();
            for (int i = 0; i < original.Length; i++)
            {
                final.Add(original[i]);
            }
            return final;
        }

        //Takes text, encrypts it, returns List
        public List<String> Encrypt(List<String> firstText, string keyword)
        {
            //Joins lines of text so encryption is easier (uses joiner that is highly unlikely to occur in any text file)
            string allText = String.Join("@'@#@#@#@!><", firstText);
            string[] splitters = { "@'@#@#@#@!><" };
            string newText = "";
            List<String> newTextList;
            //Splits keyword up into individual chars so that looping is easier later
            Char[] keywordChars = new Char[keyword.Length];
            for (int i = 0; i < keyword.Length; i++)
            {
                keywordChars[i] = keyword[i];
            }
            //count is the variable that tracks which keyword character will be used
            int count = 0;
            for (int i = 0; i < allText.Length; i++)
            {
                //If char is non-alphabetical, put into text as is
                if (IsWhiteSpace(allText[i]) || IsNumber(allText[i]) || IsPunctuation(allText[i]))
                {
                    newText += (allText[i]);
                }
                else
                {
                    newText += AddChars(allText[i], keyword[count]);
                }
                //Increment count, MOD to loop back to 0 if needed
                count++;
                count %= ((keyword.Length) - 1);
            }
            //Puts into array using splitter, converts to list
            string[] newTextArray = newText.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            newTextList = ArrayToList(newTextArray);
            return newTextList;
        }

        //Takes text, decrypts it, returns list
        public List<String> Decrypt(List<String> firstText, string keyword)
        {
            //Joins lines of text so encryption is easier (uses joiner that is highly unlikely to occur in any text file)
            string allText = String.Join("@'@#@#@#@!><", firstText);
            string[] splitters = { "@'@#@#@#@!><" };
            string newText = "";
            List<String> newTextList;
            //Splits keyword up into individual chars so that looping is easier later
            Char[] keywordChars = new Char[keyword.Length];
            for (int i = 0; i < keyword.Length; i++)
            {
                keywordChars[i] = keyword[i];
            }
            //count is the variable that tracks which keyword character will be used
            int count = 0;
            for (int i = 0; i < allText.Length; i++)
            {
                //If char is non-alphabetical, put into text as is
                if (IsWhiteSpace(allText[i]) || IsNumber(allText[i]) || IsPunctuation(allText[i]))
                {
                    newText += (allText[i]);
                }
                else
                {
                    newText += SubChars(allText[i], keyword[count]);
                }
                //Increment count, MOD to loop back to 0 if needed
                count++;
                count %= ((keyword.Length) - 1);
            }
            //Puts into array using splitter, converts to list
            string[] newTextArray = newText.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            newTextList = ArrayToList(newTextArray);
            return newTextList;
        }

        //Public method to check if keyword is invalid
        public bool CheckKeyword(bool invalid, string keyword)
        {
            //Splits keyword into individual chars
            char[] keyChars = new char[keyword.Length];
            for (int i = 0; i < keyword.Length; i++)
            {
                keyChars[i] = keyword[i];
            }
            //Keywords should only contain letters
            foreach (char ch in keyChars)
            {
                if (IsWhiteSpace(ch) || IsPunctuation(ch) || IsNumber(ch))
                {
                    invalid = true;
                }
            }
            return invalid;
        }
    }
}