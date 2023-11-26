namespace FPTU_OnlineCoursesSystem
{
    partial class ForgotPasswordForm
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
            panelForgotPassword = new Panel();
            btnLogin = new Button();
            labelEmailRequired = new Label();
            inputEmail = new TextBox();
            labelEmail = new Label();
            labelWelcomeBack = new Label();
            label2 = new Label();
            panelForgotPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelForgotPassword
            // 
            panelForgotPassword.BackColor = Color.White;
            panelForgotPassword.Controls.Add(btnLogin);
            panelForgotPassword.Controls.Add(labelEmailRequired);
            panelForgotPassword.Controls.Add(inputEmail);
            panelForgotPassword.Controls.Add(labelEmail);
            panelForgotPassword.Controls.Add(labelWelcomeBack);
            panelForgotPassword.Controls.Add(label2);
            panelForgotPassword.Dock = DockStyle.Fill;
            panelForgotPassword.Location = new Point(0, 0);
            panelForgotPassword.Name = "panelForgotPassword";
            panelForgotPassword.Size = new Size(480, 580);
            panelForgotPassword.TabIndex = 1;
            panelForgotPassword.Paint += panelForgotPassword_Paint;
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
            btnLogin.Text = "Reset Password";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // labelEmailRequired
            // 
            labelEmailRequired.AutoSize = true;
            labelEmailRequired.ForeColor = Color.Red;
            labelEmailRequired.Location = new Point(60, 272);
            labelEmailRequired.Name = "labelEmailRequired";
            labelEmailRequired.Size = new Size(139, 20);
            labelEmailRequired.TabIndex = 7;
            labelEmailRequired.Text = "labelEmailRequired";
            labelEmailRequired.Visible = false;
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputEmail.Location = new Point(61, 241);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Enter your email....";
            inputEmail.Size = new Size(358, 30);
            inputEmail.TabIndex = 0;
            // 
            // labelEmail
            // 
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(255, 109, 0);
            labelEmail.Location = new Point(60, 210);
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
            labelWelcomeBack.Location = new Point(0, 100);
            labelWelcomeBack.Name = "labelWelcomeBack";
            labelWelcomeBack.Size = new Size(480, 100);
            labelWelcomeBack.TabIndex = 0;
            labelWelcomeBack.Text = "Reset Password";
            labelWelcomeBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 109, 0);
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.FromArgb(255, 109, 0);
            label2.Location = new Point(60, 240);
            label2.Name = "label2";
            label2.Size = new Size(360, 32);
            label2.TabIndex = 3;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 580);
            Controls.Add(panelForgotPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            panelForgotPassword.ResumeLayout(false);
            panelForgotPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForgotPassword;
        private Button btnLogin;
        private Label labelEmailRequired;
        private TextBox inputEmail;
        private Label labelEmail;
        private Label labelWelcomeBack;
        private Label label2;
    }
}