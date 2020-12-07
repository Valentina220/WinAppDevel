namespace ITMO.Course124.Exercise4._4
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
            this.buttonF1 = new System.Windows.Forms.Button();
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonF1
            // 
            this.buttonF1.Location = new System.Drawing.Point(21, 30);
            this.buttonF1.Name = "buttonF1";
            this.buttonF1.Size = new System.Drawing.Size(177, 40);
            this.buttonF1.TabIndex = 0;
            this.buttonF1.Text = "ВВОД";
            this.buttonF1.UseVisualStyleBackColor = true;
            this.buttonF1.Click += new System.EventHandler(this.buttonF1_Click);
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(21, 94);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(177, 20);
            this.textBoxF1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 159);
            this.Controls.Add(this.textBoxF1);
            this.Controls.Add(this.buttonF1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonF1;
        private System.Windows.Forms.TextBox textBoxF1;
    }
}

