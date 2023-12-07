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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number_conversion conv = new number_conversion();
            conv.Show();
            this.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ToRome_Click(object sender, EventArgs e)
        {
            RomeNotation rome = new RomeNotation();
            rome.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Summation sum = new Summation();
            sum.Show();
            this.Visible = false;
        }
    }
}
