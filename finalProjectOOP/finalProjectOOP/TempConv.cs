using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace finalProjectOOP
{
    public partial class TempConv : Form
    {
        // Declaring the structures to be used into the classes
        // that will manipulate the generated files
        FileStream fileStream;
        StreamWriter textOut;
        StreamReader textIn;
        // Declaring the structure to be used for showing the dates
        DateTime date;
        // Declaring the path to write the file
        string pathDir = @".\Files\";
        string file = "TempConv.txt";
        // Declaring the temperatures
        double temperatureIn;
        double temperatureOut;
        // Declaring a string to the message
        string message;
        string unityIn;
        string unityOut;
        public TempConv()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // Returning the font to its regular style to remove
            // former styles used on this application
             textBoxMessage.Font = new Font(textBoxMessage.Font, FontStyle.Regular);

            // Declaring the objects to manipulate the files
            string filePath = pathDir + file;
            fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fileStream);

            // Reseting the temperatures
            temperatureIn = 0;
            temperatureOut = 0;

            // ------------------ BLOCK TO CONVER FROM C TO F  -----------

            // Checking the conversions
            try
            {
                // Removing all the blank spaces
                textBoxIn.Text = textBoxIn.Text.Trim().Replace(" ", "");
                // Checking the conversion from string to double
                temperatureIn = Convert.ToDouble(textBoxIn.Text);
            }
            catch (Exception ex)
            {
                // If the string is invalid, it will show
                // the message declaring the error
                MessageBox.Show(ex.Message);
                textBoxOut.Text = "";
                textBoxOut.Focus();
            }

            if (radioFromCtoF.Checked == true)
            {                
                
                // Calulating the temperature that will be displayed
                // into the out text box
                temperatureOut = Math.Round(((temperatureIn * ((double)9 / 5)) + 32), 0);
                textBoxOut.Text = temperatureOut.ToString();
                // Storing the temperature into a string
                unityIn = "C";
                unityOut = "F";
            }

            // ------------------ BLOCK TO CONVER FROM F TO C  -----------

            else if (radioFromFtoC.Checked == true)
            {
                // Calulating the temperature that will be displayed
                // into the out text box
                temperatureOut = Math.Round((temperatureIn - 32) * ((double)5 / 9), 1);
                textBoxOut.Text = temperatureOut.ToString();
                // Storing the temperature into a string
                unityIn = "F";
                unityOut = "C";
            }

            // ---------------- BLOCK TO WORK WITH THE MESSAGE ---------

            // Printing the text for the results into the text box.
            // I will base the print on celsius temperature.
            if (radioFromCtoF.Checked == true)
            {
                temperatureOut = temperatureIn;
            }
            // Conditionals to show the message on each interval
            if (temperatureOut > 100)
            {
                message = "Water boiling.";
            }
            else if (temperatureOut == 100)
            {
                message = "Water boils.";
                textBoxMessage.Font = new Font(textBoxMessage.Font, FontStyle.Bold);
            }
            else if (temperatureOut < 100 && temperatureOut > 40)
            {
                message = "TOO hot for bath.";
            }
            else if (temperatureOut == 40)
            {
                message = "Hot bath.";
                textBoxMessage.Font = new Font(textBoxMessage.Font, FontStyle.Bold);
            }
            else if (temperatureOut < 40 && temperatureOut > 37)
            {
                message = "Fever, maybe?";
            }
            else if (temperatureOut == 37)
            {
                message = "Body temperature";
                textBoxMessage.Font = new Font(textBoxMessage.Font, FontStyle.Bold);
            }
            else if (temperatureOut < 37 && temperatureOut > 21)
            {
                message = "Air conditioner recomended.";
            }
            else if (temperatureOut == 21)
            {
                message = "Room temperature.";
            }
            else if (temperatureOut < 21 && temperatureOut > 10)
            {
                message = "Starting to get cold, right?";
            }
            else if (temperatureOut == 10)
            {
                message = "Cool day";
                textBoxMessage.Font = new Font(textBoxMessage.Font, FontStyle.Bold);
            }
            else if (temperatureOut < 10 && temperatureOut > 0)
            {
                message = "Welcome to canadian Summer.";
            }
            else if (temperatureOut == 0)
            {
                message = "Very cold day.";
                textBoxMessage.Font = new Font(textBoxMessage.Font, FontStyle.Bold);
            }
            else if (temperatureOut < 0 && temperatureOut > -40)
            {
                message = "Welcome to canadian Fall";
            }
            else if (temperatureOut == -40)
            {
                message = "Extremely Cold Day (and the same number!)";
                textBoxMessage.Font = new Font(textBoxMessage.Font, FontStyle.Bold);
            }
            else if (temperatureOut < -40)
            {
                message = "The winter is coming.";
            }

            // --------------- BLOCK TO MANIPULATE THE FILE ------------
            
            // Writing the text into the file
            textOut.Write(temperatureIn + unityIn + " = " + temperatureOut +
            unityOut + ", " + DateTime.Now.ToString("yyyy'/'M'/'dd - hh:mm:ss tt - ") 
            + message + "\n");
            textOut.Close();

            // Showing the message into the text box
            textBoxMessage.Text = message;
        }
        // Changing the label
        private void radioFromCtoF_CheckedChanged(object sender, EventArgs e)
        {
            // changing the label when the radio button from C to F is
            // checked
            labelIn.Text = "C";
            labelOut.Text = "F";
        }
        // Changing the label
        private void radioFromFtoC_CheckedChanged(object sender, EventArgs e)
        {
            // changing the label when the radio button from F to C is
            // checked
            labelIn.Text = "F";
            labelOut.Text = "C";
        }
        // Block to read the file and to show it in a new window
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            string filePath = pathDir + file;
            try
            {// Instantiating the object textIn which readt the file
             // in the indicated path
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
                    list += "-- " + row.ToString() + "\n";
                    counter++;
                    if (counter == 5)
                    {
                        // The list will be shown into a new window
                        MessageBox.Show(list, "Temperature log");
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
        // Activating when click on exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ",
                "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void TempConv_Load(object sender, EventArgs e)
        {
            // If the directory do not exists, we create it here
            string filePath = pathDir + file;
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }
        }
    }
}
