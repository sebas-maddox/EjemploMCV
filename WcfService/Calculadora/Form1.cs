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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                cliente.GetSuma(a, b);
                lbResultado.Text = cliente.GetSuma(a,b).ToString();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                cliente.GetResta(a, b);
                lbResultado.Text = cliente.GetResta(a, b).ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                cliente.GetMultiplicacion(a, b);
                lbResultado.Text = cliente.GetMultiplicacion(a, b).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                cliente.GetDivision(a, b);
                lbResultado.Text = cliente.GetDivision(a, b).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
