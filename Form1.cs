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
        private FileWriter fw;
        private List<String> formattedText = new List<String>();
        private OpenFileDialog openFileDialog1;
        private string filepath;
        private string outputFilepath;
        private FolderBrowserDialog openOutputFolderDialog;
        private List<String> firstText = new List<String>();
        private string method = "none";
        private bool invalid;

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
            firstText.Clear();
            outputTextbox.Clear();
        }

        private void RunEncryptionMethod(string method,List<String> firstText,bool encrypt)
        {
            switch (method)
            {
                case ("caesar"):
                    CaesarCypher cc = new CaesarCypher();
                    int shiftBy = Convert.ToInt32(shiftByUD.Value);
                    switch (encrypt)
                    {
                        case (true):
                            for (int i = 0; i < firstText.Count; i++)
                            {
                                formattedText.Add(cc.EncryptLine(firstText[i], shiftBy));
                            }
                            break;
                        case (false):
                            for (int i = 0; i < firstText.Count; i++)
                            {
                                formattedText.Add(cc.DecryptLine(firstText[i], shiftBy));
                            }
                            break;
                    }
                    break;
                case ("keyword"):
                    KeywordEncryption ke = new KeywordEncryption();
                    string keyword = keywordTextbox.Text;
                    invalid = ke.CheckKeyword(invalid, keyword);
                    if (invalid == false)
                    {
                        switch (encrypt)
                        {
                            case (true):
                                formattedText = ke.Encrypt(firstText, keyword);
                                break;
                            case (false):
                                formattedText = ke.Decrypt(firstText, keyword);
                                break;
                        }
                    }
                    break;
            }
        }

        private void CheckIfClear()
        {
            invalid = false;
            if ((filePathTextbox.Text).Equals("") || (methodCB.Text).Equals("") || (methodCB.Text).Equals(null) || (conversionMethodCB.Text).Equals("") || (conversionMethodCB.Text).Equals(null) || (outputPathTextbox.Text).Equals(""))
            {
                invalid = true;
            }
            else if ((keywordTextbox.Text).Equals("") && shiftByUD.Value == 0)
            {
                invalid = true;
            }
        }

        //Action run upon clicking the convert button
        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckIfClear();
                if (invalid == true)
                {
                    MessageBox.Show("Error: All fields should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ClearVariables();
                firstText = fr.ReadData(filepath);
                switch (methodCB.Text)
                {
                    case ("Encrypt File"):
                        RunEncryptionMethod(method, firstText, true);
                        break;
                    case ("Decrypt File"):
                        RunEncryptionMethod(method, firstText, false);
                        break;
                }
                if(invalid == true)
                {
                    MessageBox.Show("Error: Keyword must use alphabetical characters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
                shiftByUD.Enabled = true;
                keywordTextbox.ReadOnly = true;
                keywordTextbox.Clear();
                method = "caesar";
            }
            else if((conversionMethodCB.Text).Equals("Keyword Encryption"))
            {
                shiftByUD.Enabled = false;
                keywordTextbox.ReadOnly = false;
                shiftByUD.Value = 0;
                method = "keyword";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            outputTextbox.Clear();
            filePathTextbox.Clear();
            outputPathTextbox.Clear();
            conversionMethodCB.SelectedItem = null;
            method = "";
            methodCB.SelectedItem = null;
            keywordTextbox.Clear();
            shiftByUD.Value = 0;
            keywordTextbox.ReadOnly = true;
            shiftByUD.Enabled = false;
        }
    }
}