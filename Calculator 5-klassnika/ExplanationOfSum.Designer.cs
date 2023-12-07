
namespace Calculator_5_klassnika
{
    partial class ExplanationOfSum
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_explanation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(921, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "При суммировании используется следующий алфавит: \"0 1 2 3 4 5 6 7 8 9 A B C D E F" +
    " G H I J K L M N O P Q R S T U V W X Y Z + - = ( ) * & ? ! @ # $ % /\" ";
            // 
            // lb_explanation
            // 
            this.lb_explanation.AutoSize = true;
            this.lb_explanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_explanation.ForeColor = System.Drawing.Color.Purple;
            this.lb_explanation.Location = new System.Drawing.Point(15, 47);
            this.lb_explanation.Name = "lb_explanation";
            this.lb_explanation.Size = new System.Drawing.Size(46, 18);
            this.lb_explanation.TabIndex = 1;
            this.lb_explanation.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(545, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // btn_ToMenu
            // 
            this.btn_ToMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ToMenu.Location = new System.Drawing.Point(1033, 2);
            this.btn_ToMenu.Name = "btn_ToMenu";
            this.btn_ToMenu.Size = new System.Drawing.Size(151, 41);
            this.btn_ToMenu.TabIndex = 3;
            this.btn_ToMenu.Text = "В меню";
            this.btn_ToMenu.UseVisualStyleBackColor = false;
            this.btn_ToMenu.Click += new System.EventHandler(this.btn_ToMenu_Click);
            // 
            // ExplanationOfSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1196, 644);
            this.Controls.Add(this.btn_ToMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_explanation);
            this.Controls.Add(this.label1);
            this.Name = "ExplanationOfSum";
            this.Text = "Объяснение и решение";
            this.Load += new System.EventHandler(this.ExplanationOfSum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_explanation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ToMenu;
    }
}