namespace X_Plore.Forms
{
    partial class LoginForm
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
            this.UserBox = new System.Windows.Forms.TextBox();
            this.showPassBox = new System.Windows.Forms.CheckBox();
            this.BackToRegisterBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.forgotPassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(251, 56);
            this.UserBox.MaxLength = 30;
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(172, 26);
            this.UserBox.TabIndex = 1;
            // 
            // showPassBox
            // 
            this.showPassBox.AutoSize = true;
            this.showPassBox.Location = new System.Drawing.Point(443, 99);
            this.showPassBox.Name = "showPassBox";
            this.showPassBox.Size = new System.Drawing.Size(75, 24);
            this.showPassBox.TabIndex = 2;
            this.showPassBox.Text = "Show";
            this.showPassBox.UseVisualStyleBackColor = true;
            // 
            // BackToRegisterBtn
            // 
            this.BackToRegisterBtn.Location = new System.Drawing.Point(235, 137);
            this.BackToRegisterBtn.Name = "BackToRegisterBtn";
            this.BackToRegisterBtn.Size = new System.Drawing.Size(103, 53);
            this.BackToRegisterBtn.TabIndex = 3;
            this.BackToRegisterBtn.Text = "Register";
            this.BackToRegisterBtn.UseVisualStyleBackColor = true;
            this.BackToRegisterBtn.Click += new System.EventHandler(this.BackToRegisterBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(251, 97);
            this.PassBox.MaxLength = 30;
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(172, 26);
            this.PassBox.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(344, 137);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(93, 53);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // forgotPassBtn
            // 
            this.forgotPassBtn.Location = new System.Drawing.Point(235, 196);
            this.forgotPassBtn.Name = "forgotPassBtn";
            this.forgotPassBtn.Size = new System.Drawing.Size(202, 37);
            this.forgotPassBtn.TabIndex = 3;
            this.forgotPassBtn.Text = "Forgot your Password!";
            this.forgotPassBtn.UseVisualStyleBackColor = true;
            this.forgotPassBtn.Click += new System.EventHandler(this.forgotPassBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.forgotPassBtn);
            this.Controls.Add(this.BackToRegisterBtn);
            this.Controls.Add(this.showPassBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.CheckBox showPassBox;
        private System.Windows.Forms.Button BackToRegisterBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button forgotPassBtn;
    }
}