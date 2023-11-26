namespace FPTU_OnlineCoursesSystem
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
            panelAdminLogin = new Panel();
            labelForgotPassword = new Label();
            cbxRememberMe = new CheckBox();
            label5 = new Label();
            button1 = new Button();
            btnSignup = new Button();
            btnLogin = new Button();
            labelPassword = new Label();
            labelEmailRequired = new Label();
            inputPassword = new TextBox();
            label333 = new Label();
            label4 = new Label();
            inputEmail = new TextBox();
            labelEmail = new Label();
            labelWelcomeBack = new Label();
            label2 = new Label();
            panelAdminLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdminLogin
            // 
            panelAdminLogin.Controls.Add(labelForgotPassword);
            panelAdminLogin.Controls.Add(cbxRememberMe);
            panelAdminLogin.Controls.Add(label5);
            panelAdminLogin.Controls.Add(button1);
            panelAdminLogin.Controls.Add(btnSignup);
            panelAdminLogin.Controls.Add(btnLogin);
            panelAdminLogin.Controls.Add(labelPassword);
            panelAdminLogin.Controls.Add(labelEmailRequired);
            panelAdminLogin.Controls.Add(inputPassword);
            panelAdminLogin.Controls.Add(label333);
            panelAdminLogin.Controls.Add(label4);
            panelAdminLogin.Controls.Add(inputEmail);
            panelAdminLogin.Controls.Add(labelEmail);
            panelAdminLogin.Controls.Add(labelWelcomeBack);
            panelAdminLogin.Controls.Add(label2);
            panelAdminLogin.Dock = DockStyle.Fill;
            panelAdminLogin.Location = new Point(0, 0);
            panelAdminLogin.Name = "panelAdminLogin";
            panelAdminLogin.Size = new Size(480, 580);
            panelAdminLogin.TabIndex = 0;
            // 
            // labelForgotPassword
            // 
            labelForgotPassword.AutoSize = true;
            labelForgotPassword.ForeColor = Color.Red;
            labelForgotPassword.Location = new Point(293, 284);
            labelForgotPassword.Name = "labelForgotPassword";
            labelForgotPassword.Size = new Size(127, 20);
            labelForgotPassword.TabIndex = 14;
            labelForgotPassword.Text = "Forgot password?";
            labelForgotPassword.Click += labelForgotPassword_Click;
            // 
            // cbxRememberMe
            // 
            cbxRememberMe.AutoSize = true;
            cbxRememberMe.ForeColor = Color.FromArgb(255, 109, 0);
            cbxRememberMe.Location = new Point(60, 284);
            cbxRememberMe.Name = "cbxRememberMe";
            cbxRememberMe.Size = new Size(133, 24);
            cbxRememberMe.TabIndex = 13;
            cbxRememberMe.Text = "Remember me!";
            cbxRememberMe.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 109, 0);
            label5.Location = new Point(141, 395);
            label5.Name = "label5";
            label5.Size = new Size(199, 20);
            label5.TabIndex = 11;
            label5.Text = "You do not have an account?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Chocolate;
            button1.Location = new Point(60, 404);
            button1.Name = "button1";
            button1.Size = new Size(360, 2);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(255, 109, 0);
            btnSignup.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnSignup.FlatAppearance.BorderSize = 2;
            btnSignup.FlatAppearance.MouseDownBackColor = Color.White;
            btnSignup.FlatAppearance.MouseOverBackColor = Color.White;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(60, 425);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(360, 50);
            btnSignup.TabIndex = 10;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 109, 0);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 50);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = Color.Red;
            labelPassword.Location = new Point(60, 284);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(103, 20);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "labelPassword";
            // 
            // labelEmailRequired
            // 
            labelEmailRequired.AutoSize = true;
            labelEmailRequired.ForeColor = Color.Red;
            labelEmailRequired.Location = new Point(60, 194);
            labelEmailRequired.Name = "labelEmailRequired";
            labelEmailRequired.Size = new Size(139, 20);
            labelEmailRequired.TabIndex = 7;
            labelEmailRequired.Text = "labelEmailRequired";
            labelEmailRequired.Visible = false;
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.Location = new Point(61, 251);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '•';
            inputPassword.PlaceholderText = "Enter your password....";
            inputPassword.Size = new Size(358, 30);
            inputPassword.TabIndex = 5;
            inputPassword.KeyDown += inputPassword_KeyDown;
            // 
            // label333
            // 
            label333.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label333.ForeColor = Color.FromArgb(255, 109, 0);
            label333.Location = new Point(60, 220);
            label333.Name = "label333";
            label333.Size = new Size(120, 30);
            label333.TabIndex = 4;
            label333.Text = "Password";
            label333.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 109, 0);
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.FromArgb(255, 109, 0);
            label4.Location = new Point(60, 250);
            label4.Name = "label4";
            label4.Size = new Size(360, 32);
            label4.TabIndex = 6;
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputEmail.Location = new Point(61, 161);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Enter your email....";
            inputEmail.Size = new Size(358, 30);
            inputEmail.TabIndex = 0;
            inputEmail.KeyDown += inputEmail_KeyDown;
            // 
            // labelEmail
            // 
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(255, 109, 0);
            labelEmail.Location = new Point(60, 130);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(65, 30);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            labelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWelcomeBack
            // 
            labelWelcomeBack.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcomeBack.ForeColor = Color.FromArgb(255, 109, 0);
            labelWelcomeBack.Location = new Point(0, 0);
            labelWelcomeBack.Name = "labelWelcomeBack";
            labelWelcomeBack.Size = new Size(480, 100);
            labelWelcomeBack.TabIndex = 0;
            labelWelcomeBack.Text = "Welcome Back!";
            labelWelcomeBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 109, 0);
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.FromArgb(255, 109, 0);
            label2.Location = new Point(60, 160);
            label2.Name = "label2";
            label2.Size = new Size(360, 32);
            label2.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 580);
            Controls.Add(panelAdminLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panelAdminLogin.ResumeLayout(false);
            panelAdminLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAdminLogin;
        private Label labelWelcomeBack;
        private TextBox inputEmail;
        private Label labelEmail;
        private Label label2;
        private TextBox inputPassword;
        private Label label333;
        private Label label4;
        private Label labelEmailRequired;
        private Label labelPassword;
        private Button btnSignup;
        private Button btnLogin;
        private Button button1;
        private Label label5;
        private CheckBox cbxRememberMe;
        private Label labelForgotPassword;
    }
}