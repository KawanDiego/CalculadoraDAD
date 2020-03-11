using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02
{
    public partial class Form1 : Form
    {

        int op = 0;//controle de operação matemática
        double r = 0, n1 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Botão vezes
            op = 3;
            n1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Apaga o último número digitado
            textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Botão mais
            op = 1;
            n1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(",")))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Botão menos
            op = 2;
            n1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Botão dividir
            op = 4;
            n1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Botão igual
            switch (op)
            {
                case 1:
                    r = n1 + double.Parse(textBox1.Text);
                    textBox1.Text = r.ToString();
                    break;
                case 2:
                    r = n1 - double.Parse(textBox1.Text);
                    textBox1.Text = r.ToString();
                    break;
                case 3:
                    r = n1 * double.Parse(textBox1.Text);
                    textBox1.Text = r.ToString();
                    break;
                case 4:
                    if (double.Parse(textBox1.Text) != 0)
                    {
                        r = n1 / double.Parse(textBox1.Text);
                        textBox1.Text = r.ToString();
                    }
                    else
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "ERRO";
                    }
                    break;
            }
        }
    }
}
