using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            textBox1.Text = "-15,246"; // Начальное значение X

            textBox2.Text = "4,642*10"; // Начальное значение Y

            textBox3.Text = "20,001*10";// Начальное значение Z

            textBox5.Text = "Лаб. раб. N15. гр-ИП-41 Мачехин Н.В";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X

            double x = double.Parse(textBox1.Text);

            // Вывод значения X в окно

            textBox5.Text += Environment.NewLine +

            "X = " + x.ToString();

            // Считывание значения Y

            double y = double.Parse(textBox2.Text);

            // Вывод значения Y в окно

            textBox5.Text += Environment.NewLine +

            "Y = " + y.ToString();

            // Считывание значения Z

            double z = double.Parse(textBox3.Text);

            // Вывод значения Z в окно

            textBox5.Text += Environment.NewLine +

            "Z = " + z.ToString();

            // Вычисляем арифметическое выражение

            double a = Math.Log(y - Math.Sqrt(Math.Abs(x))) * (x - y/2) + Math.Sin(Math.Atan(z));

            // Выводим результат в окно

            textBox5.Text += Environment.NewLine +

            "Результат a = " + a.ToString();
        }
    }
}
