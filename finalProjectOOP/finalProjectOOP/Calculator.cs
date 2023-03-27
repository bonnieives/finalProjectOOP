using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectOOP
{
    public partial class Calculator : Form
    {
        // Declaring the structures to be used into the classes
        // that will manipulate the generated files
        FileStream fileStream;
        StreamWriter textOut;
        StreamReader textIn;
        // Declaring the path to write the file
        string pathDir = @".\Files\";
        string file = "Calculator.txt";
        // Declaring the numbers
        CalculatorOperations number1;
        double number2;
        // Declaring strings
        string operation;
        public Calculator()
        {
            InitializeComponent();
        }
        // If the number 1 is clicked, then it will generate the number
        // 1, if the number 0 is already on the text box, it will
        // substitute it by 1, if not, it will concatenate the
        // number 1
        private void one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        // If the number 2 is clicked, then it will generate the number
        // 2, if the number 0 is already on the text box, it will
        // substitute it by 2, if not, it will concatenate the
        // number 2
        private void two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        // I don't need to repeat it, but the same from 1 and 2 is valid
        // here
        private void three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
        // I don't need to repeat it, but the same from 1 and 2 is valid
        // here
        private void four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        // again...
        private void five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }
        // Keep going
        private void six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }
        // Almost there...? No... (Too much click events)
        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }
        // LOL!!!!
        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        // NUMBER NEIN!
        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        // Finaly zero, amen!
        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        // Now something different. If you have zero in the text box
        // It will generate 0. / If the textbox already contains a dot
        // it will add nothing / else, it will add only the dot.
        private void point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0.";
            }
            else if (textBox1.Text.Contains(".") == true)
            {
                textBox1.Text += "";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
        // When you load the calculator, the textbox will
        // have the number 0 already there, the textbox will be focused
        // and the option ReadOnly will be activated.
        private void Calculator_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Focus();
            textBox1.ReadOnly = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            number1 = new CalculatorOperations(0);
            number2 = 0;
            textBox1.Text = "0";
            textBox1.Focus();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = new CalculatorOperations(Convert.ToDouble(textBox1.Text));
                textBox1.Text = "0";
                operation = "+";
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = new CalculatorOperations(Convert.ToDouble(textBox1.Text));
                textBox1.Text = "0";
                operation = "-";
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = new CalculatorOperations(Convert.ToDouble(textBox1.Text));
                textBox1.Text = "0";
                operation = "*";
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = new CalculatorOperations(Convert.ToDouble(textBox1.Text));
                textBox1.Text = "0";
                operation = "/";
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Click on equal event, meaning that it will show us the
        // result of the chosen operation
        private void equal_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            // Declaring the objects to manipulate the file
            string filePath = pathDir + file;
            fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            textOut = new StreamWriter(fileStream);
            // The result is reseted to zero when click on equal
            double result = 0;
            // Using a switch execute do operation with the two
            // informed numbers
            switch (operation)
            {
                case "+":
                    {
                        result = number1.Addition(number2);
                        textBox1.Text = (result).ToString();
                        break;
                    }
                case "-":
                    {
                        result = number1.Subtraction(number2);
                        textBox1.Text = (result).ToString();
                        break;
                    }
                case "*":
                    {
                        result = number1.Multiplication(number2);
                        textBox1.Text = (result).ToString();
                        break;
                    }
                case "/":
                    {
                        result = number1.Division(number2);
                        textBox1.Text = (result).ToString();
                        break;
                    }
                default:
                    {
                        textBox1.Text = "0";
                        break;
                    }
            }
            // Line to write in the file the operation executed
            textOut.Write(number1.InNumber.ToString() + " " + operation
            + " " + number2 + " = " + result + "\n");
            number1 = new CalculatorOperations(result);

            textOut.Close();
        }
        // Closing the application
        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?",
                "Exit Simple Calculator?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
