using System.Security.Cryptography;

namespace Ramon_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
        double num1;
        double num2;
        string option;
        double result;

        private void buttonZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void buttonNP_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "-";
        }



        private void buttonOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonOne.Text;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonTwo.Text;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonThree.Text;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonFour.Text;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonFive.Text;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonSix.Text;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonSeven.Text;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonEight.Text;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonNine.Text;
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            option = "√";
            num1 = double.Parse(txtDisplay.Text);

        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplay.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num2 - num1;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("1/x"))
                result = 1 / num1;
            if (option.Equals("/"))
                result = num1 / num2;
            if (num2 == 0)
            {
                string message = "Error cannot be divided by 0";
                MessageBox.Show(message);
                txtDisplay.Clear();
            }


            if (option.Equals("√"))
                result = Math.Sqrt(num1);
            if (option.Equals("pi"))
                result = num1 * Math.PI;
            if (option.Equals("x2"))
                result = num1 * num1;
            if (option.Equals("xy"))
                result = Math.Pow(num1, num2);
            if (option.Equals("sine"))
                result = Math.Sin(num1);


            txtDisplay.Text = result + "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void darkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (darkMode.Checked)
            {
                tabPage1.BackColor = Color.Gray;
                buttonAdd.BackColor = Color.DarkSlateBlue;
                buttonSub.BackColor = Color.DarkSlateBlue;
                buttonDiv.BackColor = Color.DarkSlateBlue;
                buttonMul.BackColor = Color.DarkSlateBlue;
                sine.BackColor = Color.DarkSlateBlue;
                xy.BackColor = Color.DarkSlateBlue;
                x2.BackColor = Color.DarkSlateBlue;
                pi.BackColor = Color.DarkSlateBlue;
            }
            else
            {
                buttonAdd.BackColor = Color.Violet;
                buttonSub.BackColor = Color.Violet;
                buttonDiv.BackColor = Color.Violet;
                buttonMul.BackColor = Color.Violet;
                sine.BackColor = Color.Violet;
                xy.BackColor = Color.Violet;
                x2.BackColor = Color.Violet;
                pi.BackColor = Color.Violet;
                tabPage1.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scientificMode_CheckedChanged(object sender, EventArgs e)
        {
            if (scientificMode.Checked)
            {
                sine.Visible = true;
                xy.Visible = true;
                x2.Visible = true;
                pi.Visible = true;
            }
            else
            {
                sine.Visible = false;
                xy.Visible = false;
                x2.Visible = false;
                pi.Visible = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pi_Click(object sender, EventArgs e)
        {
            option = "pi";
            num1 = double.Parse(txtDisplay.Text);


        }

        private void x2_Click(object sender, EventArgs e)
        {
            option = "x2";
            num1 = double.Parse(txtDisplay.Text);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sine_Click(object sender, EventArgs e)
        {
            option = "sine";
            num1 = double.Parse(txtDisplay.Text);


        }

        private void xy_Click(object sender, EventArgs e)
        {
            option = "xy";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            option = "1/x";
            num1 = double.Parse(txtDisplay.Text);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.Text = message.Text + "HI REZA!"; 
        }

        private void message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}