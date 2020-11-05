namespace Games
{
    partial class Multiplier
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
            this.expectView.Location = new System.Drawing.Point(24, 122);
            this.expectView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.expectView.Name = "expectView";
            this.expectView.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.expectView.Size = new System.Drawing.Size(378, 164);
            this.expectView.TabIndex = 0;
            this.expectView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberView
            // 
            this.numberView.BackColor = System.Drawing.SystemColors.Control;
            this.numberView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberView.Location = new System.Drawing.Point(24, 306);
            this.numberView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.numberView.Name = "numberView";
            this.numberView.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.numberView.Size = new System.Drawing.Size(662, 252);
            this.numberView.TabIndex = 1;
            this.numberView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.Location = new System.Drawing.Point(21, 24);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(347, 114);
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
            this.buttonBox.Location = new System.Drawing.Point(720, 20);
            this.buttonBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonBox.Size = new System.Drawing.Size(387, 540);
            this.buttonBox.TabIndex = 5;
            this.buttonBox.TabStop = false;
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMult.Location = new System.Drawing.Point(21, 158);
            this.btnMult.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(347, 108);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "X2";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBack.Location = new System.Drawing.Point(21, 286);
            this.btnBack.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(347, 108);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReset.Location = new System.Drawing.Point(21, 414);
            this.btnReset.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(347, 110);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // countText
            // 
            this.countText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.countText.Location = new System.Drawing.Point(406, 20);
            this.countText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.countText.Name = "countText";
            this.countText.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.countText.Size = new System.Drawing.Size(283, 100);
            this.countText.TabIndex = 6;
            this.countText.Text = "count";
            this.countText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countView
            // 
            this.countView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.countView.Location = new System.Drawing.Point(406, 122);
            this.countView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.countView.Name = "countView";
            this.countView.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.countView.Size = new System.Drawing.Size(283, 164);
            this.countView.TabIndex = 7;
            this.countView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expectText
            // 
            this.expectText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.expectText.Location = new System.Drawing.Point(24, 20);
            this.expectText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.expectText.Name = "expectText";
            this.expectText.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.expectText.Size = new System.Drawing.Size(378, 100);
            this.expectText.TabIndex = 8;
            this.expectText.Text = "expect";
            this.expectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Multiplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expectText);
            this.Controls.Add(this.countView);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.numberView);
            this.Controls.Add(this.expectView);
            this.Name = "Multiplier";
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

