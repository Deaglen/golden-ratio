using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double func(double xa)
            {
                double ya = (xa + 1) * (xa + 1) * (xa + 1) + 5 * xa * xa;
                return ya;

            }

            //var text = textBox1.Text;
            double a = double.Parse(textBox1.Text); //-2
            double b = double.Parse(textBox2.Text); //2
            double eps = double.Parse(textBox3.Text); //0.001
            a = -2;
            //a = textBox1.Text;
            // double b = 2;
            if (a > b)
            {
                double t = a;
                a = b;
                b = a;
            }
            //double eps = 0.001;
            double fin;
            double f = 1.6180339887;
            do
            {
                double x1 = b - (b - a) / f;
                double x2 = a + (b - a) / f;

                double y1 = func(x1);
                double y2 = func(x2);

                if (checkBox1.Checked)
                {
                    if (y1 >= y2)
                        a = x1;
                    else
                        b = x2;
                }
                else
                {
                    if (y1 <= y2)
                        a = x1;
                    else
                        b = x2;

                }
                    fin = b - a;
                if (fin < 0)
                {
                    fin = -fin;
                }

            }
            while (fin >= eps);
            double x = (a + b) / 2;
            double y = func(x);
            string text = "x = " + x + "\n" + "f(x) = " + y;
            MessageBox.Show(text);
            // MessageBox.Show(Convert.ToString(x));
            // MessageBox.Show(Convert.ToString(y));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
