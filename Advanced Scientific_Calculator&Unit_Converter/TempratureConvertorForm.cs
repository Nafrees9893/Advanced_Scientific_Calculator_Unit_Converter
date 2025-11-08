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
    public partial class TempratureConvertorForm : Form
    {
        public TempratureConvertorForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInput.Text, out double inputTemp))
            {
                MessageBox.Show("Please enter a valid temperature.");
                return;
            }

            string from = cmbFrom.SelectedItem?.ToString();
            string to = cmbTo.SelectedItem?.ToString();

            if (from == null || to == null)
            {
                MessageBox.Show("Please select both units.");
                return;
            }

            double resultTemp = inputTemp;

            // Convert from 'from' to Celsius first
            if (from == "Fahrenheit")
                resultTemp = (inputTemp - 32) * 5 / 9;
            else if (from == "Kelvin")
                resultTemp = inputTemp - 273.15;

            // Convert from Celsius to 'to'
            if (to == "Fahrenheit")
                resultTemp = (resultTemp * 9 / 5) + 32;
            else if (to == "Kelvin")
                resultTemp = resultTemp + 273.15;

            lblResult.Text = $"Result: {resultTemp:F2} {to}";
        }

        private void FormTemperatureConverter_Load(object sender, EventArgs e)
        {
            cmbFrom.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
            cmbTo.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });

            cmbFrom.SelectedIndex = 0;
            cmbTo.SelectedIndex = 1;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtInput.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblResult.Text = "Result:";
        }
    }
}
