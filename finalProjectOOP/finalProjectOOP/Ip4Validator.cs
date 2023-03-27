using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalProjectOOP
{
    public partial class Ip4Validator : Form
    {
        // Declaring the object to store the time
        // Time open store the time when the application is open
        DateTime timeOpen = DateTime.Now;
        // Declaring the structures to be used into the classes
        // that will manipulate the generated files
        FileStream binaryStream;
        BinaryWriter binaryOut;
        BinaryReader binaryIn;
        // Declaring the structure to be used for showing the dates
        DateTime date;
        // Declaring the path to write the file
        string pathDir = @".\Files\";
        string file = "BinaryIPv4.txt";
        public Ip4Validator()
        {
            InitializeComponent();
        }
        // As the application is open, the date time will be displayed
        // on the window in the empty label above the text box
        private void Ip4Validator_Load(object sender, EventArgs e)
        {
            // Set to verify if the directory already exists.
            string filepath = pathDir + file;
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }
            // Set to print the actual time
            string loadTime;
            loadTime = DateTime.Now.ToLongDateString();
            labelShow.Text = "Today : " + loadTime;
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            string pathBinary = pathDir + file;
            binaryStream = new FileStream(pathBinary, FileMode.Append, FileAccess.Write);
            binaryOut = new BinaryWriter(binaryStream);
            // Declaring variables
            // starting reading the text into the text box
            string ipInput = textBoxIn.Text;
            // each octet (in decimal form) will be displayed
            // into an array of octet
            string[] octets;
            // declaring the message of validation as an empty string
            string messageValidation = "";
            // Declaring message of IP class as an empty string
            string messageClassIP = "";
            // Whn the input is informed, it will be trimmed to remove
            // unecessary white spaces and the single white spaces
            // remaining will be replaced by an empty string
            ipInput = ipInput.Trim().Replace(" ", "");
            // Then it will display the corrected entry
            textBoxIn.Text = ipInput;
            // the input will be split using a dot as a separator
            // and stored inside the array octets
            octets = ipInput.Split('.');
            // The regex object is declared here
            Regex ipValidation = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-5][0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-5][0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-5][0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-5][0-5])$");
            // Testing if the object matches with the input
            if (ipValidation.IsMatch(ipInput) == true)
            {
                messageValidation = "This IP is correct";
                // The set of if will verify the first octet to
                // show the class of the IP
                if (Convert.ToInt16(octets[0]) > 0 && Convert.ToInt16(octets[0]) < 128)
                {
                    messageClassIP = "Class A IP";
                }
                else if (Convert.ToInt16(octets[0]) > 128 && Convert.ToInt16(octets[0]) < 192)
                {
                    messageClassIP = "Class B IP";
                }
                else if (Convert.ToInt16(octets[0]) > 192 && Convert.ToInt16(octets[0]) < 224)
                {
                    messageClassIP = "Class C IP";
                }
                else if (Convert.ToInt16(octets[0]) > 224 && Convert.ToInt16(octets[0]) < 240)
                {
                    messageClassIP = "Class C IP";
                }
                else
                {
                    messageClassIP = "Class E IP";
                }
                // The message box will show the ip input, the class of the IP,
                // and the message of validation
                MessageBox.Show(ipInput + "\n" + messageClassIP +
                    "\n" + messageValidation, "Valid IP");
                // The ip input is written here considering as a string
                binaryOut.Write(ipInput);
            }
            else
            {
                // The message box shows the user the correct entry format.
                MessageBox.Show(ipInput + "\n" + "The IP must have 4 bytes\ninteger numbers" +
                    "between 1 to 255 on the first interval, and between 0 to 255 on the other" +
                    "intervals\nseparated by a dot (255.255.255.255)", "Error");
            }
            // The binary file is closed
            binaryOut.Close();
        }
        // When the button reset is pressed, the text box is emptied
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxIn.Text = string.Empty;
            textBoxIn.Focus();
        }
        // When exit button is pressed, it will ask the user if
        // they want to leave the application, and it will
        // show the elapsed time
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application:\nIPv4 Validator?",
                "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                // The elapsed time is calculated by considering
                // the time when the application is loaded
                // subtracted to the time the application
                // is closed.
                DateTime timeClose = DateTime.Now;
                TimeSpan timeSpan = timeClose - timeOpen;
                MessageBox.Show("Elapsed time: " + timeSpan.ToString(@"mm\:ss"), "Session closed");
                this.Close();
            }
        }
    }
}
