namespace finalProjectOOP
{
    partial class Ip4Validator
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(275, 157);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(104, 39);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(152, 157);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(104, 39);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(29, 157);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(104, 39);
            this.buttonValidate.TabIndex = 17;
            this.buttonValidate.Text = "Validate IP";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(155, 89);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(247, 26);
            this.textBoxIn.TabIndex = 16;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(121, 19);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 20);
            this.labelShow.TabIndex = 15;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(15, 92);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(134, 20);
            this.mainLabel.TabIndex = 14;
            this.mainLabel.Text = "Enter IP Address:";
            // 
            // Ip4Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 232);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.mainLabel);
            this.Name = "Ip4Validator";
            this.Text = "Ip4Validator";
            this.Load += new System.EventHandler(this.Ip4Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label mainLabel;
    }
}