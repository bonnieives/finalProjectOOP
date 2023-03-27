namespace finalProjectOOP
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lottoExtraLabel = new System.Windows.Forms.Label();
            this.lottoMaxLabl = new System.Windows.Forms.Label();
            this.lottoMaxBtn = new System.Windows.Forms.Button();
            this.lottoExtraBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moneyExchange = new System.Windows.Forms.Button();
            this.tempConvert = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ipVerifier = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(23, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(460, 303);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lottoExtraLabel);
            this.tabPage1.Controls.Add(this.lottoMaxLabl);
            this.tabPage1.Controls.Add(this.lottoMaxBtn);
            this.tabPage1.Controls.Add(this.lottoExtraBtn);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(452, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "";
            this.tabPage1.Text = "Numbers Generator";
            this.tabPage1.ToolTipText = "Lotto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lottoExtraLabel
            // 
            this.lottoExtraLabel.AutoSize = true;
            this.lottoExtraLabel.Location = new System.Drawing.Point(279, 224);
            this.lottoExtraLabel.Name = "lottoExtraLabel";
            this.lottoExtraLabel.Size = new System.Drawing.Size(87, 20);
            this.lottoExtraLabel.TabIndex = 3;
            this.lottoExtraLabel.Text = "Lotto Extra";
            // 
            // lottoMaxLabl
            // 
            this.lottoMaxLabl.AutoSize = true;
            this.lottoMaxLabl.Location = new System.Drawing.Point(66, 224);
            this.lottoMaxLabl.Name = "lottoMaxLabl";
            this.lottoMaxLabl.Size = new System.Drawing.Size(79, 20);
            this.lottoMaxLabl.TabIndex = 2;
            this.lottoMaxLabl.Text = "Lotto Max";
            // 
            // lottoMaxBtn
            // 
            this.lottoMaxBtn.Image = ((System.Drawing.Image)(resources.GetObject("lottoMaxBtn.Image")));
            this.lottoMaxBtn.Location = new System.Drawing.Point(19, 32);
            this.lottoMaxBtn.Name = "lottoMaxBtn";
            this.lottoMaxBtn.Size = new System.Drawing.Size(189, 180);
            this.lottoMaxBtn.TabIndex = 1;
            this.lottoMaxBtn.UseVisualStyleBackColor = true;
            this.lottoMaxBtn.Click += new System.EventHandler(this.lottoMaxBtn_Click);
            // 
            // lottoExtraBtn
            // 
            this.lottoExtraBtn.Image = ((System.Drawing.Image)(resources.GetObject("lottoExtraBtn.Image")));
            this.lottoExtraBtn.Location = new System.Drawing.Point(228, 32);
            this.lottoExtraBtn.Name = "lottoExtraBtn";
            this.lottoExtraBtn.Size = new System.Drawing.Size(189, 180);
            this.lottoExtraBtn.TabIndex = 2;
            this.lottoExtraBtn.UseVisualStyleBackColor = true;
            this.lottoExtraBtn.Click += new System.EventHandler(this.lottoExtraBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(440, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Convertors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.moneyExchange);
            this.groupBox2.Controls.Add(this.tempConvert);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(440, 258);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperature Convert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Money Exchange";
            // 
            // moneyExchange
            // 
            this.moneyExchange.Image = ((System.Drawing.Image)(resources.GetObject("moneyExchange.Image")));
            this.moneyExchange.Location = new System.Drawing.Point(21, 23);
            this.moneyExchange.Name = "moneyExchange";
            this.moneyExchange.Size = new System.Drawing.Size(189, 180);
            this.moneyExchange.TabIndex = 4;
            this.moneyExchange.UseVisualStyleBackColor = true;
            this.moneyExchange.Click += new System.EventHandler(this.moneyExchange_Click);
            // 
            // tempConvert
            // 
            this.tempConvert.Image = ((System.Drawing.Image)(resources.GetObject("tempConvert.Image")));
            this.tempConvert.Location = new System.Drawing.Point(230, 23);
            this.tempConvert.Name = "tempConvert";
            this.tempConvert.Size = new System.Drawing.Size(189, 180);
            this.tempConvert.TabIndex = 6;
            this.tempConvert.UseVisualStyleBackColor = true;
            this.tempConvert.Click += new System.EventHandler(this.tempConvert_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(452, 270);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(123, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 218);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ipVerifier);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(452, 270);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IP v4 Validator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ipVerifier
            // 
            this.ipVerifier.Image = ((System.Drawing.Image)(resources.GetObject("ipVerifier.Image")));
            this.ipVerifier.Location = new System.Drawing.Point(133, 16);
            this.ipVerifier.Name = "ipVerifier";
            this.ipVerifier.Size = new System.Drawing.Size(192, 241);
            this.ipVerifier.TabIndex = 0;
            this.ipVerifier.Text = "button7";
            this.ipVerifier.UseVisualStyleBackColor = true;
            this.ipVerifier.Click += new System.EventHandler(this.ipVerifier_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(344, 331);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(135, 46);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 396);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.tabControl);
            this.Name = "mainForm";
            this.Text = "Bonnie 2330019";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lottoExtraLabel;
        private System.Windows.Forms.Label lottoMaxLabl;
        private System.Windows.Forms.Button lottoMaxBtn;
        private System.Windows.Forms.Button lottoExtraBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button moneyExchange;
        private System.Windows.Forms.Button tempConvert;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ipVerifier;
        private System.Windows.Forms.Button exitBtn;
    }
}

