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
    public partial class Summation : Form
    {
        public static string explanation, answer;

        public Summation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = summation(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            answer = label1.Text;
            ExplanationOfSum eos = new ExplanationOfSum();
            eos.Show();
            this.Visible = false;

        }

        private string summation(string firstNumber, string secondNumber, int notation)
        {
            List<int> firstNumberArray = new List<int>();
            List<int> secondNumberArray = new List<int>();
            Stack<int> upperNumbers = new Stack<int>();
            bool IsFirstHigher = true;
            string reversedAnswer = "", answer = "";

            explanation = $"Вы ввели {notation} - ую СС, поэтому\n";
            explanation += $"При сложении в столбик, каждый раз, когда наша сумма цифр становится большей или равной {notation} мы будем переносить единицу в следующий разряд\nЕсли в следующем разряде нет цифры, просто спускаем единицу\n\n\n";

            for (int i = 0; i < firstNumber.Length; i++)
            {
                if (char.IsDigit(firstNumber[i]))
                {
                    firstNumberArray.Add(int.Parse(Convert.ToString(firstNumber[i])));
                }
                else
                {
                    for(int j = 0; j<number_conversion.alphabet.Length; j++)
                    {
                        if(firstNumber[i] == number_conversion.alphabet[j])
                        {
                            firstNumberArray.Add(j);
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < secondNumber.Length; i++)
            {
                if (char.IsDigit(secondNumber[i]))
                {
                    secondNumberArray.Add(int.Parse(Convert.ToString(secondNumber[i])));
                }
                else
                {
                    for (int j = 0; j < number_conversion.alphabet.Length; j++)
                    {
                        if (secondNumber[i] == number_conversion.alphabet[j])
                        {
                            secondNumberArray.Add(j);
                            break;
                        }
                    }
                }
            }

            if(firstNumberArray.Count > secondNumberArray.Count)
            {
                while(firstNumberArray.Count != secondNumberArray.Count)
                {
                    secondNumberArray.Insert(0, 0);
                }
            }
            else if(firstNumberArray.Count < secondNumberArray.Count)
            {
                IsFirstHigher = false;
                while (firstNumberArray.Count != secondNumberArray.Count)
                {
                    firstNumberArray.Insert(0, 0);
                }
            }

            if (IsFirstHigher)
            {
                int positionCount = firstNumberArray.Count+1, count = 0;
                string numbers = "";

                explanation += $"{firstNumber} + \n";
                int k = 0;

                if (firstNumber.Length != secondNumber.Length)
                {
                    while (secondNumberArray[k] == 0)
                    {
                        explanation += " ";
                        k++;
                    }
                    explanation += " ";
                }

                explanation += secondNumber + "\n";
                
                for(int i = 0; i < firstNumber.Length; i++)
                {
                    explanation += "—";
                }
                explanation += "\n\n";

                for(int i = firstNumberArray.Count-1; i >= 0; i--)
                {
                    int sum = firstNumberArray[i] + secondNumberArray[i];

                    if(upperNumbers.Count != 0)
                    {
                        sum += upperNumbers.Pop();
                        for (int l = 0; l < i; l++) explanation += " ";
                        explanation += "1\n";
                    }
                    
                    explanation += $"{firstNumber} + \n";
                    int g = 0;

                    if (firstNumber.Length != secondNumber.Length)
                    {
                        while (secondNumberArray[k] == 0)
                        {
                            explanation += " ";
                            k++;
                        }
                        explanation += " ";
                    }

                    explanation += secondNumber + "\n";

                    for (int q = 0; q < firstNumber.Length; q++)
                    {
                        explanation += "—";
                    }

                    explanation += "\n";

                    if (sum >= notation)
                    {
                        upperNumbers.Push(1);

                        if(sum - notation >= 10)
                        {
                            reversedAnswer += number_conversion.alphabet[sum - notation];

                            for (int h = 0; h < positionCount; h++) explanation += " ";
                            positionCount--;
                            numbers = numbers.Insert(0, reversedAnswer[count].ToString());
                            explanation += numbers + "\n\n";
                            count++;
                        }
                        else
                        {
                            reversedAnswer += sum - notation;

                            for (int h = 0; h < positionCount; h++) explanation += " ";
                            positionCount--;
                            numbers = numbers.Insert(0, reversedAnswer[count].ToString());
                            explanation += numbers + "\n\n";
                            count++;
                        }
                    }
                    else
                    {
                        reversedAnswer += sum;

                        for (int h = 0; h < positionCount; h++) explanation += " ";
                        positionCount--;
                        numbers = numbers.Insert(0, reversedAnswer[count].ToString());
                        explanation += numbers + "\n\n";
                        count++;
                    }

                }
                if (upperNumbers.Count != 0)
                {
                    reversedAnswer += upperNumbers.Pop();
                    explanation += $"{firstNumber} + \n";
                    int g = 0;

                    if (firstNumber.Length != secondNumber.Length)
                    {
                        while (secondNumberArray[k] == 0)
                        {
                            explanation += " ";
                            k++;
                        }
                        explanation += " ";
                    }

                    explanation += secondNumber + "\n";

                    for (int q = 0; q < firstNumber.Length; q++)
                    {
                        explanation += "—";
                    }

                    explanation += "\n";
                    numbers = numbers.Insert(0, reversedAnswer[count].ToString());
                    explanation += numbers + "\n\n";
                }
                explanation += "\n";
            }
            else
            {
                int positionCount = secondNumberArray.Count + 1, count = 0;
                string numbers = "";

                explanation += $"{secondNumber} + \n";
                int k = 0;

                if (firstNumber.Length != secondNumber.Length)
                {
                    while (firstNumberArray[k] == 0)
                    {
                        explanation += " ";
                        k++;
                    }
                    explanation += " ";
                }

                explanation += firstNumber + "\n";

                for (int i = 0; i < secondNumber.Length; i++)
                {
                    explanation += "—";
                }
                explanation += "\n\n";

                for (int i = firstNumberArray.Count - 1; i >= 0; i--)
                {
                    int sum = firstNumberArray[i] + secondNumberArray[i];
                    if (upperNumbers.Count != 0)
                    {
                        sum += upperNumbers.Pop();
                        for (int l = 0; l < i; l++) explanation += " ";
                        explanation += "1\n";
                    }

                    explanation += $"{secondNumber} + \n";
                    int g = 0;

                    if (firstNumber.Length != secondNumber.Length)
                    {
                        while (firstNumberArray[k] == 0)
                        {
                            explanation += " ";
                            k++;
                        }
                        explanation += " ";
                    }

                    explanation += firstNumber + "\n";

                    for (int q = 0; q < secondNumber.Length; q++)
                    {
                        explanation += "—";
                    }

                    explanation += "\n";

                    if (sum >= notation)
                    {
                        upperNumbers.Push(1);

                        if (sum - notation >= 10)
                        {
                            reversedAnswer += number_conversion.alphabet[sum - notation];

                            for (int h = 0; h < positionCount; h++) explanation += " ";
                            positionCount--;
                            numbers = numbers.Insert(0, reversedAnswer[count].ToString());
                            explanation += numbers + "\n\n";
                            count++;
                        }
                        else
                        {
                            reversedAnswer += sum - notation;

                            for (int h = 0; h < positionCount; h++) explanation += " ";
                            positionCount--;
                            numbers = numbers.Insert(0, reversedAnswer[count].ToString());
                            explanation += numbers + "\n\n";
                            count++;
                        }
                    }
                    else
                    {
                        reversedAnswer += sum;

                        for (int h = 0; h < positionCount; h++) explanation += " ";
                        positionCount--;
                        numbers = numbers.Insert(0, reversedAnswer[count].ToString());
                        explanation += numbers + "\n\n";
                        count++;
                    }

                    if (upperNumbers.Count != 0)
                    {
                        reversedAnswer += upperNumbers.Pop();
                        explanation += $"{secondNumber} + \n";
                        

                        if (firstNumber.Length != secondNumber.Length)
                        {
                            while (firstNumberArray[k] == 0)
                            {
                                explanation += " ";
                                k++;
                            }
                            explanation += " ";
                        }

                        explanation += firstNumber + "\n";

                        for (int q = 0; q < secondNumber.Length; q++)
                        {
                            explanation += "—";
                        }

                        explanation += "\n";
                        numbers = numbers.Insert(0, reversedAnswer[count].ToString());
                        explanation += numbers + "\n\n";
                    }
                    explanation += "\n";
                }
            }

            for(int i = reversedAnswer.Length-1; i >= 0; i--)
            {
                answer += reversedAnswer[i];
            }

            return answer;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string firstNumberTXT = textBox1.Text;
            for(int i = 0; i < firstNumberTXT.Length; i++)
            { 
                bool IsGood = false;
                for(int j = 0; j < number_conversion.alphabet.Length; j++)
                {
                    if (number_conversion.alphabet[j] == firstNumberTXT[i]) IsGood = true;
                }

                if (!IsGood)
                {
                    lb_ErrorFirstNum.Text = "Введите число, используя символы алфавита";
                    lb_ErrorFirstNum.Visible = true;
                    btn_ToExplanation.Enabled = false;
                }
                else
                {
                    lb_ErrorFirstNum.Visible = false;
                    btn_ToExplanation.Enabled = true;
                }  
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string secondNumberTXT = textBox2.Text;
            for (int i = 0; i < secondNumberTXT.Length; i++)
            {
                bool IsGood = false;
                for (int j = 0; j < number_conversion.alphabet.Length; j++)
                {
                    if (number_conversion.alphabet[j] == secondNumberTXT[i]) IsGood = true;
                }

                if (!IsGood)
                {
                    lb_ErrorFirstNum.Text = "Введите число, используя символы алфавита";
                    lb_ErrorFirstNum.Visible = true;
                    btn_ToExplanation.Enabled = false;
                }
                else
                {
                    lb_ErrorFirstNum.Visible = false;
                    btn_ToExplanation.Enabled = true;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string notationTXT = textBox3.Text;

            if (int.TryParse(notationTXT, out int num))
            {
                if (num < 0 || num > 50)
                {
                    lb_ErrorNotation.Visible = true;
                    lb_ErrorNotation.Text = "Введите СС от 2 до 50";
                    btn_ToExplanation.Enabled = false;
                }
                else
                {
                    lb_ErrorNotation.Visible = false;
                    btn_ToExplanation.Enabled = true;
                }
            }
            else
            {
                lb_ErrorNotation.Visible = true;
                lb_ErrorNotation.Text = "Введите СС числом от 2 до 50";
                btn_ToExplanation.Enabled = false;
            }
        }
    }
}
