namespace RestaurantSalaries.Forms
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
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            Парола = new Label();
            lblError = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(66, 264);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(66, 74);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(66, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 31);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 42);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 3;
            label1.Text = "Имейл или потребителско име";
            // 
            // Парола
            // 
            Парола.AutoSize = true;
            Парола.Location = new Point(198, 132);
            Парола.Name = "Парола";
            Парола.Size = new Size(74, 25);
            Парола.TabIndex = 4;
            Парола.Text = "Парола";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(66, 208);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(281, 264);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 46);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(488, 331);
            Controls.Add(btnRegister);
            Controls.Add(lblError);
            Controls.Add(Парола);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label Парола;
        private Label lblError;
        private Button btnRegister;
    }
}