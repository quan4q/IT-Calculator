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
    public partial class RomeNotationAnswer : Form
    {
        public RomeNotationAnswer()
        {
            InitializeComponent();
        }

        private void RomeNotationAnswer_Load(object sender, EventArgs e)
        {
            lb_ExplanationOfRoman.Text = RomeNotation.explanation;
            lb_Answer.Text = $"Ответ: {RomeNotation.answer}";
        }

        private void btn_ToMainScreen_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Visible = false;

            RomeNotation.explanation = "";
        }
    }
}
