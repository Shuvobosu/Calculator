using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }
        Calclutor calclutor = new Calclutor();
        

        private void AddButton_Click(object sender, EventArgs e)
        {
            calclutor.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calclutor.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
           
            double result = calclutor.Add();
            resultTextBox.Text = result.ToString();
           
            
           
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            calclutor.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calclutor.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            double result = calclutor.Subtract();
            resultTextBox.Text = result.ToString();

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            calclutor.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calclutor.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            double result = calclutor.Multiply();
            resultTextBox.Text = result.ToString();

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            calclutor.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calclutor.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            double result = calclutor.Divide();
            resultTextBox.Text = result.ToString();

        }
    }
}
