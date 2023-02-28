namespace Lab2
{
    partial class BankBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.collectTown = new System.Windows.Forms.ListBox();
            this.passportSeries = new System.Windows.Forms.TextBox();
            this.politicsAgreement = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.phNumber = new System.Windows.Forms.MaskedTextBox();
            this.collDate = new System.Windows.Forms.DateTimePicker();
            this.birthDateContainer = new System.Windows.Forms.DateTimePicker();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.Info_About = new System.Windows.Forms.Button();
            this.ResetAll = new System.Windows.Forms.Button();
            this.CreateBill = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Additionals = new System.Windows.Forms.Label();
            this.CollectionDate = new System.Windows.Forms.Label();
            this.CollectionCity = new System.Windows.Forms.Label();
            this.PasportSeries = new System.Windows.Forms.Label();
            this.RUB = new System.Windows.Forms.RadioButton();
            this.USD = new System.Windows.Forms.RadioButton();
            this.BYN = new System.Windows.Forms.RadioButton();
            this.Wallet = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Birth_date = new System.Windows.Forms.Label();
            this.fioContainer = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.collectTown);
            this.panel1.Controls.Add(this.passportSeries);
            this.panel1.Controls.Add(this.politicsAgreement);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.phNumber);
            this.panel1.Controls.Add(this.collDate);
            this.panel1.Controls.Add(this.birthDateContainer);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.Info_About);
            this.panel1.Controls.Add(this.ResetAll);
            this.panel1.Controls.Add(this.CreateBill);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Additionals);
            this.panel1.Controls.Add(this.CollectionDate);
            this.panel1.Controls.Add(this.CollectionCity);
            this.panel1.Controls.Add(this.PasportSeries);
            this.panel1.Controls.Add(this.RUB);
            this.panel1.Controls.Add(this.USD);
            this.panel1.Controls.Add(this.BYN);
            this.panel1.Controls.Add(this.Wallet);
            this.panel1.Controls.Add(this.PhoneNumber);
            this.panel1.Controls.Add(this.Birth_date);
            this.panel1.Controls.Add(this.fioContainer);
            this.panel1.Controls.Add(this.FIO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 524);
            this.panel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Онлайн банкинг",
            "Система бонусов",
            "СМС-оповещения"});
            this.checkedListBox1.Location = new System.Drawing.Point(369, 433);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(274, 70);
            this.checkedListBox1.TabIndex = 29;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // collectTown
            // 
            this.collectTown.FormattingEnabled = true;
            this.collectTown.ItemHeight = 20;
            this.collectTown.Items.AddRange(new object[] {
            "Минск",
            "Москва",
            "Барановичи",
            "Брест",
            "Гродно",
            "Витебск",
            "Могилев",
            "Гомель"});
            this.collectTown.Location = new System.Drawing.Point(367, 307);
            this.collectTown.Name = "collectTown";
            this.collectTown.Size = new System.Drawing.Size(276, 44);
            this.collectTown.TabIndex = 28;
            this.collectTown.Tag = false;
            this.collectTown.SelectedIndexChanged += new System.EventHandler(this.collectTown_SelectedIndexChanged);
            this.collectTown.Validating += new System.ComponentModel.CancelEventHandler(this.town_Validating);
            // 
            // passportSeries
            // 
            this.passportSeries.Location = new System.Drawing.Point(367, 257);
            this.passportSeries.MaxLength = 9;
            this.passportSeries.Name = "passportSeries";
            this.passportSeries.Size = new System.Drawing.Size(276, 27);
            this.passportSeries.TabIndex = 27;
            this.passportSeries.Tag = false;
            this.passportSeries.Validating += new System.ComponentModel.CancelEventHandler(this.validating_Passpory);
            // 
            // politicsAgreement
            // 
            this.politicsAgreement.AutoSize = true;
            this.politicsAgreement.Location = new System.Drawing.Point(54, 615);
            this.politicsAgreement.Name = "politicsAgreement";
            this.politicsAgreement.Size = new System.Drawing.Size(696, 24);
            this.politicsAgreement.TabIndex = 26;
            this.politicsAgreement.Tag = false;
            this.politicsAgreement.Text = "Я изучил политику конфеденциальности а также согласен на обработку персональных д" +
    "анных";
            this.politicsAgreement.UseVisualStyleBackColor = true;
            this.politicsAgreement.CheckedChanged += new System.EventHandler(this.agreement_Check);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(380, 546);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.balance_Change);
            // 
            // phNumber
            // 
            this.phNumber.Location = new System.Drawing.Point(367, 152);
            this.phNumber.Mask = "(000) 99 999-99-99";
            this.phNumber.Name = "phNumber";
            this.phNumber.Size = new System.Drawing.Size(276, 27);
            this.phNumber.TabIndex = 21;
            this.phNumber.Tag = "False";
            this.phNumber.TextChanged += new System.EventHandler(this.phNumber_TextChanged);
            // 
            // collDate
            // 
            this.collDate.Location = new System.Drawing.Point(369, 380);
            this.collDate.MaxDate = new System.DateTime(2024, 2, 12, 0, 0, 0, 0);
            this.collDate.MinDate = new System.DateTime(2023, 2, 14, 18, 37, 35, 29);
            this.collDate.Name = "collDate";
            this.collDate.Size = new System.Drawing.Size(274, 27);
            this.collDate.TabIndex = 20;
            this.collDate.Value = new System.DateTime(2023, 2, 14, 18, 37, 35, 29);
            this.collDate.ValueChanged += new System.EventHandler(this.collDate_ValueChanged);
            // 
            // birthDateContainer
            // 
            this.birthDateContainer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateContainer.Location = new System.Drawing.Point(369, 90);
            this.birthDateContainer.MaxDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.birthDateContainer.Name = "birthDateContainer";
            this.birthDateContainer.Size = new System.Drawing.Size(274, 27);
            this.birthDateContainer.TabIndex = 19;
            this.birthDateContainer.Tag = false;
            this.birthDateContainer.Value = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.birthDateContainer.ValueChanged += new System.EventHandler(this.birthDateContainer_ValueChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(380, 667);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(341, 173);
            this.txtResult.TabIndex = 18;
            this.txtResult.Text = "";
            // 
            // Info_About
            // 
            this.Info_About.Enabled = false;
            this.Info_About.Location = new System.Drawing.Point(95, 807);
            this.Info_About.Name = "Info_About";
            this.Info_About.Size = new System.Drawing.Size(172, 33);
            this.Info_About.TabIndex = 17;
            this.Info_About.Text = "Информация о счёте";
            this.Info_About.UseVisualStyleBackColor = true;
            this.Info_About.Click += new System.EventHandler(this.Info_About_Click);
            // 
            // ResetAll
            // 
            this.ResetAll.Location = new System.Drawing.Point(95, 743);
            this.ResetAll.Name = "ResetAll";
            this.ResetAll.Size = new System.Drawing.Size(172, 33);
            this.ResetAll.TabIndex = 16;
            this.ResetAll.Text = "Сбросить поля";
            this.ResetAll.UseVisualStyleBackColor = true;
            this.ResetAll.Click += new System.EventHandler(this.ResetAll_Click);
            // 
            // CreateBill
            // 
            this.CreateBill.Enabled = false;
            this.CreateBill.Location = new System.Drawing.Point(95, 667);
            this.CreateBill.Name = "CreateBill";
            this.CreateBill.Size = new System.Drawing.Size(172, 33);
            this.CreateBill.TabIndex = 15;
            this.CreateBill.Text = "Создать счёт";
            this.CreateBill.UseVisualStyleBackColor = true;
            this.CreateBill.Click += new System.EventHandler(this.CreateBill_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(47, 547);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Начальный баланс";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Additionals
            // 
            this.Additionals.AutoSize = true;
            this.Additionals.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Additionals.Location = new System.Drawing.Point(38, 433);
            this.Additionals.Name = "Additionals";
            this.Additionals.Size = new System.Drawing.Size(263, 26);
            this.Additionals.TabIndex = 11;
            this.Additionals.Text = "Дополнительные сервисы";
            this.Additionals.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CollectionDate
            // 
            this.CollectionDate.AutoSize = true;
            this.CollectionDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CollectionDate.Location = new System.Drawing.Point(38, 381);
            this.CollectionDate.Name = "CollectionDate";
            this.CollectionDate.Size = new System.Drawing.Size(233, 26);
            this.CollectionDate.TabIndex = 10;
            this.CollectionDate.Text = "Желаемая дата выдачи";
            this.CollectionDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CollectionCity
            // 
            this.CollectionCity.AutoSize = true;
            this.CollectionCity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CollectionCity.Location = new System.Drawing.Point(38, 307);
            this.CollectionCity.Name = "CollectionCity";
            this.CollectionCity.Size = new System.Drawing.Size(185, 26);
            this.CollectionCity.TabIndex = 9;
            this.CollectionCity.Text = "Город получения ";
            this.CollectionCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasportSeries
            // 
            this.PasportSeries.AutoSize = true;
            this.PasportSeries.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasportSeries.Location = new System.Drawing.Point(38, 258);
            this.PasportSeries.Name = "PasportSeries";
            this.PasportSeries.Size = new System.Drawing.Size(166, 26);
            this.PasportSeries.TabIndex = 8;
            this.PasportSeries.Text = "Серия паспорта";
            // 
            // RUB
            // 
            this.RUB.AutoSize = true;
            this.RUB.Location = new System.Drawing.Point(505, 204);
            this.RUB.Name = "RUB";
            this.RUB.Size = new System.Drawing.Size(58, 24);
            this.RUB.TabIndex = 7;
            this.RUB.Text = "RUB";
            this.RUB.UseVisualStyleBackColor = true;
            this.RUB.CheckedChanged += new System.EventHandler(this.Checked_cHANGE);
            // 
            // USD
            // 
            this.USD.AutoSize = true;
            this.USD.Location = new System.Drawing.Point(440, 204);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(59, 24);
            this.USD.TabIndex = 6;
            this.USD.Text = "USD";
            this.USD.UseVisualStyleBackColor = true;
            this.USD.CheckedChanged += new System.EventHandler(this.Checked_cHANGE);
            // 
            // BYN
            // 
            this.BYN.AutoSize = true;
            this.BYN.Location = new System.Drawing.Point(371, 204);
            this.BYN.Name = "BYN";
            this.BYN.Size = new System.Drawing.Size(58, 24);
            this.BYN.TabIndex = 5;
            this.BYN.Text = "BYN";
            this.BYN.UseVisualStyleBackColor = true;
            this.BYN.CheckedChanged += new System.EventHandler(this.Checked_cHANGE);
            // 
            // Wallet
            // 
            this.Wallet.AutoSize = true;
            this.Wallet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wallet.Location = new System.Drawing.Point(38, 202);
            this.Wallet.Name = "Wallet";
            this.Wallet.Size = new System.Drawing.Size(168, 26);
            this.Wallet.TabIndex = 4;
            this.Wallet.Text = "Открыть счёт в:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumber.Location = new System.Drawing.Point(38, 151);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(172, 26);
            this.PhoneNumber.TabIndex = 3;
            this.PhoneNumber.Text = "Номер телефона";
            // 
            // Birth_date
            // 
            this.Birth_date.AutoSize = true;
            this.Birth_date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Birth_date.Location = new System.Drawing.Point(38, 91);
            this.Birth_date.Name = "Birth_date";
            this.Birth_date.Size = new System.Drawing.Size(159, 26);
            this.Birth_date.TabIndex = 2;
            this.Birth_date.Text = "Дата рождения";
            // 
            // fioContainer
            // 
            this.fioContainer.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fioContainer.Location = new System.Drawing.Point(368, 39);
            this.fioContainer.Name = "fioContainer";
            this.fioContainer.Size = new System.Drawing.Size(275, 30);
            this.fioContainer.TabIndex = 1;
            this.fioContainer.Tag = "False";
            this.fioContainer.Validating += new System.ComponentModel.CancelEventHandler(this.Validating_FIO);
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FIO.Location = new System.Drawing.Point(45, 39);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(62, 26);
            this.FIO.TabIndex = 0;
            this.FIO.Text = "ФИО";
            // 
            // BankBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(761, 524);
            this.Controls.Add(this.panel1);
            this.Name = "BankBill";
            this.Text = "BankBill";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox fioContainer;
        private Label FIO;
        private Label Additionals;
        private Label CollectionDate;
        private Label CollectionCity;
        private Label PasportSeries;
        private RadioButton RUB;
        private RadioButton USD;
        private RadioButton BYN;
        private Label Wallet;
        private Label PhoneNumber;
        private Label Birth_date;
        private Label label9;
        private Button Info_About;
        private Button ResetAll;
        private Button CreateBill;
        private DateTimePicker collDate;
        private DateTimePicker birthDateContainer;
        private RichTextBox txtResult;
        private NumericUpDown numericUpDown1;
        private MaskedTextBox phNumber;
        private CheckBox politicsAgreement;
        private TextBox passportSeries;
        private ListBox collectTown;
        private CheckedListBox checkedListBox1;
    }
}