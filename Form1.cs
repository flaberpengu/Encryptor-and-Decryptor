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
        private readonly FileReader fr;
        private readonly FileWriter fw;
        private List<String> formattedText = new List<String>();
        private OpenFileDialog openFileDialog1;
        private string filepath;
        private string outputFilepath;
        private OpenFileDialog openOutputFileDialog;
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
        private void OpenOutputFileDialogForm()
        {
            openOutputFileDialog = new OpenFileDialog();
            { openOutputFileDialog.Filter = "Text files (*.txt)|*.txt"; openOutputFileDialog.Title = "Open text file"; };
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

        private void RunCaesarCypher(List<String> firstText, bool encrypt)
        {
            int shiftBy = Convert.ToInt32(shiftByUD.Value);
            Cypher cypher = new CaesarCypher(firstText, shiftBy);
            if (encrypt)
            {
                formattedText = cypher.Encrypt();
            }
            else if (!encrypt)
            {
                formattedText = cypher.Decrypt();
            }
        }

        private void RunKeywordCypher(List<String> firstText, bool encrypt)
        {
            string keyword = (keywordTextbox.Text).ToUpper();
            Cypher cypher = new KeywordCypher(firstText, keyword);
            invalid = cypher.CheckKeyword(invalid, keyword);
            if (!invalid)
            {
                if (encrypt)
                {
                    formattedText = cypher.Encrypt();
                }
                else if (!encrypt)
                {
                    formattedText = cypher.Decrypt();
                }
            }
        }

        //Main method that runs whichever conversion method is chosen
        private void RunEncryptionMethod(string method,List<String> firstText,bool encrypt)
        {
            switch (method)
            {
                case ("caesar"):
                    RunCaesarCypher(firstText, encrypt);
                    break;
                case ("keyword"):
                    RunKeywordCypher(firstText, encrypt);
                    break;
            }
        }

        //Checks if any fields are clear, assigns value to boolean 'invalid'
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
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks fields aren't clear
                CheckIfClear();
                if (invalid)
                {
                    MessageBox.Show("Error: All fields should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Exits from try, catch
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
                //Checks for invalid keyword inside RunEncryptionMethod. If invalid, stops running further
                if(invalid)
                {
                    MessageBox.Show("Error: Keyword must use alphabetical characters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SetOutputText(formattedText);
                //Writes converted text to file
                fw.WriteToFile(outputFilepath, formattedText);
            }
            //Catch exceptions, display messages
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
            OpenOutputFileDialogForm();
            if (openOutputFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFilepath = openOutputFileDialog.FileName;
                SetOutputPathText();
            }
            openOutputFileDialog.Dispose();
        }

        //Runs when text is changed in ConversionMethodCB
        private void ConversionMethodCB_TextChanged(object sender, EventArgs e)
        {
            //Enables and disabled input boxes as required, clears input boxes, sets method variable
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

        //Runs when ClearButton is pressed - clears and resets all input and output boxes
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
//COMMENT, REORDER, CLEAN CODE