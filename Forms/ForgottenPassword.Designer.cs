namespace X_Plore.Forms
{
    partial class ForgottenPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.sendRecoveryBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.registerMailBox = new System.Windows.Forms.TextBox();
            this.recoveryCodeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your register Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter recovery code:";
            // 
            // sendRecoveryBtn
            // 
            this.sendRecoveryBtn.Location = new System.Drawing.Point(299, 134);
            this.sendRecoveryBtn.Name = "sendRecoveryBtn";
            this.sendRecoveryBtn.Size = new System.Drawing.Size(86, 34);
            this.sendRecoveryBtn.TabIndex = 1;
            this.sendRecoveryBtn.Text = "Send";
            this.sendRecoveryBtn.UseVisualStyleBackColor = true;
            this.sendRecoveryBtn.Click += new System.EventHandler(this.sendRecoveryBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Enabled = false;
            this.confirmBtn.Location = new System.Drawing.Point(407, 134);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(85, 34);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // registerMailBox
            // 
            this.registerMailBox.Location = new System.Drawing.Point(299, 57);
            this.registerMailBox.MaxLength = 100;
            this.registerMailBox.Name = "registerMailBox";
            this.registerMailBox.Size = new System.Drawing.Size(193, 26);
            this.registerMailBox.TabIndex = 2;
            // 
            // recoveryCodeBox
            // 
            this.recoveryCodeBox.Location = new System.Drawing.Point(299, 88);
            this.recoveryCodeBox.MaxLength = 4;
            this.recoveryCodeBox.Name = "recoveryCodeBox";
            this.recoveryCodeBox.Size = new System.Drawing.Size(193, 26);
            this.recoveryCodeBox.TabIndex = 2;
            // 
            // ForgottenPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recoveryCodeBox);
            this.Controls.Add(this.registerMailBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.sendRecoveryBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgottenPassword";
            this.Text = "ForgottenPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendRecoveryBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox registerMailBox;
        private System.Windows.Forms.TextBox recoveryCodeBox;
    }
}