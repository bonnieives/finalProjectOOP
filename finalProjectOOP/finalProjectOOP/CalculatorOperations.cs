using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectOOP
{
    internal class CalculatorOperations
    {
        // Private field
        private double inNumber;
        // Property
        public double InNumber
        {
            get { return inNumber; }
            set { inNumber = value; }
        }
        // Constructor
        public CalculatorOperations(double number) 
        {
            this.InNumber = number;
        }
        // Methods
        public double Addition(double otherNumber) 
        {
            return InNumber + otherNumber;
        }
        public double Subtraction(double otherNumber)
        {
            return InNumber - otherNumber;
        }
        public double Multiplication(double otherNumber)
        {
            return InNumber * otherNumber;
        }
        public double Division(double otherNumber)
        {
            if (otherNumber == 0)
            {
                MessageBox.Show("Cannot divide by zero");
                return 0;
            }
            else
            {
                return InNumber / otherNumber;
            }
        }
    }
}
