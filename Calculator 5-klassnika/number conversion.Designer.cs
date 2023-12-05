
namespace Calculator_5_klassnika
{
    partial class number_conversion
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
            this.numberTB = new System.Windows.Forms.TextBox();
            this.numerationFirstTB = new System.Windows.Forms.TextBox();
            this.numerationSecondTB = new System.Windows.Forms.TextBox();
            this.btn_toAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Error_TB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(66, 256);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(174, 20);
            this.numberTB.TabIndex = 0;
            this.numberTB.TextChanged += new System.EventHandler(this.numberTB_TextChanged);
            // 
            // numerationFirstTB
            // 
            this.numerationFirstTB.Location = new System.Drawing.Point(286, 277);
            this.numerationFirstTB.Name = "numerationFirstTB";
            this.numerationFirstTB.Size = new System.Drawing.Size(38, 20);
            this.numerationFirstTB.TabIndex = 1;
            // 
            // numerationSecondTB
            // 
            this.numerationSecondTB.Location = new System.Drawing.Point(402, 277);
            this.numerationSecondTB.Name = "numerationSecondTB";
            this.numerationSecondTB.Size = new System.Drawing.Size(38, 20);
            this.numerationSecondTB.TabIndex = 2;
            // 
            // btn_toAnswer
            // 
            this.btn_toAnswer.Location = new System.Drawing.Point(610, 214);
            this.btn_toAnswer.Name = "btn_toAnswer";
            this.btn_toAnswer.Size = new System.Drawing.Size(178, 62);
            this.btn_toAnswer.TabIndex = 3;
            this.btn_toAnswer.Text = "Перевести";
            this.btn_toAnswer.UseVisualStyleBackColor = true;
            this.btn_toAnswer.Click += new System.EventHandler(this.btn_toAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Начальная СС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Конечная СС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "-->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(743, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "При переводе используется следующий алфавит: \"0 1 2 3 4 5 6 7 8 9 A B C D E F G H" +
    " I J K L M N O P Q R S T U V W X Y Z + - = ( ) * & ? ! @ # $ % /\" ";
            // 
            // Error_TB
            // 
            this.Error_TB.AutoSize = true;
            this.Error_TB.ForeColor = System.Drawing.Color.Red;
            this.Error_TB.Location = new System.Drawing.Point(63, 323);
            this.Error_TB.Name = "Error_TB";
            this.Error_TB.Size = new System.Drawing.Size(295, 13);
            this.Error_TB.TabIndex = 9;
            this.Error_TB.Text = "Некорректный ввод, используйте символы из алфавита";
            this.Error_TB.Visible = false;
            // 
            // number_conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_toAnswer);
            this.Controls.Add(this.numerationSecondTB);
            this.Controls.Add(this.numerationFirstTB);
            this.Controls.Add(this.numberTB);
            this.Name = "number_conversion";
            this.Text = "Перевод в другую СС";
            this.Load += new System.EventHandler(this.number_conversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.TextBox numerationFirstTB;
        private System.Windows.Forms.TextBox numerationSecondTB;
        private System.Windows.Forms.Button btn_toAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Error_TB;
    }
}