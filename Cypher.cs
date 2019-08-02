using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor_and_Decryptor
{
    public abstract class Cypher
    {
        protected List<String> myText;

        public abstract List<String> Encrypt();

        public abstract List<String> Decrypt();

        //Checks if the character is a space; if so, returns true
        protected bool IsWhiteSpace(char ch)
        {
            bool isWhiteSpace = false;
            if ((ch.ToString()).Equals(" "))
            {
                isWhiteSpace = true;
            }
            return isWhiteSpace;
        }

        //Checks if character is punctuation; if so, returns true
        protected bool IsPunctuation(char ch)
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
        protected bool IsNumber(char ch)
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

        public virtual bool CheckKeyword(bool invalid, string keyword)
        {
            return invalid;
        }

        public Cypher(List<String> inputText)
        {
            myText = inputText;
        }
    }
}
