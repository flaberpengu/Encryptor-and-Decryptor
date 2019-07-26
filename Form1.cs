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

namespace Encryptor_and_Decryptor
{
    public partial class Form1 : Form
    {
        //Declare variables needed in program
        private FileReader fr;
        private int shiftBy;
        private FileWriter fw;
        private List<String> formattedText = new List<String>();
        private OpenFileDialog openFileDialog1;
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

        //Puts output text into textbox
        private void SetOutputText(List<String> formText)
        {
            outputTextbox.Text = String.Join(Environment.NewLine, formText);
        }

        //Clears lists and output text
        private void ClearVariables()
        {
            formattedText.Clear();
            plainText.Clear();
            encryptedText.Clear();
            outputTextbox.Clear();
        }

        private void RunEncryptionMethod()
        {
            if ()
        }

        //Action run upon clicking the convert button
        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                CaesarCypher cc = new CaesarCypher();
                ClearVariables();
                shiftBy = Convert.ToInt32(shiftByUD.Value);
                if ((methodCB.Text).Equals("Encrypt File"))
                {
                    plainText = fr.ReadData(filepath);
                    for (int i = 0; i < plainText.Count; i++)
                    {
                        formattedText.Add(cc.EncryptLine(plainText[i], shiftBy));
                    }
                }
                else if ((methodCB.Text).Equals("Decrypt File"))
                {
                    encryptedText = fr.ReadData(filepath);
                    for (int i = 0; i < encryptedText.Count; i++)
                    {
                        formattedText.Add(cc.DecryptLine(encryptedText[i], shiftBy));
                    }
                }
                SetOutputText(formattedText);
                if ((methodCB.Text).Equals("Encrypt File"))
                {
                    fw.WriteToFile(outputFilepath, formattedText, true);
                }
                else if ((methodCB.Text).Equals("Decrypt File"))
                {
                    fw.WriteToFile(outputFilepath, formattedText, false);
                }
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

        //Action to run upon clicking output folder select button
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

        private void ConversionMethodCB_TextChanged(object sender, EventArgs e)
        {
            if ((conversionMethodCB.Text).Equals("Caesar Cypher"))
            {
                keywordTextbox.ReadOnly = true;
            }
            else if((conversionMethodCB.Text).Equals("Keyword Encryption"))
            {
                keywordTextbox.ReadOnly = false;
            }
        }
    }
}
//RUN METHODS
//CREATE KEYWORD CYPHER CLASS