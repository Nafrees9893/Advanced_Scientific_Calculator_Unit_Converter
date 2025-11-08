namespace ADV_Calc
{
    partial class UnitConvertorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitConvertorForm));
            cmbUnitType = new ComboBox();
            cmbToUnit = new ComboBox();
            cmbFromUnit = new ComboBox();
            txtInputValue = new TextBox();
            btnConvert = new Button();
            label1 = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnClear = new Button();
            btnDot = new Button();
            btn0 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbUnitType
            // 
            cmbUnitType.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cmbUnitType.FormattingEnabled = true;
            cmbUnitType.Location = new Point(76, 12);
            cmbUnitType.Name = "cmbUnitType";
            cmbUnitType.Size = new Size(121, 27);
            cmbUnitType.TabIndex = 0;
            cmbUnitType.SelectedIndexChanged += cmbUnitType_SelectedIndexChanged;
            // 
            // cmbToUnit
            // 
            cmbToUnit.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cmbToUnit.FormattingEnabled = true;
            cmbToUnit.Location = new Point(139, 66);
            cmbToUnit.Name = "cmbToUnit";
            cmbToUnit.Size = new Size(121, 27);
            cmbToUnit.TabIndex = 1;
            // 
            // cmbFromUnit
            // 
            cmbFromUnit.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cmbFromUnit.FormattingEnabled = true;
            cmbFromUnit.Location = new Point(12, 66);
            cmbFromUnit.Name = "cmbFromUnit";
            cmbFromUnit.Size = new Size(121, 27);
            cmbFromUnit.TabIndex = 2;
            // 
            // txtInputValue
            // 
            txtInputValue.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInputValue.Location = new Point(33, 104);
            txtInputValue.Name = "txtInputValue";
            txtInputValue.Size = new Size(100, 29);
            txtInputValue.TabIndex = 3;
            txtInputValue.TextChanged += txtInputValue_TextChanged;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.DodgerBlue;
            btnConvert.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.Location = new Point(139, 100);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(100, 36);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 144);
            label1.Name = "label1";
            label1.Size = new Size(165, 26);
            label1.TabIndex = 7;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Silver;
            btn7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(42, 182);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 35);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += DigitButton_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Silver;
            btn8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(111, 182);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 35);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += DigitButton_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Silver;
            btn9.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(180, 182);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 35);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += DigitButton_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Silver;
            btn6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(180, 221);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 35);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += DigitButton_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Silver;
            btn5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(111, 221);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 35);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += DigitButton_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Silver;
            btn4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(42, 221);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 35);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += DigitButton_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Silver;
            btn3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(180, 262);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 35);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += DigitButton_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Silver;
            btn2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(111, 262);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 35);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += DigitButton_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Silver;
            btn1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(42, 262);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 35);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += DigitButton_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Silver;
            btnClear.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(180, 303);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 35);
            btnClear.TabIndex = 19;
            btnClear.Text = "X";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Silver;
            btnDot.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.ForeColor = Color.Black;
            btnDot.Location = new Point(111, 303);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(50, 35);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += DigitButton_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Silver;
            btn0.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(42, 304);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 35);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += DigitButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            textBox1.Location = new Point(22, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(48, 26);
            textBox1.TabIndex = 21;
            textBox1.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 48);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 22;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 48);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 23;
            label3.Text = "To:";
            // 
            // UnitConvertorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(275, 384);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btn0);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(label1);
            Controls.Add(btnConvert);
            Controls.Add(txtInputValue);
            Controls.Add(cmbFromUnit);
            Controls.Add(cmbToUnit);
            Controls.Add(cmbUnitType);
            Name = "UnitConvertorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UnitConvertor";
            Load += UnitConvertorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUnitType;
        private ComboBox cmbToUnit;
        private ComboBox cmbFromUnit;
        private TextBox txtInputValue;
        private Button btnConvert;
        private TextBox label1;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnClear;
        private Button btnDot;
        private Button btn0;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}