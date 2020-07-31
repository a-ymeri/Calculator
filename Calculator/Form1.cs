using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double operand1 = 0;
        double operand2 = 0;

        char? op = null;
        char? input = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.99;
        }

        private void number_pressed(object sender, EventArgs e)
        {
            input = ((Button)sender).Text[0];


            if (op == null)
            {
                operand1 = operand1 * 10 + Char.GetNumericValue(input.Value);
                textBox1.Text = operand1.ToString();
            }
            else
            {
                operand2 = operand2 * 10 + Char.GetNumericValue(input.Value);
                textBox1.Text = operand2.ToString();
            }
            label1.Text = label1.Text + input;
        }

        private void operation_pressed(object sender, EventArgs e)
        {
            input = ((Button)sender).Text[0];
            if (input == '=')
            {
                performOperation();
                //op = null;
                //operand2 = 0;
                textBox1.Text = operand1.ToString();
                label1.Text += op + operand2.ToString() + '=';
                //if(label1.Text[label1.Text.Length-1]!='=') label1.Text += "=";
            }
            else if (Char.IsDigit(label1.Text[label1.Text.Length - 1]))
            {

                performOperation();
                op = input;
                label1.Text = label1.Text + op;

            }
            else
            {
                op = input;
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1) + input;
            }


        }


        private void performOperation()
        {
            if (op != null)
            {
                switch (op)
                {
                    case '+':
                        operand1 += operand2;
                        break;
                    case '⨉':
                        operand1 *= operand2;
                        break;
                    case '-':
                        operand1 -= operand2;
                        break;
                    case '÷':
                        operand1 /= operand2;
                        break;
                }
            }
        }

        private void clear(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "0";
            operand1 = 0;
            operand2 = 0;
            op = null;
        }

        private void updateLabel()
        {
            label1.Text = operand1.ToString() + op;
        }
    }
}
