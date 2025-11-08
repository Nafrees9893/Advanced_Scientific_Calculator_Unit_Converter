namespace ADV_Calc
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            calculatorToolStripMenuItem = new ToolStripMenuItem();
            unitConvertorToolStripMenuItem = new ToolStripMenuItem();
            tempratureConvertorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { calculatorToolStripMenuItem, unitConvertorToolStripMenuItem, tempratureConvertorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(964, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // calculatorToolStripMenuItem
            // 
            calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            calculatorToolStripMenuItem.Size = new Size(73, 20);
            calculatorToolStripMenuItem.Text = "Calculator";
            calculatorToolStripMenuItem.Click += calculatorToolStripMenuItem_Click;
            // 
            // unitConvertorToolStripMenuItem
            // 
            unitConvertorToolStripMenuItem.Name = "unitConvertorToolStripMenuItem";
            unitConvertorToolStripMenuItem.Size = new Size(97, 20);
            unitConvertorToolStripMenuItem.Text = "Unit Convertor";
            unitConvertorToolStripMenuItem.Click += unitConvertorToolStripMenuItem_Click;
            // 
            // tempratureConvertorToolStripMenuItem
            // 
            tempratureConvertorToolStripMenuItem.Name = "tempratureConvertorToolStripMenuItem";
            tempratureConvertorToolStripMenuItem.Size = new Size(134, 20);
            tempratureConvertorToolStripMenuItem.Text = "Temprature convertor";
            tempratureConvertorToolStripMenuItem.Click += tempratureConvertorToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(964, 561);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaption;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Advance Scientific Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem calculatorToolStripMenuItem;
        private ToolStripMenuItem unitConvertorToolStripMenuItem;
        private ToolStripMenuItem tempratureConvertorToolStripMenuItem;
    }
}
