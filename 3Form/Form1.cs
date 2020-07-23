using System;
using System.Windows.Forms;

namespace _3Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindMinLenButton(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Сheck(textBox1.Text) &&
                textBox2.Text != "" && Сheck(textBox2.Text) &&
                textBox3.Text != "" && Сheck(textBox3.Text) &&
                textBox4.Text != "" && Сheck(textBox4.Text) &&
                textBox5.Text != "" && Сheck(textBox5.Text) &&
                textBox6.Text != "" && Сheck(textBox6.Text))
            {
                double line1 = f(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox6.Text),
                    Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox5.Text));
                double line2 = f(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox5.Text)
                    , Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
                double line3 = f(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text),
                    Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox6.Text));

                double minLine = min(min(line1, line2), line3);
                if (minLine == line1)
                    textBox7.Text = ("Координаты точек расстаяние которых минимально : " +
                        "[ " + textBox1.Text + "; " + textBox6.Text + " ]" + ", " + "[ " + textBox2.Text + "; " + textBox5.Text + " ]");
                else if (minLine == line2) textBox7.Text = ("Координаты точек расстаяние которых минимально : " +
                    "[ " + textBox2.Text + "; " + textBox5.Text + " ]" + ", " + "[ " + textBox3.Text + "; " + textBox4.Text + " ]");
                else textBox7.Text = ("Координаты точек расстаяние которых минимально : " +
                    "[ " + textBox3.Text + "; " + textBox4.Text + " ]" + ", " + "[ " + textBox1.Text + "; " + textBox6.Text + " ]");
            }
        }
        private bool Сheck(String s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!char.IsDigit(arr[i]) && arr[i] == '-' && arr[i] != ',')
                {
                    return false;
                }
            }
            return true;
        }
        public double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        public double min(double a, double b)
        {
            return (a <= b) ? a : b;
        }

        private void FindFunc(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && Сheck(textBox10.Text) &&
                textBox9.Text != "" && Сheck(textBox9.Text) &&
                textBox8.Text != "" && Сheck(textBox8.Text)) {
                for (double i = Convert.ToDouble(textBox10.Text); i <= Convert.ToDouble(textBox9.Text);
                    i += Convert.ToDouble(textBox8.Text))
                {
                    textBox11.AppendText("f(" + i + ")=" + f(Convert.ToDouble(textBox10.Text), Convert.ToDouble(textBox9.Text), i));
                    textBox11.AppendText(Environment.NewLine);
                }
            }
        }
        public double f(double a, double b, double x)
        {
            if (x < 93) return a + b * x;
            else if (x > 120) return a * b * x;
            else return b - a * x;
        }
    }
}
