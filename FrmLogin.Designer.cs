namespace ProjectPRN
{
    partial class FrmLogin
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
            txtPassword = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lbUsername = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(326, 186);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(199, 23);
            txtPassword.TabIndex = 10;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(252, 186);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 9;
            lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(326, 149);
            txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(199, 23);
            txtUsername.TabIndex = 8;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new System.Drawing.Point(252, 152);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(60, 15);
            lbUsername.TabIndex = 7;
            lbUsername.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(443, 244);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(82, 22);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbUsername);
            Controls.Add(btnLogin);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnLogin;
    }
}