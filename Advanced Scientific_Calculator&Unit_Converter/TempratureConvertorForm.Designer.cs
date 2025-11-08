namespace ADV_Calc
{
    partial class TempratureConvertorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempratureConvertorForm));
            lblInput = new Label();
            txtInput = new TextBox();
            cmbFrom = new ComboBox();
            cmbTo = new ComboBox();
            btnConvert = new Button();
            lblResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInput.ForeColor = Color.Black;
            lblInput.Location = new Point(12, 9);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(114, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter Temperature:";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtInput.ForeColor = Color.Black;
            txtInput.Location = new Point(71, 27);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 26);
            txtInput.TabIndex = 1;
            // 
            // cmbFrom
            // 
            cmbFrom.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cmbFrom.ForeColor = Color.Black;
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new Point(12, 59);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(121, 27);
            cmbFrom.TabIndex = 2;
            // 
            // cmbTo
            // 
            cmbTo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cmbTo.ForeColor = Color.Black;
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(139, 59);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(121, 27);
            cmbTo.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Location = new Point(96, 92);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblResult.ForeColor = Color.Black;
            lblResult.Location = new Point(37, 121);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(197, 26);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result:";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(37, 260);
            button1.Name = "button1";
            button1.Size = new Size(50, 35);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(111, 257);
            button2.Name = "button2";
            button2.Size = new Size(50, 35);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(184, 175);
            button3.Name = "button3";
            button3.Size = new Size(50, 35);
            button3.TabIndex = 8;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(184, 216);
            button4.Name = "button4";
            button4.Size = new Size(50, 35);
            button4.TabIndex = 11;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(111, 216);
            button5.Name = "button5";
            button5.Size = new Size(50, 35);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Silver;
            button6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(37, 216);
            button6.Name = "button6";
            button6.Size = new Size(50, 35);
            button6.TabIndex = 9;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = false;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Silver;
            button7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(184, 301);
            button7.Name = "button7";
            button7.Size = new Size(50, 35);
            button7.TabIndex = 17;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnClear_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Silver;
            button8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(111, 301);
            button8.Name = "button8";
            button8.Size = new Size(50, 35);
            button8.TabIndex = 16;
            button8.Text = ".";
            button8.UseVisualStyleBackColor = false;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Silver;
            button9.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(37, 301);
            button9.Name = "button9";
            button9.Size = new Size(50, 35);
            button9.TabIndex = 15;
            button9.Text = "0";
            button9.UseVisualStyleBackColor = false;
            button9.Click += NumberButton_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Silver;
            button10.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(184, 260);
            button10.Name = "button10";
            button10.Size = new Size(50, 35);
            button10.TabIndex = 14;
            button10.Text = "3";
            button10.UseVisualStyleBackColor = false;
            button10.Click += NumberButton_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Silver;
            button11.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(111, 175);
            button11.Name = "button11";
            button11.Size = new Size(50, 35);
            button11.TabIndex = 13;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = false;
            button11.Click += NumberButton_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Silver;
            button12.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button12.ForeColor = Color.Black;
            button12.Location = new Point(37, 175);
            button12.Name = "button12";
            button12.Size = new Size(50, 35);
            button12.TabIndex = 12;
            button12.Text = "7";
            button12.UseVisualStyleBackColor = false;
            button12.Click += NumberButton_Click;
            // 
            // TempratureConvertorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(275, 384);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Controls.Add(btnConvert);
            Controls.Add(cmbTo);
            Controls.Add(cmbFrom);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "TempratureConvertorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TempratureConvertor";
            Load += FormTemperatureConverter_Load;
            Click += FormTemperatureConverter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private ComboBox cmbFrom;
        private ComboBox cmbTo;
        private Button btnConvert;
        private TextBox lblResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}