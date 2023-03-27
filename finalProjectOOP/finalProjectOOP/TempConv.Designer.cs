namespace finalProjectOOP
{
    partial class TempConv
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
            this.radioFromFtoC = new System.Windows.Forms.RadioButton();
            this.radioFromCtoF = new System.Windows.Forms.RadioButton();
            this.labelOut = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioFromFtoC
            // 
            this.radioFromFtoC.AutoSize = true;
            this.radioFromFtoC.Location = new System.Drawing.Point(169, 72);
            this.radioFromFtoC.Name = "radioFromFtoC";
            this.radioFromFtoC.Size = new System.Drawing.Size(113, 24);
            this.radioFromFtoC.TabIndex = 45;
            this.radioFromFtoC.TabStop = true;
            this.radioFromFtoC.Text = "from F to C";
            this.radioFromFtoC.UseVisualStyleBackColor = true;
            this.radioFromFtoC.CheckedChanged += new System.EventHandler(this.radioFromFtoC_CheckedChanged);
            // 
            // radioFromCtoF
            // 
            this.radioFromCtoF.AutoSize = true;
            this.radioFromCtoF.Location = new System.Drawing.Point(169, 16);
            this.radioFromCtoF.Name = "radioFromCtoF";
            this.radioFromCtoF.Size = new System.Drawing.Size(113, 24);
            this.radioFromCtoF.TabIndex = 44;
            this.radioFromCtoF.TabStop = true;
            this.radioFromCtoF.Text = "from C to F";
            this.radioFromCtoF.UseVisualStyleBackColor = true;
            this.radioFromCtoF.CheckedChanged += new System.EventHandler(this.radioFromCtoF_CheckedChanged);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOut.Location = new System.Drawing.Point(319, 183);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(20, 20);
            this.labelOut.TabIndex = 43;
            this.labelOut.Text = "F";
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn.Location = new System.Drawing.Point(110, 183);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(21, 20);
            this.labelIn.TabIndex = 42;
            this.labelIn.Text = "C";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(26, 217);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(78, 20);
            this.labelMessage.TabIndex = 41;
            this.labelMessage.Text = "Message:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(212, 147);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 20);
            this.labelTo.TabIndex = 40;
            this.labelTo.Text = "to";
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(271, 144);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(122, 26);
            this.textBoxOut.TabIndex = 39;
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(60, 144);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(122, 26);
            this.textBoxIn.TabIndex = 38;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(15, 240);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(407, 26);
            this.textBoxMessage.TabIndex = 37;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(323, 288);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(99, 32);
            this.buttonExit.TabIndex = 36;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(169, 288);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(99, 32);
            this.buttonReadFile.TabIndex = 35;
            this.buttonReadFile.Text = "&Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(15, 288);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(99, 32);
            this.buttonConvert.TabIndex = 34;
            this.buttonConvert.Text = "&Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // TempConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 341);
            this.Controls.Add(this.radioFromFtoC);
            this.Controls.Add(this.radioFromCtoF);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonConvert);
            this.Name = "TempConv";
            this.Text = "TempConv";
            this.Load += new System.EventHandler(this.TempConv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioFromFtoC;
        private System.Windows.Forms.RadioButton radioFromCtoF;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonConvert;
    }
}