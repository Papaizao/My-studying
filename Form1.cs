using System.Globalization;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        decimal n1 = 0, n2=0;        
        String op = " ";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "6";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResul.Text = textResul.Text + ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            n2 = decimal.Parse(textResul.Text, CultureInfo.InvariantCulture);
            if(op == "Soma")
            {
                textResul.Text =Convert.ToString(n1 + n2);
            }
            else if(op == "Subtrair")
            {
                textResul.Text = Convert.ToString(n1 - n2);
            }
            else if(op == "Multiplicar")
            {
                textResul.Text = Convert.ToString(n1 * n2);
            }
            else if(op == "Dividir")
            {
                if (n1 == 0)
                {
                    textResul.Text = "Impossivel dividir 0";
                }
                else
                {
                    textResul.Text = Convert.ToString(n1 / n2);
                }
             }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (op != " ")
            {
                n1 = decimal.Parse(textResul.Text, CultureInfo.InvariantCulture);
                textResul.Text = " ";
                op = "Subtrair";
                lblOP.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (op != " ")
            {
                n1 = decimal.Parse(textResul.Text, CultureInfo.InvariantCulture);
                textResul.Text = " ";
                op = "Multiplicar";
                lblOP.Text = "*";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (op != " ")
            {
                n1 = decimal.Parse(textResul.Text, CultureInfo.InvariantCulture);
                textResul.Text = " ";
                op = "Dividir";
                lblOP.Text = "/";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textResul.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (op != " ")
            {
                textResul.Text = " ";
                n1 = 0;
                n2 = 0;
                lblOP.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (op != " ")
            {
                n1 = decimal.Parse(textResul.Text, CultureInfo.InvariantCulture);
                textResul.Text = " ";
                op = "Soma";
                lblOP.Text = "+";
            }
        }
    }
}