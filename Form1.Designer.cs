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
            ((System.ComponentModel.ISupportInitialize)(this.shiftByUD)).BeginInit();
            this.SuspendLayout();
            // 
            // outputFileSelectButton
            // 
            this.outputFileSelectButton.Location = new System.Drawing.Point(704, 231);
            this.outputFileSelectButton.Name = "outputFileSelectButton";
            this.outputFileSelectButton.Size = new System.Drawing.Size(50, 51);
            this.outputFileSelectButton.TabIndex = 23;
            this.outputFileSelectButton.Text = "...";
            this.outputFileSelectButton.UseVisualStyleBackColor = true;
            this.outputFileSelectButton.Click += new System.EventHandler(this.OutputFileSelectButton_Click);
            // 
            // outputPathTextbox
            // 
            this.outputPathTextbox.Location = new System.Drawing.Point(199, 231);
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
            this.outputFileLabel.Location = new System.Drawing.Point(26, 244);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(113, 25);
            this.outputFileLabel.TabIndex = 21;
            this.outputFileLabel.Text = "Output File:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(199, 338);
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
            this.shiftByUD.Location = new System.Drawing.Point(199, 181);
            this.shiftByUD.Name = "shiftByUD";
            this.shiftByUD.Size = new System.Drawing.Size(54, 20);
            this.shiftByUD.TabIndex = 18;
            // 
            // shiftByLabel
            // 
            this.shiftByLabel.AutoSize = true;
            this.shiftByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftByLabel.Location = new System.Drawing.Point(26, 179);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1006);
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
    }
}

