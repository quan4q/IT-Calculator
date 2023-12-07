
namespace Calculator_5_klassnika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_ToRome = new System.Windows.Forms.Button();
            this.btn_ToSummation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите нужное действие";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(303, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Перевод в другую СС";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Location = new System.Drawing.Point(12, 390);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(90, 48);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_ToRome
            // 
            this.btn_ToRome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ToRome.Location = new System.Drawing.Point(303, 126);
            this.btn_ToRome.Name = "btn_ToRome";
            this.btn_ToRome.Size = new System.Drawing.Size(184, 58);
            this.btn_ToRome.TabIndex = 3;
            this.btn_ToRome.Text = "Перевод в римскую систему счисления";
            this.btn_ToRome.UseVisualStyleBackColor = false;
            this.btn_ToRome.Click += new System.EventHandler(this.btn_ToRome_Click);
            // 
            // btn_ToSummation
            // 
            this.btn_ToSummation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ToSummation.Location = new System.Drawing.Point(303, 190);
            this.btn_ToSummation.Name = "btn_ToSummation";
            this.btn_ToSummation.Size = new System.Drawing.Size(184, 58);
            this.btn_ToSummation.TabIndex = 4;
            this.btn_ToSummation.Text = "Сложение в произвольной СС";
            this.btn_ToSummation.UseVisualStyleBackColor = false;
            this.btn_ToSummation.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ToSummation);
            this.Controls.Add(this.btn_ToRome);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_ToRome;
        private System.Windows.Forms.Button btn_ToSummation;
    }
}

