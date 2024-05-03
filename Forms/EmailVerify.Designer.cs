namespace X_Plore.Forms
{
    partial class EmailVerify
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
            this.NotifcationTxT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NotifcationTxT
            // 
            this.NotifcationTxT.AutoSize = true;
            this.NotifcationTxT.Location = new System.Drawing.Point(265, 84);
            this.NotifcationTxT.Name = "NotifcationTxT";
            this.NotifcationTxT.Size = new System.Drawing.Size(85, 20);
            this.NotifcationTxT.TabIndex = 0;
            this.NotifcationTxT.Text = "Thông báo";
            this.NotifcationTxT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Verification Code";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(187, 184);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(107, 61);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Enabled = false;
            this.confirmBtn.Location = new System.Drawing.Point(330, 184);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(105, 61);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "&Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(187, 123);
            this.codeBox.MaxLength = 4;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(248, 26);
            this.codeBox.TabIndex = 2;
            // 
            // EmailVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NotifcationTxT);
            this.Name = "EmailVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailVerify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmailVerify_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotifcationTxT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox codeBox;
    }
}