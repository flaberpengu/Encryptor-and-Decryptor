using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encryptor_and_Decryptor
{
    class FileWriter
    {
        //Adds file name to end of folder path based on if encryption or decryption was performed
        private string GetPath(string p, bool encrypt)
        {
            string path = p;
            switch (encrypt)
            {
                case (true):
                    path += "\\encryptedtext.txt";
                    break;
                case (false):
                    path += "\\plaintext.txt";
                    break;
            }
            return path;
        }

        //Writes text line by line to file
        public void WriteToFile(string p, List<String> myText, bool encrypt)
        {
            string path = GetPath(p, encrypt);
            using (StreamWriter sw = new StreamWriter(path))
            {
                for(int i = 0; i < myText.Count; i++)
                {
                    sw.WriteLine(myText[i]);
                }
                sw.Close();
            }
        }
    }
}
