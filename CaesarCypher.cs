using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor_and_Decryptor
{
    public class CaesarCypher : Cypher
    {
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

        public override List<string> Encrypt()
        {
            List<String> encryptedList = new List<String>();
            string encryptedLine = "";
            for (int i = 0; i < myText.Count; i++)
            {
                encryptedLine = "";
                for (int j = 0; j < myText[i].Length; j++)
                {
                    if (IsPunctuation(myText[i][j]) || IsNumber(myText[i][j]) || IsWhiteSpace(myText[i][j]))
                    {
                        encryptedLine += myText[i][j];
                    }
                    else
                    {
                        encryptedLine += ShiftPTE(myText[i][j]);
                    }
                }
                encryptedList.Add(encryptedLine);
            }
            return encryptedList;
        }

        public override List<String> Decrypt()
        {
            List<String> decryptedList = new List<String>();
            string decryptedLine = "";
            for (int i = 0; i < myText.Count; i++)
            {
                decryptedLine = "";
                for (int j = 0; j < myText[i].Length; j++)
                {
                    if (IsPunctuation(myText[i][j]) || IsNumber(myText[i][j]) || IsWhiteSpace(myText[i][j]))
                    {
                        decryptedLine += myText[i][j];
                    }
                    else
                    {
                        decryptedLine += ShiftETP(myText[i][j]);
                    }
                }
                decryptedList.Add(decryptedLine);
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
