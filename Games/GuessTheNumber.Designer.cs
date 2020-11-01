namespace Games
{
    partial class GuessTheNumber
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
            this.NameText = new System.Windows.Forms.Label();
            this.NumberView = new System.Windows.Forms.Label();
            this.CountView = new System.Windows.Forms.Label();
            this.SayButton = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.Location = new System.Drawing.Point(15, 15);
            this.NameText.Margin = new System.Windows.Forms.Padding(6);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(755, 78);
            this.NameText.TabIndex = 0;
            this.NameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberView
            // 
            this.NumberView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberView.Location = new System.Drawing.Point(15, 236);
            this.NumberView.Margin = new System.Windows.Forms.Padding(6);
            this.NumberView.Name = "NumberView";
            this.NumberView.Size = new System.Drawing.Size(755, 209);
            this.NumberView.TabIndex = 1;
            this.NumberView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountView
            // 
            this.CountView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountView.Location = new System.Drawing.Point(400, 105);
            this.CountView.Margin = new System.Windows.Forms.Padding(6);
            this.CountView.Name = "CountView";
            this.CountView.Size = new System.Drawing.Size(370, 119);
            this.CountView.TabIndex = 2;
            this.CountView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SayButton
            // 
            this.SayButton.Location = new System.Drawing.Point(279, 481);
            this.SayButton.Margin = new System.Windows.Forms.Padding(6, 30, 6, 30);
            this.SayButton.Name = "SayButton";
            this.SayButton.Size = new System.Drawing.Size(237, 58);
            this.SayButton.TabIndex = 3;
            this.SayButton.Text = "say number";
            this.SayButton.UseVisualStyleBackColor = true;
            this.SayButton.Click += new System.EventHandler(this.SayButton_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(635, 514);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(6, 30, 6, 30);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(135, 58);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // GuessTheNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 578);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SayButton);
            this.Controls.Add(this.CountView);
            this.Controls.Add(this.NumberView);
            this.Controls.Add(this.NameText);
            this.Name = "GuessTheNumber";
            this.Text = "GuessTheNumber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label NumberView;
        private System.Windows.Forms.Label CountView;
        private System.Windows.Forms.Button SayButton;
        private System.Windows.Forms.Button ExitBtn;
    }
}