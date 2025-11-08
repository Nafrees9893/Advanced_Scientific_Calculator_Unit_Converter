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
    public partial class UnitConvertorForm : Form
    {
        public UnitConvertorForm()
        {
            InitializeComponent();
        }
        private double ConvertUnit(string type, string from, string to, double value)
        {
            Dictionary<string, double> length = new() {
            {"Meter", 1.0}, {"Kilometer", 1000.0}, {"Mile", 1609.34}
        };

            Dictionary<string, double> weight = new() {
            {"Kilogram", 1.0}, {"Gram", 0.001}, {"Pound", 0.453592}
        };

            Dictionary<string, double> volume = new() {
            {"Liter", 1.0}, {"Milliliter", 0.001}, {"Gallon", 3.78541}
        };

            double result = 0;

            if (type == "Length")
                result = value * length[from] / length[to];
            else if (type == "Weight")
                result = value * weight[from] / weight[to];
            else if (type == "Volume")
                result = value * volume[from] / volume[to];

            return result;
        }

        // Other methods like Form_Load, ComboBox change, Button click etc.

        private void UnitConvertorForm_Load(object sender, EventArgs e)
        {
            cmbUnitType.Items.AddRange(new string[] { "Length", "Weight", "Volume" });
            cmbUnitType.SelectedIndex = 0; // Set default
        }

        private void cmbUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFromUnit.Items.Clear();
            cmbToUnit.Items.Clear();

            string type = cmbUnitType.SelectedItem.ToString();

            if (type == "Length")
            {
                cmbFromUnit.Items.AddRange(new string[] { "Meter", "Kilometer", "Mile" });
                cmbToUnit.Items.AddRange(new string[] { "Meter", "Kilometer", "Mile" });
            }
            else if (type == "Weight")
            {
                cmbFromUnit.Items.AddRange(new string[] { "Kilogram", "Gram", "Pound" });
                cmbToUnit.Items.AddRange(new string[] { "Kilogram", "Gram", "Pound" });
            }
            else if (type == "Volume")
            {
                cmbFromUnit.Items.AddRange(new string[] { "Liter", "Milliliter", "Gallon" });
                cmbToUnit.Items.AddRange(new string[] { "Liter", "Milliliter", "Gallon" });
            }

            cmbFromUnit.SelectedIndex = 0;
            cmbToUnit.SelectedIndex = 1;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInputValue.Text, out double inputValue))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            if (cmbFromUnit.SelectedItem == null || cmbToUnit.SelectedItem == null || cmbUnitType.SelectedItem == null)
            {
                MessageBox.Show("Please select both units and a unit type.");
                return;
            }

            string from = cmbFromUnit.SelectedItem.ToString();
            string to = cmbToUnit.SelectedItem.ToString();
            string type = cmbUnitType.SelectedItem.ToString();

            double result = ConvertUnit(type, from, to, inputValue);

            // 👉 Show result with unit label
            label1.Text = $"{result:F2} {to}";
        }

        private void txtInputValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                txtInputValue.Text += btn.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputValue.Clear();
        }
    }
}
