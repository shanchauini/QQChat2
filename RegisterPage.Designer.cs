namespace QQChat
{
    partial class RegisterPage
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
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.lblRegConfirmPassword = new System.Windows.Forms.Label();
            this.txtRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblRegGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.llblBackToLogin = new System.Windows.Forms.LinkLabel();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.Location = new System.Drawing.Point(400, 92);
            this.lblRegUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(94, 24);
            this.lblRegUsername.TabIndex = 0;
            this.lblRegUsername.Text = "用户名:";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(560, 86);
            this.txtRegUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(396, 35);
            this.txtRegUsername.TabIndex = 1;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(400, 166);
            this.lblRegPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(70, 24);
            this.lblRegPassword.TabIndex = 2;
            this.lblRegPassword.Text = "密码:";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(560, 160);
            this.txtRegPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(396, 35);
            this.txtRegPassword.TabIndex = 3;
            // 
            // lblRegConfirmPassword
            // 
            this.lblRegConfirmPassword.AutoSize = true;
            this.lblRegConfirmPassword.Location = new System.Drawing.Point(400, 240);
            this.lblRegConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegConfirmPassword.Name = "lblRegConfirmPassword";
            this.lblRegConfirmPassword.Size = new System.Drawing.Size(118, 24);
            this.lblRegConfirmPassword.TabIndex = 4;
            this.lblRegConfirmPassword.Text = "确认密码:";
            // 
            // txtRegConfirmPassword
            // 
            this.txtRegConfirmPassword.Location = new System.Drawing.Point(560, 234);
            this.txtRegConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRegConfirmPassword.Name = "txtRegConfirmPassword";
            this.txtRegConfirmPassword.PasswordChar = '*';
            this.txtRegConfirmPassword.Size = new System.Drawing.Size(396, 35);
            this.txtRegConfirmPassword.TabIndex = 5;
            // 
            // lblRegGender
            // 
            this.lblRegGender.AutoSize = true;
            this.lblRegGender.Location = new System.Drawing.Point(400, 314);
            this.lblRegGender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegGender.Name = "lblRegGender";
            this.lblRegGender.Size = new System.Drawing.Size(70, 24);
            this.lblRegGender.TabIndex = 6;
            this.lblRegGender.Text = "性别:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(20, 22);
            this.rbMale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(65, 28);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(160, 22);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(65, 28);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Location = new System.Drawing.Point(400, 388);
            this.lblRegEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(70, 24);
            this.lblRegEmail.TabIndex = 8;
            this.lblRegEmail.Text = "邮箱:";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(560, 382);
            this.txtRegEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(396, 35);
            this.txtRegEmail.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Location = new System.Drawing.Point(560, 462);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 42);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // llblBackToLogin
            // 
            this.llblBackToLogin.AutoSize = true;
            this.llblBackToLogin.LinkColor = System.Drawing.Color.Black;
            this.llblBackToLogin.Location = new System.Drawing.Point(760, 470);
            this.llblBackToLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llblBackToLogin.Name = "llblBackToLogin";
            this.llblBackToLogin.Size = new System.Drawing.Size(226, 24);
            this.llblBackToLogin.TabIndex = 11;
            this.llblBackToLogin.TabStop = true;
            this.llblBackToLogin.Text = "已有账号? 返回登录";
            this.llblBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBackToLogin_LinkClicked);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.rbMale);
            this.groupBoxGender.Controls.Add(this.rbFemale);
            this.groupBoxGender.Location = new System.Drawing.Point(560, 286);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxGender.Size = new System.Drawing.Size(400, 74);
            this.groupBoxGender.TabIndex = 7;
            this.groupBoxGender.TabStop = false;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 830);
            this.Controls.Add(this.llblBackToLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.lblRegEmail);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.lblRegGender);
            this.Controls.Add(this.txtRegConfirmPassword);
            this.Controls.Add(this.lblRegConfirmPassword);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.lblRegUsername);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册新用户";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label lblRegConfirmPassword;
        private System.Windows.Forms.TextBox txtRegConfirmPassword;
        private System.Windows.Forms.Label lblRegGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel llblBackToLogin;
        private System.Windows.Forms.GroupBox groupBoxGender;
    }
} 