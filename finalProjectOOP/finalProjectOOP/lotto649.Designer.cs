namespace finalProjectOOP
{
    partial class lotto649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lotto649));
            this.label649_7 = new System.Windows.Forms.Label();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.exit649 = new System.Windows.Forms.Button();
            this.readFile649 = new System.Windows.Forms.Button();
            this.textBox649 = new System.Windows.Forms.TextBox();
            this.titleMax649 = new System.Windows.Forms.Label();
            this.generateMax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label649_7
            // 
            this.label649_7.AutoSize = true;
            this.label649_7.Location = new System.Drawing.Point(45, 318);
            this.label649_7.Name = "label649_7";
            this.label649_7.Size = new System.Drawing.Size(0, 20);
            this.label649_7.TabIndex = 19;
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMax.Image")));
            this.pictureBoxMax.Location = new System.Drawing.Point(25, 67);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(325, 235);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax.TabIndex = 18;
            this.pictureBoxMax.TabStop = false;
            // 
            // exit649
            // 
            this.exit649.Location = new System.Drawing.Point(330, 356);
            this.exit649.Name = "exit649";
            this.exit649.Size = new System.Drawing.Size(104, 39);
            this.exit649.TabIndex = 17;
            this.exit649.Text = "E&xit";
            this.exit649.UseVisualStyleBackColor = true;
            this.exit649.Click += new System.EventHandler(this.exit649_Click);
            // 
            // readFile649
            // 
            this.readFile649.Location = new System.Drawing.Point(171, 356);
            this.readFile649.Name = "readFile649";
            this.readFile649.Size = new System.Drawing.Size(104, 39);
            this.readFile649.TabIndex = 16;
            this.readFile649.Text = "&Read file";
            this.readFile649.UseVisualStyleBackColor = true;
            this.readFile649.Click += new System.EventHandler(this.readFile649_Click);
            // 
            // textBox649
            // 
            this.textBox649.Location = new System.Drawing.Point(374, 18);
            this.textBox649.Multiline = true;
            this.textBox649.Name = "textBox649";
            this.textBox649.Size = new System.Drawing.Size(60, 284);
            this.textBox649.TabIndex = 15;
            this.textBox649.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleMax649
            // 
            this.titleMax649.AutoSize = true;
            this.titleMax649.Location = new System.Drawing.Point(21, 18);
            this.titleMax649.Name = "titleMax649";
            this.titleMax649.Size = new System.Drawing.Size(190, 20);
            this.titleMax649.TabIndex = 14;
            this.titleMax649.Text = "The winning numbers are:";
            // 
            // generateMax
            // 
            this.generateMax.Location = new System.Drawing.Point(25, 356);
            this.generateMax.Name = "generateMax";
            this.generateMax.Size = new System.Drawing.Size(104, 39);
            this.generateMax.TabIndex = 13;
            this.generateMax.Text = "&Generate";
            this.generateMax.UseVisualStyleBackColor = true;
            this.generateMax.Click += new System.EventHandler(this.generateMax_Click);
            // 
            // lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 416);
            this.Controls.Add(this.label649_7);
            this.Controls.Add(this.pictureBoxMax);
            this.Controls.Add(this.exit649);
            this.Controls.Add(this.readFile649);
            this.Controls.Add(this.textBox649);
            this.Controls.Add(this.titleMax649);
            this.Controls.Add(this.generateMax);
            this.Name = "lotto649";
            this.Text = "lotto649";
            this.Load += new System.EventHandler(this.lotto649_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label649_7;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.Button exit649;
        private System.Windows.Forms.Button readFile649;
        private System.Windows.Forms.TextBox textBox649;
        private System.Windows.Forms.Label titleMax649;
        private System.Windows.Forms.Button generateMax;
    }
}