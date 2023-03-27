using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalProjectOOP
{
    public partial class lottoMax : Form
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
        string file = "LottoNbrs.txt";
        // Declaring the random number
        Random random;
        // Declaring an array to store random numbers for print
        // into the number box
        int[] randomNumberBox;
        public lottoMax()
        {
            InitializeComponent();
        }
        // ----------- WORKING WITH THE TEXT BOX GENERATING NUMBERS BETWEEN
        // ----------- 1 AND 50
        private void generateMax_Click(object sender, EventArgs e)
        {
            // Starting to instantiating and declaring the variables for the numbers
            random = new Random();
            randomNumberBox = new int[8];

            // Declaring the objects to manipulate the files
            string filePath = pathDir + file;
            fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fileStream);

            // Declaring the object to manipulate the dates
            date = DateTime.Now;

            // ------------ BLOCK FOR TEXT BOX ---------------------

            // We must clear the text box for each iteration
            textBoxMax.Clear();

            // This first loop is used to generate eight numbers that
            // will be printed into the text box
            for (int i = 0; i < 8; i++)
            {
                // The number is generated and stored into the array
                randomNumberBox[i] = random.Next(1, 50);
                // This for loop pass through the array from the last index
                // to the first and checks if there is a repeated number
                for (int j = 0; j < i; j++)
                {
                    // If the random number into the verified index is equal
                    // to the number generated, it will generate another
                    // random number until it doesn't repeat anymore
                    while (randomNumberBox[j] == randomNumberBox[i])
                    {
                        randomNumberBox[i] = random.Next(1, 50);
                        // If it is repeated, it will restart the counter
                        // into the for loop so it can check it again
                        j = 0;
                    }
                }
                // It will print into the label2 the concatenated numbers
                textBoxMax.Text += randomNumberBox[i].ToString();
                //textBox1.AppendText(randomNumberBox[i].ToString());
                textBoxMax.AppendText(Environment.NewLine);

            }

            // ------------ BLOCK FOR LABEL ---------------------------

            // We must clear the label for each iteration
            labelMax7.Text = null;
            // randomNumber is an array of 7 items wich will store
            // the random number generated.
            int[] randomNumber = new int[7];
            // This for loop is used to generate seven random numbers
            // and to display into the label
            for (int i = 0; i < 7; i++)
            {
                // The number is generated and stored into the array
                randomNumber[i] = random.Next(0, 7);
                // This for loop pass through the array from the last index
                // to the first and checks if there is a repeated number
                for (int j = 0; j < i; j++)
                {
                    randomNumber[i] = random.Next(0, 7);
                }
                // It will print into the label2 the concatenated numbers
                labelMax7.Text += randomNumber[i].ToString() + " ";
            }

            // ---------------- BLOCK FOR FILES ----------------------------

            // Writing into the the file
            textOut.Write("Max, " + date.ToString(@"yyyy'/'M'/'dd - hh:mm:ss tt, "));
            // This next loop is used to store the information inside
            // the file
            for (int i = 0; i < randomNumberBox.Length - 1; i++)
            {
                // Storing the numbers into the file
                textOut.Write(randomNumberBox[i].ToString());
                if (i != randomNumberBox.Length - 2)
                {
                    textOut.Write(", ");
                }
            }
            // Now it prints the Bonus number, which is the last of the
            // serie randomNumber
            textOut.Write(" Bonus " + randomNumberBox[randomNumberBox.Length - 1] + "\n");
            // Closing the file
            textOut.Close();
        }
        // Activated when read file is clicked
        private void readFileMax_Click(object sender, EventArgs e)
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
                // Setting the counter so the text box will display
                // five registers per window
                int counter = 0;
                // Starting the loop and stoping when the index is equal to -1
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    // When the string starts with Max, it will store into the string
                    // list all the row
                    if (row.StartsWith("Max") == true)
                    {
                        list += row.ToString() + "\n";
                        // Incrementing the counter
                        counter++;
                    }
                    if (counter == 5)
                    {
                        // The list will be shown into a new window
                        MessageBox.Show(list, "Numbers log - Lotto Max");
                        counter = 0;
                        list = "";
                    }
                }
                if (counter != 0)
                {
                    // The list will be shown into a new window
                    MessageBox.Show(list, "Numbers log - Lotto Max");
                }
                textIn.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not created.");
                File.Create(filePath).Close();
            }
        }
        // Closes the application
        private void exitMax_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ",
                "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void lottoMax_Load(object sender, EventArgs e)
        {
            string filePath = pathDir + file;
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }
        }
    }
}
