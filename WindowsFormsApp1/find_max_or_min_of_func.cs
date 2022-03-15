using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class find_max_or_min_of_func
    {

        protected double a;
        protected double b;
        protected double eps;
        // private int kind;
        /// <summary>
        /// Метод поиска минимума/максимума функции на заданном отрезке.
        /// </summary>
        /// <param name="a">Левая граница.</param>
        /// <param name="b">Правая граница.</param>
        /// <param name="eps">Точность или другое.</param>
        public find_max_or_min_of_func()
        {

        }

        public ICulc Culc { private get; set; }

        /*
        protected double func(double x)
        {
            double y = (x + 1) * (x + 1) * (x + 1) + 5 * x * x;
            return y;

        }
        */

        /// <summary>
        /// Поиска минимума/максимума функции на заданном отрезке.
        /// </summary>
        /// <param name="flag">Вариант метода.</param>
        /// <param name="max">Максимум ли?</param>
        /// <returns></returns>
        public Tuple<double, double> do_calc(double a, double b, double eps, ICulc culc, int flag, bool max)
        {
            this.a = a;
            this.b = b;
            this.eps = eps;
            //this.kind = kind;
            Culc = culc;
            return Culc.do_calc(a, b, eps, max);
            ///https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D1%82%D0%BE%D0%B4_%D0%B7%D0%BE%D0%BB%D0%BE%D1%82%D0%BE%D0%B3%D0%BE_%D1%81%D0%B5%D1%87%D0%B5%D0%BD%D0%B8%D1%8F

            if (flag == 1) //Метод золотого сечения 
            {

            }
            if (flag == 2) //Метод чисел Фибоначи
            {


            }


        }

    }


    public interface ICulc
    {

        Tuple<double, double> do_calc(double a, double b, double eps, bool max);
    }

    public class GoldenRatio : ICulc
    {
        public Tuple<double, double> do_calc(double a, double b, double eps, bool max)
        {
            double func(double xa)
            {
                double ya = (xa + 1) * (xa + 1) * (xa + 1) + 5 * xa * xa;
                return ya;

            }

            string text = " ";


            if (a > b)
            {
                double t = a;
                a = b;
                b = a;
            }

            double fin;
            double f = 1.6180339887;
            do
            {
                double x1 = b - (b - a) / f;
                double x2 = a + (b - a) / f;

                double y1 = func(x1);

                double y2 = func(x2);

                if (max == false)
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

            text = "x = " + x + "\n" + "f(x) = " + y;

            //MessageBox.Show(text);
            // MessageBox.Show(Convert.ToString(x));
            // MessageBox.Show(Convert.ToString(y));

            return Tuple.Create(x, y);
        }
    }

    public class Fibonacci : ICulc
    {
        public Tuple<double, double> do_calc(double a, double b, double eps, bool max)
        {
            string text = " ";
            double func(double xa)
            {
                double ya = (xa + 1) * (xa + 1) * (xa + 1) + 5 * xa * xa;
                return ya;

            }
            double n = eps;

            double x;


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

            double y = func(x);
            text = "x = " + x + "\n" + "f(x) = " + y;
            //MessageBox.Show(text);
            return Tuple.Create(x, y);
        }



    }
}
