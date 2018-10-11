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
    public partial class Calculadora2 : Form
    {
        int operacion = 0;
        int c, d;
        public Calculadora2()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacion = 1;
            
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                c = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();


            }
        }

        private void Calculadora2_Load(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operacion = 2;
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                c = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operacion = 3;
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                c = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operacion = 4;
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                c = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
                textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                d = Convert.ToInt32(textBox1.Text);
                int a = c;
                int b = d;
                if (operacion == 1)
                {
                    cliente.GetSuma(a, b);
                    textBox1.Text = cliente.GetSuma(a, b).ToString();

                }
                else if (operacion == 2)
                {
                    cliente.GetResta(a, b);
                    textBox1.Text = cliente.GetResta(a, b).ToString();

                }
                else if (operacion == 3)
                {
                    cliente.GetMultiplicacion(a, b);
                    textBox1.Text = cliente.GetMultiplicacion(a, b).ToString();

                }
                else
                {
                    cliente.GetDivision(a, b);
                    textBox1.Text = cliente.GetDivision(a, b).ToString();

                }

            }
        }
    }
}
