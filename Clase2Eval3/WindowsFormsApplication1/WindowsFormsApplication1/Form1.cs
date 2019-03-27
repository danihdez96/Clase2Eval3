using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Suma_Click(object sender, EventArgs e)
        {
            Suma ope1 = new Suma();
            ope1.V1 = double.Parse(textBox1.Text);
            ope1.V2 = double.Parse(textBox2.Text);
            label3.Text = ope1.calcular().ToString();

        }

        private void Resta_Click(object sender, EventArgs e)
        {
            Resta ope2 = new Resta();
            ope2.V1 = double.Parse(textBox1.Text);
            ope2.V2 = double.Parse(textBox2.Text);
            label3.Text = ope2.calcular().ToString();
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            Multiplicacion ope3 = new Multiplicacion();
            ope3.V1 = double.Parse(textBox1.Text);
            ope3.V2 = double.Parse(textBox2.Text);
            label3.Text = ope3.calcular().ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
              Division ope4 = new Division();
              ope4.V1 = double.Parse(textBox1.Text);
              ope4.V2 = double.Parse(textBox2.Text);
              label3.Text = ope4.calcular().ToString();
        }
    }
}
