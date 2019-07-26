using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor_and_Decryptor
{
    class CaesarCypher
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

        //Encrypts a character by a given integer; returns encrypted character
        private char ShiftPTE(char plainChar, int shiftBy)
        {
            int plainVal = char.ToUpper(plainChar) - 65;
            int encVal = plainVal + shiftBy;
            encVal %= 26;
            char encChar = (char)(encVal + 65);
            return encChar;
        }

        //Decrypts a character by a given integer; returns decrypted character
        private char ShiftETP(char encChar, int shiftBy)
        {
            int encVal = char.ToUpper(encChar) - 65;
            int plainVal = encVal - shiftBy;
            if (plainVal < 0)
            {
                plainVal += 26;
            }
            char plainChar = (char)(plainVal + 65);
            return plainChar;
        }

        //Takes a line; encrypts and checks if special character cases; returns encrypted line
        public string EncryptLine(string line, int shiftBy)
        {
            shiftBy %= 26;
            string encryptedLine = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (IsPunctuation(line[i]) || IsNumber(line[i]) || IsWhiteSpace(line[i]))
                {
                    encryptedLine += line[i];
                }
                else
                {
                    encryptedLine += ShiftPTE(line[i], shiftBy);
                }
            }
            return encryptedLine;
        }

        //Takes a line; decrypts it and checks is special character cases; returns decrypted line
        public string DecryptLine(string line, int shiftBy)
        {
            shiftBy %= 26;
            string decryptedLine = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (IsPunctuation(line[i]))
                {
                    decryptedLine += line[i];
                }
                else if (IsWhiteSpace(line[i]))
                {
                    decryptedLine += " ";
                }
                else
                {
                    decryptedLine += ShiftETP(line[i], shiftBy);
                }
            }
            return decryptedLine;
        }
    }
}
