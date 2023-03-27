namespace finalProjectOOP
{
    partial class lottoMax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lottoMax));
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.exitMax = new System.Windows.Forms.Button();
            this.readFileMax = new System.Windows.Forms.Button();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.titleMaxLabel = new System.Windows.Forms.Label();
            this.generateMax = new System.Windows.Forms.Button();
            this.labelMax7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMax.Image")));
            this.pictureBoxMax.Location = new System.Drawing.Point(22, 65);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(325, 235);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMax.TabIndex = 11;
            this.pictureBoxMax.TabStop = false;
            // 
            // exitMax
            // 
            this.exitMax.Location = new System.Drawing.Point(327, 354);
            this.exitMax.Name = "exitMax";
            this.exitMax.Size = new System.Drawing.Size(104, 39);
            this.exitMax.TabIndex = 10;
            this.exitMax.Text = "E&xit";
            this.exitMax.UseVisualStyleBackColor = true;
            this.exitMax.Click += new System.EventHandler(this.exitMax_Click);
            // 
            // readFileMax
            // 
            this.readFileMax.Location = new System.Drawing.Point(168, 354);
            this.readFileMax.Name = "readFileMax";
            this.readFileMax.Size = new System.Drawing.Size(104, 39);
            this.readFileMax.TabIndex = 9;
            this.readFileMax.Text = "&Read file";
            this.readFileMax.UseVisualStyleBackColor = true;
            this.readFileMax.Click += new System.EventHandler(this.readFileMax_Click);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(371, 16);
            this.textBoxMax.Multiline = true;
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(60, 284);
            this.textBoxMax.TabIndex = 8;
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleMaxLabel
            // 
            this.titleMaxLabel.AutoSize = true;
            this.titleMaxLabel.Location = new System.Drawing.Point(18, 16);
            this.titleMaxLabel.Name = "titleMaxLabel";
            this.titleMaxLabel.Size = new System.Drawing.Size(190, 20);
            this.titleMaxLabel.TabIndex = 7;
            this.titleMaxLabel.Text = "The winning numbers are:";
            // 
            // generateMax
            // 
            this.generateMax.Location = new System.Drawing.Point(22, 354);
            this.generateMax.Name = "generateMax";
            this.generateMax.Size = new System.Drawing.Size(104, 39);
            this.generateMax.TabIndex = 6;
            this.generateMax.Text = "&Generate";
            this.generateMax.UseVisualStyleBackColor = true;
            this.generateMax.Click += new System.EventHandler(this.generateMax_Click);
            // 
            // labelMax7
            // 
            this.labelMax7.AutoSize = true;
            this.labelMax7.Location = new System.Drawing.Point(42, 316);
            this.labelMax7.Name = "labelMax7";
            this.labelMax7.Size = new System.Drawing.Size(0, 20);
            this.labelMax7.TabIndex = 12;
            // 
            // lottoMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 418);
            this.Controls.Add(this.labelMax7);
            this.Controls.Add(this.pictureBoxMax);
            this.Controls.Add(this.exitMax);
            this.Controls.Add(this.readFileMax);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.titleMaxLabel);
            this.Controls.Add(this.generateMax);
            this.Name = "lottoMax";
            this.Text = " Lotto Max - Bonnie";
            this.Load += new System.EventHandler(this.lottoMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.Button exitMax;
        private System.Windows.Forms.Button readFileMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label titleMaxLabel;
        private System.Windows.Forms.Button generateMax;
        private System.Windows.Forms.Label labelMax7;
    }
}