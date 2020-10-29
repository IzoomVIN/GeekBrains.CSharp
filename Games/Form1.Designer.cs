namespace Games
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
            this.expectView = new System.Windows.Forms.Label();
            this.numberView = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.buttonBox = new System.Windows.Forms.GroupBox();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.countText = new System.Windows.Forms.Label();
            this.countView = new System.Windows.Forms.Label();
            this.expectText = new System.Windows.Forms.Label();
            this.buttonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // expectView
            // 
            this.expectView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.expectView.Location = new System.Drawing.Point(10, 61);
            this.expectView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.expectView.Name = "expectView";
            this.expectView.Padding = new System.Windows.Forms.Padding(5);
            this.expectView.Size = new System.Drawing.Size(159, 82);
            this.expectView.TabIndex = 0;
            this.expectView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberView
            // 
            this.numberView.BackColor = System.Drawing.SystemColors.Control;
            this.numberView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberView.Location = new System.Drawing.Point(10, 153);
            this.numberView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.numberView.Name = "numberView";
            this.numberView.Padding = new System.Windows.Forms.Padding(5);
            this.numberView.Size = new System.Drawing.Size(280, 127);
            this.numberView.TabIndex = 1;
            this.numberView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.Location = new System.Drawing.Point(9, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 57);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+1";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // buttonBox
            // 
            this.buttonBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBox.Controls.Add(this.btnMult);
            this.buttonBox.Controls.Add(this.btnBack);
            this.buttonBox.Controls.Add(this.btnReset);
            this.buttonBox.Controls.Add(this.btnAdd);
            this.buttonBox.Location = new System.Drawing.Point(303, 10);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(163, 270);
            this.buttonBox.TabIndex = 5;
            this.buttonBox.TabStop = false;
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMult.Location = new System.Drawing.Point(9, 79);
            this.btnMult.Margin = new System.Windows.Forms.Padding(5);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(146, 54);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "X2";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBack.Location = new System.Drawing.Point(9, 143);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 54);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReset.Location = new System.Drawing.Point(9, 207);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 55);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // countText
            // 
            this.countText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.countText.Location = new System.Drawing.Point(171, 10);
            this.countText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.countText.Name = "countText";
            this.countText.Padding = new System.Windows.Forms.Padding(5);
            this.countText.Size = new System.Drawing.Size(119, 50);
            this.countText.TabIndex = 6;
            this.countText.Text = "count";
            this.countText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countView
            // 
            this.countView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.countView.Location = new System.Drawing.Point(171, 61);
            this.countView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.countView.Name = "countView";
            this.countView.Padding = new System.Windows.Forms.Padding(5);
            this.countView.Size = new System.Drawing.Size(119, 82);
            this.countView.TabIndex = 7;
            this.countView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expectText
            // 
            this.expectText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.expectText.Location = new System.Drawing.Point(10, 10);
            this.expectText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.expectText.Name = "expectText";
            this.expectText.Padding = new System.Windows.Forms.Padding(5);
            this.expectText.Size = new System.Drawing.Size(159, 50);
            this.expectText.TabIndex = 8;
            this.expectText.Text = "expect";
            this.expectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 292);
            this.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.expectText);
            this.Controls.Add(this.countView);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.numberView);
            this.Controls.Add(this.expectView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.buttonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label expectView;
        private System.Windows.Forms.Label expectText;
        private System.Windows.Forms.Label numberView;
        private System.Windows.Forms.Label countText;
        private System.Windows.Forms.Label countView;
        private System.Windows.Forms.GroupBox buttonBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
    }
}

