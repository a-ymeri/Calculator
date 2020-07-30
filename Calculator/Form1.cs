using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double score = 0;
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
            Button btn = (Button)sender;
            score = score * 10 + Int32.Parse(btn.Text);
            textBox1.Text = score.ToString();
            //label1.Text = label1.Text + btn.Text;
        }

        private void operation_pressed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
            switch (btn.Text)
            {
                case "+": break;
                case "*": break;
                case "-": break;
                case "/": break;
            }

            
        }
    }
}
