namespace ADV_Calc
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            buttonsqrt = new Button();
            buttonDel = new Button();
            buttonpi = new Button();
            buttonroot = new Button();
            buttonDivide = new Button();
            buttonTan = new Button();
            buttonCos = new Button();
            buttonSin = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // buttonsqrt
            // 
            buttonsqrt.BackColor = Color.Silver;
            buttonsqrt.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonsqrt.ForeColor = Color.Black;
            buttonsqrt.Location = new Point(140, 102);
            buttonsqrt.Name = "buttonsqrt";
            buttonsqrt.Size = new Size(50, 35);
            buttonsqrt.TabIndex = 1;
            buttonsqrt.Text = "x²";
            buttonsqrt.UseVisualStyleBackColor = false;
            buttonsqrt.Click += btnSquare_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.Silver;
            buttonDel.Font = new Font("Wingdings", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonDel.ForeColor = Color.Black;
            buttonDel.Location = new Point(196, 102);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(50, 35);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += btnDel_Click;
            // 
            // buttonpi
            // 
            buttonpi.BackColor = Color.Silver;
            buttonpi.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonpi.ForeColor = Color.Black;
            buttonpi.Location = new Point(28, 102);
            buttonpi.Name = "buttonpi";
            buttonpi.Size = new Size(50, 35);
            buttonpi.TabIndex = 3;
            buttonpi.Text = "π";
            buttonpi.UseVisualStyleBackColor = false;
            buttonpi.Click += btnPi_Click;
            // 
            // buttonroot
            // 
            buttonroot.BackColor = Color.Silver;
            buttonroot.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonroot.ForeColor = Color.Black;
            buttonroot.Location = new Point(84, 102);
            buttonroot.Name = "buttonroot";
            buttonroot.Size = new Size(50, 35);
            buttonroot.TabIndex = 4;
            buttonroot.Text = "√x";
            buttonroot.UseVisualStyleBackColor = false;
            buttonroot.Click += btnSqrt_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.Silver;
            buttonDivide.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDivide.ForeColor = Color.Black;
            buttonDivide.Location = new Point(196, 141);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(50, 35);
            buttonDivide.TabIndex = 8;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += operator_Click;
            // 
            // buttonTan
            // 
            buttonTan.BackColor = Color.Silver;
            buttonTan.Font = new Font("Times New Roman", 14.25F);
            buttonTan.ForeColor = Color.Black;
            buttonTan.Location = new Point(140, 141);
            buttonTan.Name = "buttonTan";
            buttonTan.Size = new Size(50, 35);
            buttonTan.TabIndex = 7;
            buttonTan.Text = "Tan";
            buttonTan.UseVisualStyleBackColor = false;
            buttonTan.Click += btnTan_Click;
            // 
            // buttonCos
            // 
            buttonCos.BackColor = Color.Silver;
            buttonCos.Font = new Font("Times New Roman", 14.25F);
            buttonCos.ForeColor = Color.Black;
            buttonCos.Location = new Point(84, 141);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(50, 35);
            buttonCos.TabIndex = 6;
            buttonCos.Text = "Cos";
            buttonCos.UseVisualStyleBackColor = false;
            buttonCos.Click += btnCos_Click;
            // 
            // buttonSin
            // 
            buttonSin.BackColor = Color.Silver;
            buttonSin.Font = new Font("Times New Roman", 14.25F);
            buttonSin.ForeColor = Color.Black;
            buttonSin.Location = new Point(28, 141);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(50, 35);
            buttonSin.TabIndex = 5;
            buttonSin.Text = "Sin";
            buttonSin.UseVisualStyleBackColor = false;
            buttonSin.Click += btnSin_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Silver;
            button9.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(196, 223);
            button9.Name = "button9";
            button9.Size = new Size(50, 35);
            button9.TabIndex = 16;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = false;
            button9.Click += operator_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Silver;
            button10.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(140, 223);
            button10.Name = "button10";
            button10.Size = new Size(50, 35);
            button10.TabIndex = 15;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btn_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Silver;
            button11.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(84, 223);
            button11.Name = "button11";
            button11.Size = new Size(50, 35);
            button11.TabIndex = 14;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = false;
            button11.Click += btn_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Silver;
            button12.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.Black;
            button12.Location = new Point(28, 223);
            button12.Name = "button12";
            button12.Size = new Size(50, 35);
            button12.TabIndex = 13;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = false;
            button12.Click += btn_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Silver;
            button13.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.Black;
            button13.Location = new Point(196, 182);
            button13.Name = "button13";
            button13.Size = new Size(50, 35);
            button13.TabIndex = 12;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = false;
            button13.Click += operator_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Silver;
            button14.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.Black;
            button14.Location = new Point(140, 182);
            button14.Name = "button14";
            button14.Size = new Size(50, 35);
            button14.TabIndex = 11;
            button14.Text = "9";
            button14.UseVisualStyleBackColor = false;
            button14.Click += btn_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Silver;
            button15.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.ForeColor = Color.Black;
            button15.Location = new Point(84, 182);
            button15.Name = "button15";
            button15.Size = new Size(50, 35);
            button15.TabIndex = 10;
            button15.Text = "8";
            button15.UseVisualStyleBackColor = false;
            button15.Click += btn_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Silver;
            button16.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.ForeColor = Color.Black;
            button16.Location = new Point(28, 182);
            button16.Name = "button16";
            button16.Size = new Size(50, 35);
            button16.TabIndex = 9;
            button16.Text = "7";
            button16.UseVisualStyleBackColor = false;
            button16.Click += btn_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Silver;
            button17.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button17.ForeColor = Color.Black;
            button17.Location = new Point(196, 304);
            button17.Name = "button17";
            button17.Size = new Size(50, 35);
            button17.TabIndex = 24;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = false;
            button17.Click += btnEqual_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Silver;
            button18.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.ForeColor = Color.Black;
            button18.Location = new Point(140, 304);
            button18.Name = "button18";
            button18.Size = new Size(50, 35);
            button18.TabIndex = 23;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.Silver;
            button19.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button19.ForeColor = Color.Black;
            button19.Location = new Point(84, 304);
            button19.Name = "button19";
            button19.Size = new Size(50, 35);
            button19.TabIndex = 22;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = false;
            button19.Click += btn_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Silver;
            button20.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button20.ForeColor = Color.Black;
            button20.Location = new Point(28, 304);
            button20.Name = "button20";
            button20.Size = new Size(50, 35);
            button20.TabIndex = 21;
            button20.Text = "AC";
            button20.UseVisualStyleBackColor = false;
            button20.Click += btnClear_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.Silver;
            button21.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button21.ForeColor = Color.Black;
            button21.Location = new Point(196, 263);
            button21.Name = "button21";
            button21.Size = new Size(50, 35);
            button21.TabIndex = 20;
            button21.Text = "-";
            button21.UseVisualStyleBackColor = false;
            button21.Click += operator_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.Silver;
            button22.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button22.ForeColor = Color.Black;
            button22.Location = new Point(140, 263);
            button22.Name = "button22";
            button22.Size = new Size(50, 35);
            button22.TabIndex = 19;
            button22.Text = "3";
            button22.UseVisualStyleBackColor = false;
            button22.Click += btn_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.Silver;
            button23.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button23.ForeColor = Color.Black;
            button23.Location = new Point(84, 263);
            button23.Name = "button23";
            button23.Size = new Size(50, 35);
            button23.TabIndex = 18;
            button23.Text = "2";
            button23.UseVisualStyleBackColor = false;
            button23.Click += btn_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.Silver;
            button24.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button24.ForeColor = Color.Black;
            button24.Location = new Point(28, 263);
            button24.Name = "button24";
            button24.Size = new Size(50, 35);
            button24.TabIndex = 17;
            button24.Text = "1";
            button24.UseVisualStyleBackColor = false;
            button24.Click += btn_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.WhiteSmoke;
            txtDisplay.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(28, 26);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(218, 49);
            txtDisplay.TabIndex = 25;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(275, 384);
            Controls.Add(txtDisplay);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(buttonDivide);
            Controls.Add(buttonTan);
            Controls.Add(buttonCos);
            Controls.Add(buttonSin);
            Controls.Add(buttonroot);
            Controls.Add(buttonpi);
            Controls.Add(buttonDel);
            Controls.Add(buttonsqrt);
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calculator";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonsqrt;
        private Button buttonDel;
        private Button buttonpi;
        private Button buttonroot;
        private Button buttonDivide;
        private Button buttonTan;
        private Button buttonCos;
        private Button buttonSin;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private TextBox txtDisplay;
    }
}