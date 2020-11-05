namespace Games
{
    partial class SayNumber
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
            this.WriteBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WriteBox
            // 
            this.WriteBox.Location = new System.Drawing.Point(12, 12);
            this.WriteBox.MaxLength = 10;
            this.WriteBox.Name = "WriteBox";
            this.WriteBox.Size = new System.Drawing.Size(264, 22);
            this.WriteBox.TabIndex = 0;
            this.WriteBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(80, 75);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(60, 30);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(150, 75);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(60, 30);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "back";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SayNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.WriteBox);
            this.Name = "SayNumber";
            this.Text = "SayNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WriteBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}