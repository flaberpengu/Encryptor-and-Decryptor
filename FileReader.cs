using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace caesar_cypher_file_IO_final
{
    class FileReader
    {
        public List<String> ReadData(string path)
        {
            List<String> myText = new List<String>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    myText.Add(sr.ReadLine());
                }
                sr.Close();
            }
            return myText;
        }
    }
}
