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
    public partial class number_conversion : Form
    {
        public static string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ+-=()*&?!@#$%/";
        public static string number, totalNumber, upperDigits, digits, convertedToTenth, convertedToOther;
        public static int notation, totalNotation, numberInTenth;

        private void numerationSecondTB_TextChanged(object sender, EventArgs e)
        {
            string notationTXT = numerationSecondTB.Text;

            if (int.TryParse(notationTXT, out int num))
            {
                if (num < 0 || num > 50)
                {
                    TB_NotationError.Visible = true;
                    TB_NotationError.Text = "Введите СС от 2 до 50";
                    btn_toAnswer.Enabled = false;
                }
                else
                {
                    TB_NotationError.Visible = false;
                    btn_toAnswer.Enabled = true;
                }
            }
            else
            {
                TB_NotationError.Visible = true;
                TB_NotationError.Text = "Введите СС числом от 2 до 50";
                btn_toAnswer.Enabled = false;
            }
        }

        private void numerationFirstTB_TextChanged(object sender, EventArgs e)
        {
            string notationTXT = numerationFirstTB.Text;

            if(int.TryParse(notationTXT, out int num))
            {
                if (num < 0 || num > 50)
                {
                    TB_NotationError.Visible = true;
                    TB_NotationError.Text = "Введите СС от 2 до 50";
                    btn_toAnswer.Enabled = false;
                }
                else
                {
                    TB_NotationError.Visible = false;
                    btn_toAnswer.Enabled = true;
                }
            }
            else
            {
                TB_NotationError.Visible = true;
                TB_NotationError.Text = "Введите СС числом от 2 до 50";
                btn_toAnswer.Enabled = false;
            }
        }

        private void numberTB_TextChanged(object sender, EventArgs e)
        {
            string numberTXT = numberTB.Text;
            int count = 0;

            if (!string.IsNullOrEmpty(numberTXT))
            {
                for (int i = 0; i < numberTXT.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (numberTXT[i] == alphabet[j]) count++;
                    }
                }

                if (count != numberTXT.Length)
                {
                    Error_TB.Visible = true;
                    btn_toAnswer.Enabled = false;
                }
                else
                {
                    Error_TB.Visible = false;
                    btn_toAnswer.Enabled = true;
                }
            }
            else
            {
                btn_toAnswer.Enabled = false;
            }
        }

        public number_conversion()
        {
            InitializeComponent();
        }

        public static int ConvertToTenth(string alphabet, string number, int notation)
        {
            int numberInTen = 0;
            int power = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                upperDigits += $"{i} ";
                if (char.IsDigit(number[i]))
                {
                    int digit = Convert.ToInt32(number[i].ToString());
                    numberInTen += digit * (int)(Math.Pow(notation, power));

                    digits += $"{number[(number.Length - 1) - i]} ";
                    convertedToTenth += $"{digit} * {notation} ^ {power}";
                    if (i != 0) convertedToTenth += " + ";
                }
                else
                {
                    int digit = 0;
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (alphabet[j] == number[i]) digit = j;
                    }

                    numberInTen += digit * (int)(Math.Pow(notation, power));

                    digits += $"{number[(number.Length - 1) - i]} ";
                    convertedToTenth += $"{digit} * {notation} ^ {power}";
                    if (i != 0) convertedToTenth += " + ";
                }
                power++;
            }
            convertedToTenth += $" = {numberInTen}";

            return numberInTen;
        }

        private static string ConvertToOther(string alphabet, int totalNotation, int numberInTen)
        {
            string answer = "";
            string reversedAnswer = "";

            convertedToOther = "Для перевода в любую СС мы будем брать остатки от деления десятичного представления числа" +
                " на нужную систему счисления, после чего поделим целочисленно наше число на ту же систему счисления \n\n";

            while (numberInTen != 0)
            {
                reversedAnswer += alphabet[numberInTen % totalNotation];

                convertedToOther += $"    {numberInTen} % {totalNotation} = {numberInTen % totalNotation} = {alphabet[numberInTen % totalNotation]} \n";
                convertedToOther += $"{numberInTen} // {totalNotation} = {numberInTen / totalNotation} \n";
                numberInTen /= totalNotation;
            }

            convertedToOther += "Собираем остатки в обратном порядке \n";

            for (int i = reversedAnswer.Length - 1; i >= 0; i--)
            {
                answer += reversedAnswer[i];
            }

            convertedToOther += $"Ответ {answer}";

            return answer;
        }

        private void number_conversion_Load(object sender, EventArgs e)
        {

        }

        private void btn_toAnswer_Click(object sender, EventArgs e)
        {
            number = numberTB.Text;
            notation = Convert.ToInt32(numerationFirstTB.Text);
            totalNotation = Convert.ToInt32(numerationSecondTB.Text);
            numberInTenth = ConvertToTenth(alphabet, number, notation);
            totalNumber = ConvertToOther(alphabet, totalNotation, numberInTenth);

            Answer answer = new Answer();
            answer.Show();
            this.Visible = false;
        }
    }
}
