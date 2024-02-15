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

        /*
        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;
            if(Vector.TryParse(textBox1.Text, out Vector v1))
            {
                a = int.Parse(textBox1.Text);
            }
            if (Vector.TryParse(textBox2.Text, out Vector v2))
            {
                a = int.Parse(textBox2.Text);
            }

            if(v1 != Vector.Parse("0; 0") && v2 != Vector.Parse("0; 0"))
            {
                label2.Text = (v1 * v2).ToString();
            }
            else if(v1 != Vector.Parse("0; 0"))
            {
                label2.Text = (v1 * a).ToString();
            }
            else if (v2 != Vector.Parse("0; 0"))
            {
                label2.Text = (a * v2).ToString();
            }

        }
        */

    }
}
