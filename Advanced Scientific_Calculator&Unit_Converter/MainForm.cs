namespace ADV_Calc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.MdiParent = this;
            calculatorForm.Show();
        }

        private void unitConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitConvertorForm unitConvertor = new UnitConvertorForm();
            unitConvertor.MdiParent = this;
            unitConvertor.Show();
        }

        private void tempratureConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TempratureConvertorForm tempratureConvertorForm = new TempratureConvertorForm();
            tempratureConvertorForm.MdiParent = this;
            tempratureConvertorForm.Show();
        }

        
    }
}
