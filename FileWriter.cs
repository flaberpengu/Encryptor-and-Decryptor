using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encryptor_and_Decryptor
{
    public class FileWriter
    {
        //Writes text line by line to file
        public void WriteToFile(string p, List<String> myText)
        {
            using (StreamWriter sw = new StreamWriter(p))
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
