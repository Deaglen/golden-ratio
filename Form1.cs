using System;
using System.Windows.Forms;


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





            // double x;
            double a = double.Parse(textBox1.Text); //-2
            double b = double.Parse(textBox2.Text); //2
            double eps = double.Parse(textBox3.Text); //0.001



            bool max = true;
            if (checkBox1.Checked)
                max = false;

            int type = 1;
            if (checkBox2.Checked)
            {
                type = 2;
                find_max_or_min_of_func A = new find_max_or_min_of_func(a, b, eps, new Fibonacci());
                string text = A.do_calc(type, max);
                MessageBox.Show(text);
            }
            else
            {
                find_max_or_min_of_func A = new find_max_or_min_of_func(a, b, eps, new GoldenRatio());
                string text = A.do_calc(type, max);
                MessageBox.Show(text);
            }



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

/*
if (checkBox1.Checked)
    double x;
    double a = double.Parse(textBox1.Text); //-2
    double b = double.Parse(textBox2.Text); //2
    double n = double.Parse(textBox3.Text); //0.001

    double x1 = a + (b - a) * func(n - 2) / func(n);
    double x2 = a + (b - a) * func(n - 1) / func(n);

    double y1 = func(x1);
    double y2 = func(x2);

    while (1 == 1)
    {
        n = n - 1;
        if (y1 > y2)
        {
            a = x1;
            x1 = x2;
            x2 = b - (x1 - a);
            y1 = y2;
            y2 = func(x2);
        }
        else
        {
            b = x2;
            x2 = x1;
            x1 = a + (b - x2);
            y2 = y1;
            y1 = func(x1);
        }

        if (n == 1)
        {
            x = (x1 + x2) / 2;
            break;
        }

    }

    double y = this.func(x);
    string text = "x = " + x + "\n" + "f(x) = " + y;
    MessageBox.Show(text);
}
else
{
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
*/