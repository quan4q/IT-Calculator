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
    public partial class RomeNotation : Form
    {
        public static string explanation, answer;

        public RomeNotation()
        {
            InitializeComponent();
        }

        private void btn_ConvertToRome_Click(object sender, EventArgs e)
        {
            answer = ConvertToRome(tb_NumberToRome.Text);

            RomeNotationAnswer rna = new RomeNotationAnswer();
            rna.Show();
            this.Visible = false;
        }

        private void tb_NumberToRome_TextChanged(object sender, EventArgs e)
        {
            string numberTXT = tb_NumberToRome.Text;

            if(int.TryParse(numberTXT, out int num))
            {
                if (num > 3999)
                {
                    lb_Error.Text = "Введите число меньше, чем 3999";
                    lb_Error.Visible = true;
                    btn_ConvertToRome.Enabled = false;
                }
                else
                {
                    lb_Error.Visible = false;
                    btn_ConvertToRome.Enabled = true;
                }
            }
            else
            {
                lb_Error.Text = "Введите число используя только цифры";
                lb_Error.Visible = true;
                btn_ConvertToRome.Enabled = false;
            }
        }

        private void RomeNotation_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private string ConvertToRome(string number)
        {
            int[] dictInt = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string[] dictString = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string roman = "";
            int num = int.Parse(number);

            explanation += "Для перевода числа в Римскую СС будем использовать следующий список: \n";

            for(int i = 0; i < dictInt.Length; i++)
            {
                explanation += $"{dictInt[i]} = {dictString[i]}  ";
            }

            explanation += "\n";
            explanation += "Чтобы перевести десятичное число в Римскую СС мы будем идти по нашему списку и проверять больше или равно ли наше число, чем число списка.\n";
            explanation += "В случае, если оно больше или равно, будем записывать букву(ы) соответствующую(ие) числу из списка, а из изначального числа вычитать число из списка\n\n";

            while(num > 0)
            {
                for(int i = 0; i < dictInt.Length; i++)
                {
                    while(num >= dictInt[i])
                    {
                        explanation += $"{num} >= {dictInt[i]}: \n";
                        roman += dictString[i];
                        explanation += $"Число в римской = {roman}\n";
                        explanation += $"{num} - {dictInt[i]} = ";
                        num -= dictInt[i];
                        explanation += $"{num}\n";
                    }
                }
            }
            explanation += $"Наше число стало равным нулю, самое время записать ответ \n Ответ: {roman}";
            return roman;
        }
    }
}
