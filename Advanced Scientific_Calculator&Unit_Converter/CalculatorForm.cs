using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADV_Calc
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        string input = "";
        string operand1 = "";
        string operand2 = "";
        char operation;
        double result = 0;

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            txtDisplay.Text = input;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operand1 = input;
            operation = Convert.ToChar(btn.Text);
            input = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '×': result = num1 * num2; break;
                case '÷':
                    if (num2 != 0) result = num1 / num2;
                    else MessageBox.Show("Cannot divide by zero!");
                    break;
            }

            txtDisplay.Text = result.ToString();
            input = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            input = "";
            operand1 = "";
            operand2 = "";
            result = 0;
            txtDisplay.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                txtDisplay.Text = input;
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            input += Math.PI.ToString();
            txtDisplay.Text = input;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                result = Math.Sqrt(num);
                txtDisplay.Text = result.ToString();
                input = result.ToString();
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                result = num * num;
                txtDisplay.Text = result.ToString();
                input = result.ToString();
            } 
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                result = Math.Sin(num * Math.PI / 180); // Convert to radians
                txtDisplay.Text = result.ToString();
                input = result.ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                result = Math.Cos(num * Math.PI / 180);
                txtDisplay.Text = result.ToString();
                input = result.ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                result = Math.Tan(num * Math.PI / 180);
                txtDisplay.Text = result.ToString();
                input = result.ToString();
            }
        }
    }
}
