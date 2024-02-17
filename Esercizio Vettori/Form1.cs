using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_Vettori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse(textBox2.Text);
            label1.Text = (v1 + v2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse(textBox2.Text);
            label1.Text = (v1 - v2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox3.Text);
            label2.Text = (+v1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox3.Text);
            label2.Text = (-v1).ToString();
        }

    }
}
