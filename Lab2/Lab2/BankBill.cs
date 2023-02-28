using System.ComponentModel;
using System.Xml.Serialization;

namespace Lab2
{
    [Serializable]
    //По хорошему, нужно добавить проверку в текстбоксы имении ( чтобы вводились только буквы)
    //И проверку на серию пасспорта ( маска работает криво, если вводить буквы, оно даст ввести только две)
    //а если вводить цифры, то вся маска заполнится цифрами
    public partial class BankBill : Form
    {
        public PersonalBill pb = new PersonalBill();
        DialogResult forMessages;
        Random r = new Random();
        List<PersonalBill> bills = new List<PersonalBill>();
        public BankBill()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Checked_cHANGE(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                this.pb.owner.wallet = radio.Text;
                /*txtResult.Text = radio.Text;*/
            }
        }
        private void Validate_CreateBill()
        {
            try
            {
                this.CreateBill.Enabled = ((bool)this.fioContainer.Tag) && ((bool)this.politicsAgreement.Tag) &&
                    ((bool)this.passportSeries.Tag) && ((bool)this.collectTown.Tag) && ((bool)this.birthDateContainer.Tag);
            }
            catch { }
        }

        private void Validating_FIO(object sender, CancelEventArgs e)
        {
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
                cb.Tag = true;
            }
            else
                cb.Tag = false;
            Validate_CreateBill();
        }

        private void validating_Passpory(object sender, CancelEventArgs e)
        {
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
                this.pb.owner.passportInfo = tb.Text;
            }
            Validate_CreateBill();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            this.Height = 950;
        }

        private void town_Validating(object sender, CancelEventArgs e)
        {
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

        private void collectTown_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            NumericUpDown nud = (NumericUpDown)sender;
            this.pb.startBalance = Convert.ToInt32(nud.Value);
        }

        private void birthDateContainer_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            this.pb.owner.birthDate = Convert.ToDateTime(dtp.Text);
            dtp.Tag = true;
            Validate_CreateBill();
        }

        private void collDate_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dt = (DateTimePicker)sender;
            this.pb.sendDate = Convert.ToDateTime(dt.Text);
            /*txtResult.Text = Convert.ToString(dt.Text);*/

        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            pb.services = "";
            CheckedListBox clb = (CheckedListBox)sender;
            foreach (var el in clb.CheckedItems)
            {
                pb.services += el.ToString() + " ";
            }
        }

        private void CreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                forMessages = MessageBox.Show("Cчет создан!.", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Info_About.Enabled = true;
                var xs = new XmlSerializer(typeof(List<PersonalBill>));
                bills.Add(pb);
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
        private void Info_About_Click(object sender, EventArgs e)
        {

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
            collDate.Text = Convert.ToString(DateTime.Now);
            numericUpDown1.Value = 0;
            politicsAgreement.Checked = false;
            this.BYN.Checked = false;
            this.RUB.Checked = false;
            this.USD.Checked = false;

        }

        private void phNumber_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox mtb = (MaskedTextBox)sender;
            if (mtb.Text.Length == 18)
            {
                /*txtResult.Text = lb.SelectedItem.ToString();*/
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
    }
}
