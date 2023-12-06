
namespace Calculator_5_klassnika
{
    partial class RomeNotationAnswer
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
            this.lb_ExplanationOfRoman = new System.Windows.Forms.Label();
            this.btn_ToMainScreen = new System.Windows.Forms.Button();
            this.lb_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_ExplanationOfRoman
            // 
            this.lb_ExplanationOfRoman.AutoSize = true;
            this.lb_ExplanationOfRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lb_ExplanationOfRoman.ForeColor = System.Drawing.Color.Purple;
            this.lb_ExplanationOfRoman.Location = new System.Drawing.Point(13, 13);
            this.lb_ExplanationOfRoman.Name = "lb_ExplanationOfRoman";
            this.lb_ExplanationOfRoman.Size = new System.Drawing.Size(45, 16);
            this.lb_ExplanationOfRoman.TabIndex = 0;
            this.lb_ExplanationOfRoman.Text = "label1";
            // 
            // btn_ToMainScreen
            // 
            this.btn_ToMainScreen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ToMainScreen.Location = new System.Drawing.Point(1003, 539);
            this.btn_ToMainScreen.Name = "btn_ToMainScreen";
            this.btn_ToMainScreen.Size = new System.Drawing.Size(189, 95);
            this.btn_ToMainScreen.TabIndex = 1;
            this.btn_ToMainScreen.Text = "Выйти в главное меню";
            this.btn_ToMainScreen.UseVisualStyleBackColor = false;
            this.btn_ToMainScreen.Click += new System.EventHandler(this.btn_ToMainScreen_Click);
            // 
            // lb_Answer
            // 
            this.lb_Answer.AutoSize = true;
            this.lb_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_Answer.Location = new System.Drawing.Point(689, 351);
            this.lb_Answer.Name = "lb_Answer";
            this.lb_Answer.Size = new System.Drawing.Size(64, 25);
            this.lb_Answer.TabIndex = 2;
            this.lb_Answer.Text = "label1";
            // 
            // RomeNotationAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1204, 646);
            this.Controls.Add(this.lb_Answer);
            this.Controls.Add(this.btn_ToMainScreen);
            this.Controls.Add(this.lb_ExplanationOfRoman);
            this.Name = "RomeNotationAnswer";
            this.Text = "Объяснение перевода и ответ";
            this.Load += new System.EventHandler(this.RomeNotationAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ExplanationOfRoman;
        private System.Windows.Forms.Button btn_ToMainScreen;
        private System.Windows.Forms.Label lb_Answer;
    }
}