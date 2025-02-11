namespace RestaurantSalaries.Forms
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
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(115, 399);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(172, 49);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(55, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(294, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(56, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(56, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(56, 292);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(293, 31);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 27);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 5;
            label1.Text = "Потребителско име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 108);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 6;
            label2.Text = "Имейл";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 181);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 7;
            label3.Text = "Парола";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 264);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 8;
            label4.Text = "Потвърди паролата";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(56, 342);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 9;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(404, 472);
            Controls.Add(lblError);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblError;
    }
}