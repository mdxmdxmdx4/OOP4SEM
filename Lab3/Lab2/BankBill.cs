using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab2
{
    [Serializable]
    //конструктор поиска
    public partial class BankBill : Form
    {
        public PersonalBill pb = new PersonalBill();
        DialogResult forMessages;
        //DateLabel
        Random r = new Random();
        List<PersonalBill> bills = new List<PersonalBill>();
        System.Windows.Forms.Timer timer;

        List<PersonalBill> sortOrSeek;

        static string err = "";

        string seekMode;
        int outputStr = 0;

        bool isPinned = true;
        void bills_Change() {
            ElementsLabel.Text = bills.Count.ToString();
        }
        void lastActionSet(string str)
        {
            toolStripStatusLabel5.Text = str;
        }

        public BankBill()
        {
            InitializeComponent();
        }
        void timer_Tick(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }
        private void Checked_cHANGE(object sender, EventArgs e)
        {
            lastActionSet("Действие с радиокнопками");
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                this.pb.owner.wallet = radio.Text;
            }
        }
        private void Validate_CreateBill()
        {
            try
            {
                this.CreateBill.Enabled = ((bool)this.fioContainer.Tag) && ((bool)this.politicsAgreement.Tag)
                    && ((bool)this.collectTown.Tag) && ((bool)this.birthDateContainer.Tag) && ((bool)this.passportSeries.Tag);
            }
            catch { }
        }

        private void Validating_FIO(object sender, CancelEventArgs e)
        {
            lastActionSet("Ввод данных");
            TextBox tb = (TextBox)sender;
            if (tb.Text == null || tb.Text.Length <= 10)
            {
                tb.BackColor = Color.LightPink;
                tb.Tag = false;
            }
            else
            {
                this.pb.owner.FIO = tb.Text;
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
            }
            Validate_CreateBill();
        }

        private void agreement_Check(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                lastActionSet("Подтверждение соглашения");
                cb.Tag = true;
            }
            else
                cb.Tag = false;
            Validate_CreateBill();
        }

        private void validating_Passpory(object sender, CancelEventArgs e)
        {
            lastActionSet("Ввод данных");
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length != 9)
            {

                tb.BackColor = Color.LightPink;
                tb.Tag = false;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
                this.pb.owner.PassportInfo = tb.Text;
            }
            Validate_CreateBill();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += timer_Tick;
            timer.Start();
            this.Height = 950;
            this.pb.startBalance = 0;
            this.collDate.MinDate = DateTime.Now.AddDays(2);
            lastActionSet("-----");
            this.SearchPanel.Width = 470;
            this.SearchPanel.Height = 230;
            this.SearchPanel.Location = new Point(150,90);
            FileInfo fi = new FileInfo(@"C:\Users\mdxbu\Labs\4SEMESTR\OOP\Lab3\Lab2\bin\\Debug\net6.0-windows\bill.xml");
            if (fi.Exists)
            {
                var xml = new XmlSerializer(typeof(List<PersonalBill>));
                using (var fx = new FileStream("bill.xml", FileMode.Open))
                {
                    var human = (List<PersonalBill>)xml.Deserialize(fx)!;
                    if (human != null && human.Count >= 1)
                        bills = human;
                    bills_Change();
                    foreach (var el in bills)
                    {
                        txtResult.Text += el.ToString() + "\n\n";
                    }
                }
            }
        }

        private void town_Validating(object sender, CancelEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (lb.SelectedItem != null)
            {
                this.pb.town = lb.Text;
                lb.Tag = true;
                lb.BackColor = SystemColors.Window;
            }
            else
            {
                lb.Tag = false;
                lb.BackColor = Color.LightPink;
            }
            Validate_CreateBill();
        }

        private void collectTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastActionSet("Выбор города");
            ListBox lb = (ListBox)sender;
            if (lb.SelectedItem != null)
            {
                /*txtResult.Text = lb.SelectedItem.ToString();*/
                this.pb.town = lb.Text;
                lb.Tag = true;
                lb.BackColor = SystemColors.Window;
            }
            else
            {
                lb.Tag = false;
                lb.BackColor = Color.LightPink;
            }
            Validate_CreateBill();

        }

        private void balance_Change(object sender, EventArgs e)
        {
            lastActionSet("Установка баланса");
            NumericUpDown nud = (NumericUpDown)sender;
            this.pb.startBalance = Convert.ToInt32(nud.Value);
        }

        private void birthDateContainer_ValueChanged(object sender, EventArgs e)
        {
            lastActionSet("Выбор даты рождения");
            DateTimePicker dtp = (DateTimePicker)sender;
            this.pb.owner.birthDate = Convert.ToDateTime(dtp.Text);
            dtp.Tag = true;
            Validate_CreateBill();
        }

        private void collDate_ValueChanged(object sender, EventArgs e)
        {
            lastActionSet("Выбор даты получения");
            DateTimePicker dt = (DateTimePicker)sender;
            this.pb.sendDate = Convert.ToDateTime(dt.Text);
            /*txtResult.Text = Convert.ToString(dt.Text);*/

        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lastActionSet("Выбор доп. функций");
            pb.services = "";
            CheckedListBox clb = (CheckedListBox)sender;
            foreach (var el in clb.CheckedItems)
            {
                pb.services += el.ToString() + " ";
            }
        }

        private void CreateBill_Click(object sender, EventArgs e)
        {
            lastActionSet("Создание счёта");
            if (Validate(this.pb.owner))
            {
                try
                {
                    Random r = new Random();
                    this.pb.Number = r.Next(10000, 100000);
                    forMessages = MessageBox.Show("Cчет создан!.", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Info_About.Enabled = true;
                    var xs = new XmlSerializer(typeof(List<PersonalBill>));
                    bills.Add(pb);
                    bills_Change();
                    pb = new PersonalBill();
                    using (var fs = new FileStream("bill.xml", FileMode.OpenOrCreate))
                    {
                        xs.Serialize(fs, bills);
                    }
                }
                catch
                {
                    forMessages = MessageBox.Show("Произошла ошибка во время создания счёта!\n Приносим свои извинения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                forMessages = MessageBox.Show(err, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Info_About_Click(object sender, EventArgs e)
        {
            lastActionSet("Просмотр информации");
            var xml = new XmlSerializer(typeof(List<PersonalBill>));
            using (var fx = new FileStream("bill.xml", FileMode.Open))
            {
                var human = (List<PersonalBill>)xml.Deserialize(fx)!;
                txtResult.Text = human.Last().ToString();
            }
        }
        public override string ToString()
        {
            return $"Счёт #{r.Next(10000, 10000000)}, валюта - {this.pb.owner.wallet}\n" +
                $"Владелец: {this.pb.owner.FIO}\n" +
                $"Дата рождения {this.pb.owner.birthDate.Date}\n" +
                $"Контакты: +{this.pb.owner.phoneNumber}\n" +
                $"Начальный баланс = {this.pb.startBalance}";
        }

        private void ResetAll_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            fioContainer.Text = "";
            phNumber.Text = "";
            passportSeries.Text = "";
            numericUpDown1.Value = 0;
            politicsAgreement.Checked = false;
            this.BYN.Checked = false;
            this.RUB.Checked = false;
            this.USD.Checked = false;
            numericUpDown1.Value = 0;
            lastActionSet("Cброс");
            if (!isPinned)
            {
                toolStrip1.Visible = false;
                OpenMenu.Visible = true;
            };
        }

        private void phNumber_TextChanged(object sender, EventArgs e)
        {
            lastActionSet("Ввод данных");
            MaskedTextBox mtb = (MaskedTextBox)sender;
            if (mtb.Text.Length == 18)
            {
                this.pb.owner.phoneNumber = mtb.Text;
                mtb.Tag = true;
                mtb.BackColor = SystemColors.Window;
            }
            else
            {
                mtb.Tag = false;
                mtb.BackColor = Color.LightPink;
            }
            Validate_CreateBill();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastActionSet("О программе");
            forMessages = MessageBox.Show("Версия : 1.1.3\nРазработчик: Лешук Д.И.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Validate(Owner obj)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(obj, null, null);

            if (!Validator.TryValidateObject(obj, context, results, true))
            {
                foreach (var item in results)
                {
                    err = item.ErrorMessage;
                }
                return false;
            }
            return true;
        }

        private void fioContainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            lastActionSet("Ввод данных");
            if (Char.IsLetter(e.KeyChar) == true || Char.IsSeparator(e.KeyChar) == true || Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
            return;
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lastActionSet("Сортировка");
            ToolStripMenuItem cms = (ToolStripMenuItem)sender;

            string sortResult = "";
            string caption = "";
            sortOrSeek = new List<PersonalBill>();
            switch (cms.Text)
            {
                case "Тип вклада":
                    {
                        var result = bills
                        .OrderBy(n => n.owner.wallet);
                        caption = "Сортировка по типу валюты!";
                        foreach (var item in result)
                        {
                            sortResult += item.ToString() + "\n\n";
                            sortOrSeek.Add(item);
                        }
                        MessageBox.Show(sortResult, caption, MessageBoxButtons.OK);
                        break;
                    }
                case "Дата открытия":
                    {
                        var result2 = bills
                        .OrderBy(n => n.sendDate);
                        caption = "Сортировка по дате открытия вклада";
                        foreach (var item in result2)
                        {
                            sortResult += item.ToString() + "\n\n";
                            sortOrSeek.Add(item);
                        }
                        MessageBox.Show(sortResult, caption, MessageBoxButtons.OK);
                        break;
                    }
            }
            if (!isPinned)
            {
                toolStrip1.Visible = false;
                OpenMenu.Visible = true;
            };
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastActionSet("Сохранение");
            try
            {
                var xs = new XmlSerializer(typeof(List<PersonalBill>));
                using (var fs = new FileStream("SortOrSeek.xml", FileMode.OpenOrCreate))
                {
                    xs.Serialize(fs, bills);
                }
                forMessages = MessageBox.Show("Результат поиска/сортировки сохранен в SortOrSeek.xml!", "Действие выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                forMessages = MessageBox.Show("Не удалось сохранить результаты поиска/cортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            this.SearchPanel.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lastActionSet("Ввод данных");
            if (Char.IsLetterOrDigit(e.KeyChar) == true || Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
            return;

        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem cms = (ToolStripMenuItem)sender;
            lastActionSet("Поиск");
            seekMode = "";
            this.SearchPanel.Visible = true;
            txtResult.Text = "";
            searchInput.Text = "";
            seekMode = cms.Text;
            if (!isPinned)
            {
                toolStrip1.Visible = false;
                OpenMenu.Visible = true;
            };
        }

        private void BeginSearch_Click(object sender, EventArgs e)
        {
            sortOrSeek = new List<PersonalBill>();
            string caption = "";
            string sortResult = "";

            if (searchInput.Text != "")
            {
                switch (seekMode)
                {
                    case "Баланс":
                        {
                            Regex r = new Regex(@"[0-9]{1,3}");
                            if (r.IsMatch(searchInput.Text))
                            {
                                var res = bills
                                    .Where(n => n.startBalance > Convert.ToInt32(searchInput.Text))
                                    .Select(n => n);
                                caption = "Поиск по балансу вклада";
                                foreach (var item in res)
                                {
                                    sortResult += item.ToString() + "\n\n";
                                    sortOrSeek.Add(item);
                                }
                                if (sortOrSeek.Count == 0)
                                    sortResult = "Записей не найдено";
                                MessageBox.Show(sortResult, caption, MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("Вы ввели неверное значение для данного типа поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case "По № счёта":
                        {
                            Regex r = new Regex(@"[0-9]{5,6}");
                            if (r.IsMatch(searchInput.Text))
                            {
                                var res = bills
                                    .Where(n => n.Number == Convert.ToInt32(searchInput.Text));
                                caption = "Поиск по номеру вклада";
                                foreach (var item in res)
                                {
                                    sortResult += item.ToString() + "\n\n";
                                    sortOrSeek.Add(item);
                                    break;
                                }
                                if (sortOrSeek.Count == 0)
                                    sortResult = "Записей не найдено";
                                MessageBox.Show(sortResult, caption, MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("Вы ввели неверное значение для данного типа поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case "Тип вклада":
                        {
                            Regex rg = new Regex(@"[A-Z]{3}");
                            if (rg.IsMatch(searchInput.Text))
                            {
                                var res = bills
                                .Where(n => n.owner.wallet == searchInput.Text)
                                .Select(n => n);
                                caption = "Поиск по типу вклада";
                                foreach (var item in res)
                                {
                                    sortResult += item.ToString() + "\n\n";
                                    sortOrSeek.Add(item);
                                }
                                if (sortOrSeek.Count == 0)
                                    sortResult = "Записей не найдено";
                                MessageBox.Show(sortResult, caption, MessageBoxButtons.OK);

                            }
                            else
                            {
                                MessageBox.Show("Вы ввели неверное значение для данного типа поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    case "По фамилии":
                        {
                            Regex r = new Regex(@"[А-я]{3,15}");
                            if (r.IsMatch(searchInput.Text))
                            {
                                var ress = bills
                                    .Where(n => n.owner.FIO.Split(" ")[0].Contains(searchInput.Text))
                                    .Select(n => n);
                                caption = "Поиск по фамилии";
                                foreach (var item in ress)
                                {
                                    sortResult += item.ToString() + "\n\n";
                                    sortOrSeek.Add(item);
                                }
                                if (sortOrSeek.Count == 0)
                                    sortResult = "Записей не найдено";
                                MessageBox.Show(sortResult, caption, MessageBoxButtons.OK);

                            }
                        else 
                            MessageBox.Show("Некорректный формат фамилии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     break;
                        }
                }
                SearchPanel.Visible = false;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            lastActionSet("Закрытие панели");
            this.toolStrip1.Visible = false;
            this.OpenMenu.Visible = true;
        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            lastActionSet("Открытие панели");
            this.toolStrip1.Visible = true;
            this.OpenMenu.Visible = false;
        }

        private void NextBill_Click(object sender, EventArgs e)
        {
            lastActionSet("Просмотр счетов");
            txtResult.Text = bills[outputStr++].ToString();
            if (outputStr > 0)
                this.PrevBill.Enabled = true;
            if(outputStr == bills.Count - 1)
                this.NextBill.Enabled = false;
            if (!isPinned) {
                toolStrip1.Visible = false;
                OpenMenu.Visible = true;
                    };

        }

        private void PrevBill_Click(object sender, EventArgs e)
        {
            lastActionSet("Просмотр счетов");
            txtResult.Text = bills[--outputStr].ToString();
            if (outputStr == 0)
            {
                this.PrevBill.Enabled = false;
                this.NextBill.Enabled = true;
            }
            if (outputStr > 0)
                this.PrevBill.Enabled = true;
            if (outputStr == bills.Count - 1)
                this.NextBill.Enabled = false;
            if (outputStr <= bills.Count - 2)
                this.NextBill.Enabled = true;
            if (!isPinned)
            {
                toolStrip1.Visible = false;
                OpenMenu.Visible = true;
            };
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            lastActionSet("Закрепление панели");
            if (!isPinned)
                isPinned = true;
            else
                isPinned = false;
        }

        private void конструкторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SearchConstructorPanel.Visible = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.SearchConstructorPanel.Visible = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lastActionSet("Поиск");
            CheckBox cb = (CheckBox)sender;
            switch (cb.Text) {
                case "Фамилия": {
                        if (cb.Checked)
                            this.forName.Enabled = true;
                        else
                            this.forName.Enabled = false;
                        break;
                    }
                case "Баланс": {

                        if (cb.Checked)
                            this.forBalance.Enabled = true;
                        else
                            this.forBalance.Enabled = false;
                        break;
                    }
                case "Тип вклада": {
                        if (cb.Checked)
                            this.forType.Enabled = true;
                        else
                            this.forType.Enabled = false;
                        break;
                    }   
            }
        }

        private void ConstrButton_Click(object sender, EventArgs e)
        {
            sortOrSeek = new List<PersonalBill>();
            string caption = "Поиск по конструктору";
            string xresult = " ";
            bool skip = true;
            bool skip2 = true;
            if (cbName.Checked) {
                skip = false;
                Regex r = new Regex(@"[А-я]{3,15}");
                if (r.IsMatch(forName.Text))
                {
                    var ress = bills
                        .Where(n => n.owner.FIO.Split(" ")[0].Contains(forName.Text))
                        .Select(n => n);
                    caption = "Поиск по фамилии";
                    foreach (var item in ress)
                    {
                        xresult += item.ToString() + "\n\n";
                        sortOrSeek.Add(item);
                    }
                    if (sortOrSeek.Count == 0)
                    {
                        xresult = "Записей не найдено";
                        MessageBox.Show(xresult, caption, MessageBoxButtons.OK);
                        this.SearchConstructorPanel.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный формат фамилии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.SearchConstructorPanel.Visible = false;
                    return;
                }
                }

            if (cbBalance.Checked)
            {
                xresult = "";
                skip2 = false;
                Regex r = new Regex(@"[0-9]{1,3}");
                if (r.IsMatch(forBalance.Text))
                {
                    if (skip == true){ 
                    var res = bills
                        .Where(n => n.startBalance > Convert.ToInt32(forBalance.Text))
                        .Select(n => n);
                        foreach (var item in res)
                        {
                            xresult += item.ToString() + "\n\n";
                            sortOrSeek.Add(item);
                        }

                    }
                    else
                    {
                        try
                        {
                            var res = sortOrSeek
                            .Where(n => n.startBalance > Convert.ToInt32(forBalance.Text))
                            .Select(n => n);
                            foreach (var item in res)
                            {
                                xresult += item.ToString() + "\n\n";
                                sortOrSeek.Add(item);
                            }
                        }
                        catch { }
                    }
                    if (sortOrSeek.Count == 0)
                    {
                        xresult = "Записей не найдено";
                        MessageBox.Show(xresult, caption, MessageBoxButtons.OK);
                        this.SearchConstructorPanel.Visible = false;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели неверное значение для данного типа поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.SearchConstructorPanel.Visible = false;
                    return;
                }
            }

            if (cbType.Checked)
            {
                xresult = "";
                Regex rg = new Regex(@"[A-Z]{3}");
                if (rg.IsMatch(forType.Text))
                {
                    if (sortOrSeek.Count == 0)
                    {
                        var res = bills
                        .Where(n => n.owner.wallet == forType.Text)
                        .Select(n => n);
                        foreach (var item in res)
                        {
                            xresult += item.ToString() + "\n\n";
                            sortOrSeek.Add(item);
                        }
                    }
                    else
                    {
                        try
                        {
                            var res = sortOrSeek
                            .Where(n => n.owner.wallet == forType.Text)
                            .Select(n => n);
                            sortOrSeek = new List<PersonalBill>();
                            foreach (var item in res)
                            {
                                xresult += item.ToString() + "\n\n";
                                sortOrSeek.Add(item);
                            }
                        }
                        catch { }
                        if (sortOrSeek.Count == 0)
                        {
                            xresult = "Записей не найдено";
                            MessageBox.Show(xresult, caption, MessageBoxButtons.OK);
                            this.SearchConstructorPanel.Visible = false;
                            return;
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Вы ввели неверное значение для данного типа поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.SearchConstructorPanel.Visible = false;
                    return;
                }
            }
            forBalance.Text = "";
            forName.Text = "";
            forType.Text = "";
            cbBalance.Checked = false;
            cbName.Checked = false;
            cbType.Checked = false;


            MessageBox.Show(xresult, "Конструктор поиска", MessageBoxButtons.OK);
            this.SearchConstructorPanel.Visible = false;
        }
    }
}
