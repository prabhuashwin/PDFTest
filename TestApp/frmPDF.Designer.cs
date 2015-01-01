namespace TestApp
{
    partial class frmMain
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
            this.filedlgOpenPDFfile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.txtpdfFileInput = new System.Windows.Forms.TextBox();
            this.lblSizeText = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblSizeTextName = new System.Windows.Forms.Label();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpdffileOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.folderBrowdiagPdf = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // filedlgOpenPDFfile
            // 
            this.filedlgOpenPDFfile.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select PDF File :";
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(358, 38);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 28);
            this.btnselect.TabIndex = 8;
            this.btnselect.Text = "Input";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // txtpdfFileInput
            // 
            this.txtpdfFileInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpdfFileInput.Location = new System.Drawing.Point(11, 43);
            this.txtpdfFileInput.Name = "txtpdfFileInput";
            this.txtpdfFileInput.ReadOnly = true;
            this.txtpdfFileInput.Size = new System.Drawing.Size(341, 20);
            this.txtpdfFileInput.TabIndex = 7;
            // 
            // lblSizeText
            // 
            this.lblSizeText.AutoSize = true;
            this.lblSizeText.Location = new System.Drawing.Point(12, 121);
            this.lblSizeText.Name = "lblSizeText";
            this.lblSizeText.Size = new System.Drawing.Size(123, 13);
            this.lblSizeText.TabIndex = 10;
            this.lblSizeText.Text = "Selected PDF file size is ";
            this.lblSizeText.Visible = false;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(136, 121);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(0, 13);
            this.lblFileSize.TabIndex = 11;
            this.lblFileSize.Visible = false;
            // 
            // lblSizeTextName
            // 
            this.lblSizeTextName.AutoSize = true;
            this.lblSizeTextName.Location = new System.Drawing.Point(12, 151);
            this.lblSizeTextName.Name = "lblSizeTextName";
            this.lblSizeTextName.Size = new System.Drawing.Size(184, 13);
            this.lblSizeTextName.TabIndex = 12;
            this.lblSizeTextName.Text = "How many files do you want to create";
            this.lblSizeTextName.Visible = false;
            // 
            // txtFileSize
            // 
            this.txtFileSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFileSize.Location = new System.Drawing.Point(204, 148);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(40, 20);
            this.txtFileSize.TabIndex = 12;
            this.txtFileSize.Visible = false;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(248, 143);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(62, 28);
            this.btnSplit.TabIndex = 14;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Visible = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select a Output Location";
            // 
            // txtpdffileOutput
            // 
            this.txtpdffileOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpdffileOutput.Location = new System.Drawing.Point(12, 87);
            this.txtpdffileOutput.Name = "txtpdffileOutput";
            this.txtpdffileOutput.ReadOnly = true;
            this.txtpdffileOutput.Size = new System.Drawing.Size(341, 20);
            this.txtpdffileOutput.TabIndex = 15;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(359, 83);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 28);
            this.btnOutput.TabIndex = 17;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 304);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpdffileOutput);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.lblSizeTextName);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblSizeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.txtpdfFileInput);
            this.Name = "frmMain";
            this.Text = "PDF Splitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog filedlgOpenPDFfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtpdfFileInput;
        private System.Windows.Forms.Label lblSizeText;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblSizeTextName;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpdffileOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowdiagPdf;
    }
}

