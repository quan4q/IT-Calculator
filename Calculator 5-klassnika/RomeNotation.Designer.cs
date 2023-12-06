
namespace Calculator_5_klassnika
{
    partial class RomeNotation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_NumberToRome = new System.Windows.Forms.TextBox();
            this.btn_ConvertToRome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_NumberToRome
            // 
            this.tb_NumberToRome.Location = new System.Drawing.Point(272, 132);
            this.tb_NumberToRome.Name = "tb_NumberToRome";
            this.tb_NumberToRome.Size = new System.Drawing.Size(266, 20);
            this.tb_NumberToRome.TabIndex = 0;
            this.tb_NumberToRome.TextChanged += new System.EventHandler(this.tb_NumberToRome_TextChanged);
            // 
            // btn_ConvertToRome
            // 
            this.btn_ConvertToRome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ConvertToRome.Location = new System.Drawing.Point(253, 226);
            this.btn_ConvertToRome.Name = "btn_ConvertToRome";
            this.btn_ConvertToRome.Size = new System.Drawing.Size(304, 129);
            this.btn_ConvertToRome.TabIndex = 1;
            this.btn_ConvertToRome.Text = "Перевести";
            this.btn_ConvertToRome.UseVisualStyleBackColor = false;
            this.btn_ConvertToRome.Click += new System.EventHandler(this.btn_ConvertToRome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перевод в римскую СС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(295, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите число (до 3999)";
            // 
            // lb_Error
            // 
            this.lb_Error.AutoSize = true;
            this.lb_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Error.ForeColor = System.Drawing.Color.Red;
            this.lb_Error.Location = new System.Drawing.Point(269, 175);
            this.lb_Error.Name = "lb_Error";
            this.lb_Error.Size = new System.Drawing.Size(46, 17);
            this.lb_Error.TabIndex = 4;
            this.lb_Error.Text = "label3";
            this.lb_Error.Visible = false;
            // 
            // RomeNotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConvertToRome);
            this.Controls.Add(this.tb_NumberToRome);
            this.Name = "RomeNotation";
            this.Text = "Перевод в Римскую СС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RomeNotation_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NumberToRome;
        private System.Windows.Forms.Button btn_ConvertToRome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Error;
    }
}