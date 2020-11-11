using System.Reflection;

namespace HomeworkLast
{
    partial class HW8
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
            this.textLab = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textLab
            // 
            this.textLab.Location = new System.Drawing.Point(12, 9);
            this.textLab.Name = "textLab";
            this.textLab.Size = new System.Drawing.Size(100, 23);
            this.textLab.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 39);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 22);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.UpdateTextEvent);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 80);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.UpdateValueEvent);
            // 
            // HW8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 112);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textLab);
            this.Name = "HW8";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLab;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

