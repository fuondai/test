namespace X_Plore.Forms
{
    partial class RegisterForm
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
            this.BackToLoginBtn = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.showPassBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReEnterPasswordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelBox = new System.Windows.Forms.TextBox();
            this.GenBox = new System.Windows.Forms.ComboBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // BackToLoginBtn
            // 
            this.BackToLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToLoginBtn.Location = new System.Drawing.Point(191, 318);
            this.BackToLoginBtn.Name = "BackToLoginBtn";
            this.BackToLoginBtn.Size = new System.Drawing.Size(106, 57);
            this.BackToLoginBtn.TabIndex = 1;
            this.BackToLoginBtn.Text = "Back to Login";
            this.BackToLoginBtn.UseVisualStyleBackColor = true;
            this.BackToLoginBtn.Click += new System.EventHandler(this.BackToLoginBtn_Click);
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(191, 58);
            this.UserBox.MaxLength = 30;
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(226, 26);
            this.UserBox.TabIndex = 2;
            // 
            // showPassBox
            // 
            this.showPassBox.AutoSize = true;
            this.showPassBox.Location = new System.Drawing.Point(432, 103);
            this.showPassBox.Name = "showPassBox";
            this.showPassBox.Size = new System.Drawing.Size(75, 24);
            this.showPassBox.TabIndex = 3;
            this.showPassBox.Text = "Show";
            this.showPassBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(191, 100);
            this.PassBox.MaxLength = 30;
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(226, 26);
            this.PassBox.TabIndex = 2;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Re-enter Password:";
            // 
            // ReEnterPasswordBox
            // 
            this.ReEnterPasswordBox.Location = new System.Drawing.Point(191, 141);
            this.ReEnterPasswordBox.MaxLength = 30;
            this.ReEnterPasswordBox.Name = "ReEnterPasswordBox";
            this.ReEnterPasswordBox.Size = new System.Drawing.Size(226, 26);
            this.ReEnterPasswordBox.TabIndex = 2;
            this.ReEnterPasswordBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gmail:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(191, 226);
            this.EmailBox.MaxLength = 100;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(226, 26);
            this.EmailBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone:";
            // 
            // TelBox
            // 
            this.TelBox.Location = new System.Drawing.Point(191, 270);
            this.TelBox.MaxLength = 30;
            this.TelBox.Name = "TelBox";
            this.TelBox.Size = new System.Drawing.Size(226, 26);
            this.TelBox.TabIndex = 2;
            // 
            // GenBox
            // 
            this.GenBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenBox.FormattingEnabled = true;
            this.GenBox.Location = new System.Drawing.Point(191, 183);
            this.GenBox.Name = "GenBox";
            this.GenBox.Size = new System.Drawing.Size(226, 28);
            this.GenBox.TabIndex = 4;
            // 
            // RegBtn
            // 
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Location = new System.Drawing.Point(303, 318);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(114, 57);
            this.RegBtn.TabIndex = 1;
            this.RegBtn.Text = "Register";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenBox);
            this.Controls.Add(this.showPassBox);
            this.Controls.Add(this.TelBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReEnterPasswordBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.BackToLoginBtn);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackToLoginBtn;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.CheckBox showPassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReEnterPasswordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TelBox;
        private System.Windows.Forms.ComboBox GenBox;
        private System.Windows.Forms.Button RegBtn;
    }
}