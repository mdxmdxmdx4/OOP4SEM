namespace CalcShoes
{
    partial class Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonHEX = new System.Windows.Forms.Button();
            this.buttonDEC = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBIN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonNOT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExOR = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonOR = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonAND = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.buttonEquals);
            this.panel1.Controls.Add(this.buttonHEX);
            this.panel1.Controls.Add(this.buttonDEC);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.buttonEight);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonBIN);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonNOT);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonExOR);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.buttonOR);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.buttonAND);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 491);
            this.panel1.TabIndex = 0;
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEquals.Location = new System.Drawing.Point(258, 359);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(76, 64);
            this.buttonEquals.TabIndex = 36;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonHEX
            // 
            this.buttonHEX.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHEX.Location = new System.Drawing.Point(80, 262);
            this.buttonHEX.Name = "buttonHEX";
            this.buttonHEX.Size = new System.Drawing.Size(64, 55);
            this.buttonHEX.TabIndex = 8;
            this.buttonHEX.Text = "HEX";
            this.buttonHEX.UseVisualStyleBackColor = true;
            this.buttonHEX.Click += new System.EventHandler(this.buttonHEX_Click);
            // 
            // buttonDEC
            // 
            this.buttonDEC.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDEC.Location = new System.Drawing.Point(80, 201);
            this.buttonDEC.Name = "buttonDEC";
            this.buttonDEC.Size = new System.Drawing.Size(64, 55);
            this.buttonDEC.TabIndex = 7;
            this.buttonDEC.Text = "DEC";
            this.buttonDEC.UseVisualStyleBackColor = true;
            this.buttonDEC.Click += new System.EventHandler(this.buttonDEC_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(176, 359);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 64);
            this.button0.TabIndex = 34;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.EnterNumber);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEight.Location = new System.Drawing.Point(80, 140);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(64, 55);
            this.buttonEight.TabIndex = 6;
            this.buttonEight.Text = "8S";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(340, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 64);
            this.button3.TabIndex = 33;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.EnterNumber);
            // 
            // buttonBIN
            // 
            this.buttonBIN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBIN.Location = new System.Drawing.Point(80, 79);
            this.buttonBIN.Name = "buttonBIN";
            this.buttonBIN.Size = new System.Drawing.Size(64, 55);
            this.buttonBIN.TabIndex = 5;
            this.buttonBIN.Text = "BIN";
            this.buttonBIN.UseVisualStyleBackColor = true;
            this.buttonBIN.Click += new System.EventHandler(this.buttonBIN_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(258, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 64);
            this.button2.TabIndex = 32;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EnterNumber);
            // 
            // buttonNOT
            // 
            this.buttonNOT.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNOT.Location = new System.Drawing.Point(10, 262);
            this.buttonNOT.Name = "buttonNOT";
            this.buttonNOT.Size = new System.Drawing.Size(64, 55);
            this.buttonNOT.TabIndex = 4;
            this.buttonNOT.Text = "NOT";
            this.buttonNOT.UseVisualStyleBackColor = true;
            this.buttonNOT.Click += new System.EventHandler(this.NumberOperation);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(176, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 64);
            this.button1.TabIndex = 31;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EnterNumber);
            // 
            // buttonExOR
            // 
            this.buttonExOR.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExOR.Location = new System.Drawing.Point(10, 201);
            this.buttonExOR.Name = "buttonExOR";
            this.buttonExOR.Size = new System.Drawing.Size(64, 55);
            this.buttonExOR.TabIndex = 3;
            this.buttonExOR.Text = "XOR";
            this.buttonExOR.UseVisualStyleBackColor = true;
            this.buttonExOR.Click += new System.EventHandler(this.NumberOperation);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(340, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 64);
            this.button6.TabIndex = 30;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.EnterNumber);
            // 
            // buttonOR
            // 
            this.buttonOR.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOR.Location = new System.Drawing.Point(10, 140);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(64, 55);
            this.buttonOR.TabIndex = 2;
            this.buttonOR.Text = "OR";
            this.buttonOR.UseVisualStyleBackColor = true;
            this.buttonOR.Click += new System.EventHandler(this.NumberOperation);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(258, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 64);
            this.button5.TabIndex = 29;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.EnterNumber);
            // 
            // buttonAND
            // 
            this.buttonAND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAND.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAND.Location = new System.Drawing.Point(10, 79);
            this.buttonAND.Name = "buttonAND";
            this.buttonAND.Size = new System.Drawing.Size(64, 55);
            this.buttonAND.TabIndex = 1;
            this.buttonAND.Text = "AND";
            this.buttonAND.UseVisualStyleBackColor = true;
            this.buttonAND.Click += new System.EventHandler(this.NumberOperation);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(176, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 64);
            this.button4.TabIndex = 28;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.EnterNumber);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(16, 18);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(400, 38);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(340, 149);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 64);
            this.button9.TabIndex = 27;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.EnterNumber);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(258, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 64);
            this.button7.TabIndex = 26;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.EnterNumber);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(176, 79);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(76, 64);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "<--";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(176, 149);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 64);
            this.button8.TabIndex = 25;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.EnterNumber);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(258, 79);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(76, 64);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 491);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonHEX;
        private Button buttonDEC;
        private Button buttonEight;
        private Button buttonBIN;
        private Button buttonNOT;
        private Button buttonExOR;
        private Button buttonOR;
        private Button buttonAND;
        private TextBox txtResult;
        private Button buttonEquals;
        private Button button0;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button7;
        private Button buttonDelete;
        private Button button8;
        private Button buttonClear;
    }
}