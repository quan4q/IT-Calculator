using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_5_klassnika
{
    public partial class Answer : Form
    {
        public Answer()
        {
            InitializeComponent();
        }

        private void Answer_Load(object sender, EventArgs e)
        {
            label1.Text = $"Вы ввели число: {number_conversion.number} в {number_conversion.notation} - ой системе счисления";
            label2.Text = $"Мы переводим его в {number_conversion.totalNotation} - ую систему счисления";
            label3.Text = $"Пронумеруем каждую цирфу справа налево, начиная с нуля";
            label4.Text = number_conversion.upperDigits;
            label5.Text = number_conversion.digits;
            label6.Text = number_conversion.convertedToTenth;
            LB_ConvertedToOther.Text = number_conversion.convertedToOther;
            LB_answer.Text = $"Ответ: {Convert.ToString(number_conversion.totalNumber)}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            start.Show();
            this.Visible = false;
        }
    }
}
