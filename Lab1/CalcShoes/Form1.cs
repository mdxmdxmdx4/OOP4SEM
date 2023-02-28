namespace CalcShoes
{
    public partial class Calculator : Form
    {
        int firstEnterValue, secondEnterValue;
        String operation;
        DialogResult errorAppered;

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberOperation(object sender, EventArgs e)
        {
            try
            {
                Button operationButton = (Button)sender;
                firstEnterValue = Convert.ToInt32(txtResult.Text);
                operation = operationButton.Text;
                txtResult.Text = "";
            }
            catch
            {
                errorAppered = MessageBox.Show("Operation Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "0";
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                secondEnterValue = Convert.ToInt32(txtResult.Text);
                firstEnterValue = int.Parse(txtResult.Text);
                firstEnterValue = Convert.ToInt32(firstEnterValue);

                switch (operation)
                {
                    case "OR":
                        txtResult.Text = Convert.ToString((firstEnterValue | secondEnterValue),2);
                        break;
                    case "XOR":
                        txtResult.Text = Convert.ToString(firstEnterValue ^ secondEnterValue).ToString();
                        break;
                    case "AND":
                        txtResult.Text = Convert.ToString(firstEnterValue & secondEnterValue).ToString();
                        break;
                    case "NOT":
                        txtResult.Text = Convert.ToString(~firstEnterValue);
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                errorAppered = MessageBox.Show("Error with operations", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
            }
        }

        private void buttonDEC_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 10);
        }

        private void buttonBIN_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void buttonHEX_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
                txtResult.Text = "0";     
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
                if (txtResult.Text.Length > 0)
                {
                    txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                }
                if (txtResult.Text == "")
                {
                    txtResult.Text = "0";
                }
        }

        private void EnterNumber(object sender, EventArgs e)
        {
            try
            {
                Button numberButton = (Button)sender;
                if (txtResult.Text == "0")
                    txtResult.Text = "";
                    txtResult.Text += numberButton.Text;
            }
            catch
            {
                errorAppered = MessageBox.Show("An error occured in calculator", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "0";
            }
        }
    }
}