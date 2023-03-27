using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace finalProjectOOP
{
    public partial class MoneyExchange : Form
    {
        // Declaring the structures to be used into the classes
        // that will manipulate the generated files
        FileStream fileStream;
        StreamWriter textOut;
        StreamReader textIn;
        // Declaring the time when the appliation is opened and
        // declaring the objects to manipulate the time.
        DateTime timeOpen;
        DateTime timeClose;
        TimeSpan timeSpan;
        // Declaring the path to write the file
        string pathDir = @".\Files\";
        string file = "MoneyConv.txt";
        public MoneyExchange()
        {
            InitializeComponent();
        }

        private void convertMoney_Click(object sender, EventArgs e)
        {
            // Declaring the objects to manipulate the file
            string filePath = pathDir + file;
            fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fileStream);

            // The exchanges were consulted on Wednesday 15th March 2023
            // The exchanges where normalizated all based on CAD (set as 1)
            // then consulted the exchange of 1 CAD to the other currency
            // for example, considering 1 CAD we have 0.73 USD
            double toCurrency = 0;
            double inCurrency = 0;
            double amount = 0;
            string currencyCodeIn = "";
            string currencyCodeOut = "";
            double finalAmount = 0;

            // Removing all blank spaces
            exchangeIn.Text = exchangeIn.Text.Trim().Replace(" ", "").Replace(",", "");
            
            // Verifying the conversion, if an invalid entry is used
            // the Exception message will be displayed
            try
            {
                amount = Convert.ToDouble(exchangeIn.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                exchangeIn.Focus();
                exchangeIn.Text = null;
            }

            // ------------------- BLOCK TO PERFORM THE EXCHANGE -----------

            // Verifying the format of the amount using Regex
            // It will acept as much digits as informed, but 
            // when using decimal numbers it will accept only
            // two digits
            Regex regex = new Regex(@"^([\d]+)[(\.)]?(\d{2})?$");
            // If the number is in the correct format, then this happens
            if (regex.IsMatch(amount.ToString()))
            {
                // This set of conditionals verifies the currency you want to exchange from
                // The set of radio buttons on the group From
                if (radioFromCAD.Checked == true)
                {
                    inCurrency = 1.00;
                    currencyCodeIn = "CAD";
                }
                else if (radioFromUSD.Checked == true)
                {
                    inCurrency = 0.73;
                    currencyCodeIn = "USD";
                }
                else if (radioFromEUR.Checked == true)
                {
                    inCurrency = 0.69;
                    currencyCodeIn = "EUR";
                }
                else if (radioFromGBP.Checked == true)
                {
                    inCurrency = 0.60;
                    currencyCodeIn = "GBP";
                }
                else if (radioFromBRL.Checked == true)
                {
                    inCurrency = 3.84;
                    currencyCodeIn = "BRL";
                }
                // This set of conditionals verifies the currency you want to exchange to
                // That is, this is the currency you convert to when you click
                // on the radio buttons in the group To
                if (radioToCAD.Checked == true)
                {
                    toCurrency = 1.00;
                    currencyCodeOut = "CAD";
                }
                else if (radioToUSD.Checked == true)
                {
                    toCurrency = 0.73;
                    currencyCodeOut = "USD";
                }
                else if (radioToEUR.Checked == true)
                {
                    toCurrency = 0.69;
                    currencyCodeOut = "EUR";
                }
                else if (radioToGBP.Checked == true)
                {
                    toCurrency = 0.60;
                    currencyCodeOut = "GBP";
                }
                else if (radioToBRL.Checked == true)
                {
                    toCurrency = 3.84;
                    currencyCodeOut = "BRL";
                }
                // Calculating the final amount using the formula
                // based on proportions
                finalAmount = Math.Round((amount * (toCurrency / inCurrency)), 2);

                // Shows the result into the second text box
                exchangeOut.Text = finalAmount.ToString();
                exchangeIn.Focus();

                // ---------------- BLOCK TO WORK WITH THE FILE

                // Writing into the file
                textOut.Write(amount.ToString() + " " + currencyCodeIn + " = "
                    + finalAmount.ToString() + " " + currencyCodeOut + ", " +
                    DateTime.Now.ToString("yyyy'/'M'/'dd - hh:mm:ss tt") + "\n");
                // Closing the file
                textOut.Close();
            }
            else
            {
                // Message box if the exception happens
                // Suggesting the right format to the user
                MessageBox.Show("Incorrect format.\nFormat examples: 123, 0.23, 123.30");
                exchangeIn.Text = "0";
                exchangeIn.Focus();
            }
        }
        // When the application is opened, the time starts to count
        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            // If the directory do not exists, we create it here
            string filePath = pathDir + file;
            timeOpen= DateTime.Now;
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }
        }
        // Method to read the file and to display it content in a window
        private void readExchange_Click(object sender, EventArgs e)
        {
            // Instantiating the object textIn which readt the file
            // in the indicated path
            string filePath = pathDir + file;
            try
            {
                textIn = new StreamReader(filePath);
                // Declaring an empty string list to store the read text
                // in the file
                string list = "";
                // Setting the counter
                int counter = 0;
                // Starting the loop and stoping when the index is equal to -1
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    list += row.ToString() + "\n";
                    counter++;
                    if (counter == 5)
                    {
                        // The list will be shown into a new window
                        MessageBox.Show(list, "Exchange log");
                        counter = 0;
                        list = "";
                    }
                }
                if (counter != 0)
                {
                    // The list will be shown into a new window
                    MessageBox.Show(list, "Exchange log");
                    counter = 0;
                    list = "";
                }
                textIn.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not created.");
                File.Create(filePath).Close();
            }          
        }
        // Closing the application
        private void exitExchange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application:\nMoney Exchange?",
                "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                // The time when closed is stored into timeClose
                timeClose = DateTime.Now;
                // Time span is the difference between the time when
                // closed and the time is open
                timeSpan = timeClose - timeOpen;
                MessageBox.Show("Elapsed time: " + timeSpan.ToString(@"mm\:ss"), "Session closed");
                this.Close();
            }
        }
    }
}
