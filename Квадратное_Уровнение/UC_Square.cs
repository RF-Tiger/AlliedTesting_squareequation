using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квадратное_Уровнение
{
    public partial class UC_Square : UserControl
    {

        double a, b, c, d;
        public UC_Square()
        {
            InitializeComponent();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = (b * b) - (4 * a * c);
            textBox6.Text = "  ";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (d < 0)
            {
                textBox6.Text ="Дискриминант меньше нуля. Корней нет.";
            }

            else if (d == 0)
            {
                double x = (-b / (2 * a));
                textBox6.Text = "Дискриминант равен нулю. Корень равен " + x + ".";
            }

            else 
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                textBox6.Text="Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".";
            }
        }
    }
}
