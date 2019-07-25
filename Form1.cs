using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace caesar_cypher_file_IO_final
{
    public partial class Form1 : Form
    {
        //Declare variables needed in program
        private FileReader fr;
        private int shiftBy;
        private FileWriter fw;
        private List<String> formattedText;
        private OpenFileDialog openFileDialog1;
        private CaesarCypher cc;
        private string filepath;
        private string outputFilepath;
        private FolderBrowserDialog openOutputFolderDialog;
        private List<String> plainText = new List<String>();
        private List<String> encryptedText = new List<String>();
        //Constructor
        public Form1()
        {
            InitializeComponent();
            fr = new FileReader();
            cc = new CaesarCypher();
            fw = new FileWriter();
        }
        //Opens input file dialog form
        private void OpenFileDialogForm()
        {
            openFileDialog1 = new OpenFileDialog();
            { openFileDialog1.Filter = "Text files (*.txt)|*.txt"; openFileDialog1.Title = "Open text file"; };
        }
        //Sets input file path in the input file textbox
        private void SetPathText()
        {
            filePathTextbox.Text = filepath;
        }
        //Opens output folder dialog form
        private void OpenOutputFolderDialogForm()
        {
            openOutputFolderDialog = new FolderBrowserDialog();
        }
        //Sets output folder path in the output folder textbox
        private void SetOutputPathText()
        {
            outputPathTextbox.Text = outputFilepath;
        }
        //Action to run upon clicking input file select button
        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialogForm();
            //If file is chosen and returned correctly, do actions
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                SetPathText();
            }
            //Clears dialog form
            openFileDialog1.Dispose();
        }
        private void SetOutputText(List<String> formText)
        {
            outputTextbox.Text = String.Join(Environment.NewLine, formText);
        }
        private void ClearOutputText()
        {
            outputTextbox.Clear();
        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                plainText.Clear();
                encryptedText.Clear();
                ClearOutputText();
                shiftBy = Convert.ToInt32(shiftByUD.Value);
                if ((methodCB.Text).Equals("Encrypt File"))
                {
                    plainText = fr.ReadData(filepath);
                    for (int i = 0; i < plainText.Count; i++)
                    {
                        encryptedText.Add(cc.EncryptLine(plainText[i], shiftBy));
                    }
                    formattedText = encryptedText;
                }
                else if ((methodCB.Text).Equals("Decrypt File"))
                {
                    encryptedText = fr.ReadData(filepath);
                    for (int i = 0; i < encryptedText.Count; i++)
                    {
                        plainText.Add(cc.DecryptLine(encryptedText[i], shiftBy));
                    }
                    formattedText = plainText;
                }
                //formattedText = fw.FormatText(mdArray);
                SetOutputText(formattedText);
                if ((methodCB.Text).Equals("Encrypt File"))
                {
                    fw.GivePath(outputFilepath, true);
                }
                else if ((methodCB.Text).Equals("Decrypt File"))
                {
                    fw.GivePath(outputFilepath, false);
                }
                fw.WriteData();
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(exception.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OutputFileSelectButton_Click(object sender, EventArgs e)
        {
            OpenOutputFolderDialogForm();
            if (openOutputFolderDialog.ShowDialog() == DialogResult.OK)
            {
                outputFilepath = openOutputFolderDialog.SelectedPath;
                SetOutputPathText();
            }
            openOutputFolderDialog.Dispose();
        }
    }
    class FileWriter
    {
        private string path;
        private List<String> formattedList = new List<string>();
        public List<String> FormatText(string[][] unfText)
        {
            formattedList.Clear();
            for (int i = 0; i < unfText.Length; i++)
            {
                string temp = "";
                for (int j = 0; j < unfText[i].Length; j++)
                {
                    temp = temp + (unfText[i][j]) + " ";
                }
                formattedList.Add(temp);
            }
            return formattedList;
        }
        public void WriteData()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < formattedList.Count; i++)
                {
                    sw.WriteLine(formattedList[i]);
                }
                sw.Close();
            }
        }
        private void SortPath(bool encrypt)
        {
            switch (encrypt)
            {
                case (true):
                    path += "\\encryptedtext.txt";
                    break;
                case (false):
                    path += "\\plaintext.txt";
                    break;
            }
        }
        public void GivePath(string p, bool encrypt)
        {
            path = p;
            SortPath(encrypt);
        }
    }
}
