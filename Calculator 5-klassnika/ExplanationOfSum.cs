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
    public partial class ExplanationOfSum : Form
    {
        public ExplanationOfSum()
        {
            InitializeComponent();
        }

        private void ExplanationOfSum_Load(object sender, EventArgs e)
        {
            lb_explanation.Text = Summation.explanation;
            label2.Text = $"Ответ: {Summation.answer}";
        }

        private void btn_ToMenu_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }
    }
}
