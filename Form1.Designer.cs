namespace Encryptor_and_Decryptor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputFileSelectButton = new System.Windows.Forms.Button();
            this.outputPathTextbox = new System.Windows.Forms.TextBox();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.shiftByUD = new System.Windows.Forms.NumericUpDown();
            this.shiftByLabel = new System.Windows.Forms.Label();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.methodCB = new System.Windows.Forms.ComboBox();
            this.ConversionLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.conversionMethodCB = new System.Windows.Forms.ComboBox();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.keywordTextbox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shiftByUD)).BeginInit();
            this.SuspendLayout();
            // 
            // outputFileSelectButton
            // 
            this.outputFileSelectButton.Location = new System.Drawing.Point(704, 373);
            this.outputFileSelectButton.Name = "outputFileSelectButton";
            this.outputFileSelectButton.Size = new System.Drawing.Size(50, 51);
            this.outputFileSelectButton.TabIndex = 23;
            this.outputFileSelectButton.Text = "...";
            this.outputFileSelectButton.UseVisualStyleBackColor = true;
            this.outputFileSelectButton.Click += new System.EventHandler(this.OutputFileSelectButton_Click);
            // 
            // outputPathTextbox
            // 
            this.outputPathTextbox.Location = new System.Drawing.Point(199, 373);
            this.outputPathTextbox.Multiline = true;
            this.outputPathTextbox.Name = "outputPathTextbox";
            this.outputPathTextbox.ReadOnly = true;
            this.outputPathTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputPathTextbox.Size = new System.Drawing.Size(504, 51);
            this.outputPathTextbox.TabIndex = 22;
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFileLabel.Location = new System.Drawing.Point(26, 386);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(113, 25);
            this.outputFileLabel.TabIndex = 21;
            this.outputFileLabel.Text = "Output File:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(199, 480);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(143, 66);
            this.convertButton.TabIndex = 20;
            this.convertButton.Text = "Convert and Save";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputTextbox
            // 
            this.outputTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputTextbox.Location = new System.Drawing.Point(1061, 33);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextbox.Size = new System.Drawing.Size(775, 514);
            this.outputTextbox.TabIndex = 19;
            this.outputTextbox.Text = "Output...";
            // 
            // shiftByUD
            // 
            this.shiftByUD.Enabled = false;
            this.shiftByUD.Location = new System.Drawing.Point(199, 323);
            this.shiftByUD.Name = "shiftByUD";
            this.shiftByUD.Size = new System.Drawing.Size(54, 20);
            this.shiftByUD.TabIndex = 18;
            // 
            // shiftByLabel
            // 
            this.shiftByLabel.AutoSize = true;
            this.shiftByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftByLabel.Location = new System.Drawing.Point(26, 321);
            this.shiftByLabel.Name = "shiftByLabel";
            this.shiftByLabel.Size = new System.Drawing.Size(85, 25);
            this.shiftByLabel.TabIndex = 17;
            this.shiftByLabel.Text = "Shift By:";
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Location = new System.Drawing.Point(704, 37);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(50, 51);
            this.fileSelectButton.TabIndex = 16;
            this.fileSelectButton.Text = "...";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Location = new System.Drawing.Point(199, 37);
            this.filePathTextbox.Multiline = true;
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.ReadOnly = true;
            this.filePathTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filePathTextbox.Size = new System.Drawing.Size(504, 51);
            this.filePathTextbox.TabIndex = 15;
            // 
            // methodCB
            // 
            this.methodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodCB.FormattingEnabled = true;
            this.methodCB.Items.AddRange(new object[] {
            "Encrypt File",
            "Decrypt File"});
            this.methodCB.Location = new System.Drawing.Point(199, 124);
            this.methodCB.Name = "methodCB";
            this.methodCB.Size = new System.Drawing.Size(146, 21);
            this.methodCB.TabIndex = 14;
            // 
            // ConversionLabel
            // 
            this.ConversionLabel.AutoSize = true;
            this.ConversionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversionLabel.Location = new System.Drawing.Point(26, 122);
            this.ConversionLabel.Name = "ConversionLabel";
            this.ConversionLabel.Size = new System.Drawing.Size(118, 25);
            this.ConversionLabel.TabIndex = 13;
            this.ConversionLabel.Text = "Conversion:";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLabel.Location = new System.Drawing.Point(26, 35);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(106, 25);
            this.FileLabel.TabIndex = 12;
            this.FileLabel.Text = "Input File:";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLabel.Location = new System.Drawing.Point(26, 192);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(84, 25);
            this.methodLabel.TabIndex = 24;
            this.methodLabel.Text = "Method:";
            // 
            // conversionMethodCB
            // 
            this.conversionMethodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conversionMethodCB.FormattingEnabled = true;
            this.conversionMethodCB.Items.AddRange(new object[] {
            "Caesar Cypher",
            "Keyword Encryption"});
            this.conversionMethodCB.Location = new System.Drawing.Point(199, 192);
            this.conversionMethodCB.Name = "conversionMethodCB";
            this.conversionMethodCB.Size = new System.Drawing.Size(146, 21);
            this.conversionMethodCB.TabIndex = 25;
            this.conversionMethodCB.TextChanged += new System.EventHandler(this.ConversionMethodCB_TextChanged);
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordLabel.Location = new System.Drawing.Point(26, 255);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(95, 25);
            this.keywordLabel.TabIndex = 26;
            this.keywordLabel.Text = "Keyword:";
            // 
            // keywordTextbox
            // 
            this.keywordTextbox.Location = new System.Drawing.Point(199, 257);
            this.keywordTextbox.Name = "keywordTextbox";
            this.keywordTextbox.ReadOnly = true;
            this.keywordTextbox.Size = new System.Drawing.Size(504, 20);
            this.keywordTextbox.TabIndex = 27;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(427, 480);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(143, 66);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1006);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.keywordTextbox);
            this.Controls.Add(this.keywordLabel);
            this.Controls.Add(this.conversionMethodCB);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.outputFileSelectButton);
            this.Controls.Add(this.outputPathTextbox);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.shiftByUD);
            this.Controls.Add(this.shiftByLabel);
            this.Controls.Add(this.fileSelectButton);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.methodCB);
            this.Controls.Add(this.ConversionLabel);
            this.Controls.Add(this.FileLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shiftByUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button outputFileSelectButton;
        private System.Windows.Forms.TextBox outputPathTextbox;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.NumericUpDown shiftByUD;
        private System.Windows.Forms.Label shiftByLabel;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.ComboBox methodCB;
        private System.Windows.Forms.Label ConversionLabel;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.ComboBox conversionMethodCB;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.TextBox keywordTextbox;
        private System.Windows.Forms.Button clearButton;
    }
}

