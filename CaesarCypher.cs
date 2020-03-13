using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor_and_Decryptor
{
    public class CaesarCypher : Cypher //Child class CaesarCypher, inherits from Cypher class
    {
        //Class field
        private int shiftBy;

        //Encrypts a character by a given integer; returns encrypted character
        private char ShiftPTE(char plainChar)
        {
            int plainVal = char.ToUpper(plainChar) - 65;
            int encVal = plainVal + shiftBy;
            encVal %= 26;
            char encChar = (char)(encVal + 65);
            return encChar;
        }

        //Decrypts a character by a given integer; returns decrypted character
        private char ShiftETP(char encChar)
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

        //Encrypts text, returns List
        public override List<string> Encrypt()
        {
            List<String> encryptedList = new List<String>(); //New list
            string encryptedLine = ""; //Temp new string
            for (int i = 0; i < myText.Count; i++) //For each line to encrypt
            {
                encryptedLine = "";
                for (int j = 0; j < myText[i].Length; j++) //For each character in line
                {
                    if (IsPunctuation(myText[i][j]) || IsNumber(myText[i][j]) || IsWhiteSpace(myText[i][j])) //Checks if character is letter
                    {
                        encryptedLine += myText[i][j]; //If not, then don't encrypt
                    }
                    else
                    {
                        encryptedLine += ShiftPTE(myText[i][j]); //Otherwise, encrypt
                    }
                }
                encryptedList.Add(encryptedLine); //Add lines to list
            }
            return encryptedList;
        }

        //Decrypts text, returns List
        public override List<String> Decrypt()
        {
            List<String> decryptedList = new List<String>(); //New list
            string decryptedLine = ""; //Temp new string
            for (int i = 0; i < myText.Count; i++) //For each line to decrypt
            {
                decryptedLine = "";
                for (int j = 0; j < myText[i].Length; j++) //For each character in line
                {
                    if (IsPunctuation(myText[i][j]) || IsNumber(myText[i][j]) || IsWhiteSpace(myText[i][j])) //Checks if character is letter
                    {
                        decryptedLine += myText[i][j]; //If not, then don't encrypt
                    }
                    else
                    {
                        decryptedLine += ShiftETP(myText[i][j]); //Otherwise, encrypt
                    }
                }
                decryptedList.Add(decryptedLine); //Add lines to list
            }
            return decryptedList;
        }

        public CaesarCypher(List<String> inputText, int sb) : base(inputText)
        {
            sb %= 26;
            shiftBy = sb;
        }
    }
}
