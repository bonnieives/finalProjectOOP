using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectOOP
{

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        // When you click the button for Lotto Max, it will open a new window
        // to generate the Lotto Max numbers
        private void lottoMaxBtn_Click(object sender, EventArgs e)
        {
            lottoMax lottoMax = new lottoMax();
            lottoMax.ShowDialog();
        }
        // When you click the button for Lotto 649, it will open a new window
        // to generate the Lotto Max numbers
        private void lottoExtraBtn_Click(object sender, EventArgs e)
        {
            lotto649 lotto649 = new lotto649();
            lotto649.ShowDialog();
        }
        // This will be activated when you click the button for
        // Money Exchange, opening a new window for it
        private void moneyExchange_Click(object sender, EventArgs e)
        {
            MoneyExchange moneyExchange = new MoneyExchange();
            moneyExchange.ShowDialog();
        }
        // This will be activated when you click the button for
        // Temperature Conversion, opening a new window for it
        private void tempConvert_Click(object sender, EventArgs e)
        {
            TempConv tempConv = new TempConv();
            tempConv.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.ShowDialog();
        }

        private void ipVerifier_Click(object sender, EventArgs e)
        {
            Ip4Validator ip4Validator = new Ip4Validator();
            ip4Validator.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit all applications?",
                "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
