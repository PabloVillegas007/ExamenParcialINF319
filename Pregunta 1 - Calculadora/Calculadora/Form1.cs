using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor;
        double operando1;
        double operando2;
        double res;
        int opcion;
        public Form1()
        {
            InitializeComponent();
            valor = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor = 0;
            opcion = 3;
            operando1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToInt32(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor = 0;
            textBox1.Text = valor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //valor = valor * 10 + Convert.ToDouble(((Button)sender).Text);
            textBox1.Text = valor.ToString() + ",";
            //valor = valor * 1.0;
            //textbox1.text = valor.tostring() + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double sig = Convert.ToDouble(textBox1.Text);
            if (sig > 0)
            {
                sig = sig * (-1);
                textBox1.Text = sig.ToString();
            }
            else
            {
                sig = sig * (-1);
                textBox1.Text = sig.ToString();
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor = 0;
            opcion = 4;
            operando1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor = 0;
            opcion = 1;
            operando1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor = 0;
            opcion = 2;
            operando1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operando2 = Convert.ToDouble(textBox1.Text);
            switch (opcion){
                case 1:
                    res = operando1 + operando2;
                    break;
                case 2:
                    res = operando1 - operando2;
                    break;
                case 3:
                    res = operando1 * operando2;
                    break;
                case 4:
                    res = operando1 / operando2;
                    break;
                default:
                    break;
            }
            
            textBox1.Text = res.ToString();
        }
    }
}
