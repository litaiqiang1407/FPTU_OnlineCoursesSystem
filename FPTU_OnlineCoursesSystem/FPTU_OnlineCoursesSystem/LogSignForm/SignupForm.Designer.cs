namespace FPTU_OnlineCoursesSystem
{
    partial class SignupForm
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
            btnSignup = new Button();
            labelEmailRequired = new Label();
            labelNameRequired = new Label();
            inputEmail = new TextBox();
            labelEmail = new Label();
            label4 = new Label();
            inputName = new TextBox();
            labelName = new Label();
            panelAccountCreation = new Panel();
            labelBirthdate = new Label();
            labelPhoneNumber = new Label();
            inputBirthdate = new TextBox();
            inputOther = new RadioButton();
            inputFemale = new RadioButton();
            inputMale = new RadioButton();
            label10 = new Label();
            label8 = new Label();
            inputPhoneNumber = new TextBox();
            labelp = new Label();
            label7 = new Label();
            labelPasswordRequired = new Label();
            inputPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label9 = new Label();
            panelAccountCreation.SuspendLayout();
            SuspendLayout();
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
            btnSignup.Location = new Point(60, 480);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(360, 50);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // labelEmailRequired
            // 
            labelEmailRequired.AutoSize = true;
            labelEmailRequired.ForeColor = Color.Red;
            labelEmailRequired.Location = new Point(60, 152);
            labelEmailRequired.Name = "labelEmailRequired";
            labelEmailRequired.Size = new Size(139, 20);
            labelEmailRequired.TabIndex = 8;
            labelEmailRequired.Text = "labelEmailRequired";
            labelEmailRequired.Visible = false;
            // 
            // labelNameRequired
            // 
            labelNameRequired.AutoSize = true;
            labelNameRequired.ForeColor = Color.Red;
            labelNameRequired.Location = new Point(60, 72);
            labelNameRequired.Name = "labelNameRequired";
            labelNameRequired.Size = new Size(142, 20);
            labelNameRequired.TabIndex = 7;
            labelNameRequired.Text = "labelNameRequired";
            labelNameRequired.Visible = false;
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputEmail.Location = new Point(61, 121);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Enter your email address....";
            inputEmail.Size = new Size(358, 30);
            inputEmail.TabIndex = 1;
            inputEmail.KeyDown += inputEmail_KeyDown;
            // 
            // labelEmail
            // 
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(255, 109, 0);
            labelEmail.Location = new Point(60, 90);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(120, 30);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            labelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 109, 0);
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.FromArgb(255, 109, 0);
            label4.Location = new Point(60, 120);
            label4.Name = "label4";
            label4.Size = new Size(360, 32);
            label4.TabIndex = 6;
            // 
            // inputName
            // 
            inputName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputName.Location = new Point(61, 41);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Enter your full name....";
            inputName.Size = new Size(358, 30);
            inputName.TabIndex = 0;
            inputName.KeyDown += inputName_KeyDown;
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelName.ForeColor = Color.FromArgb(255, 109, 0);
            labelName.Location = new Point(60, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(120, 30);
            labelName.TabIndex = 1;
            labelName.Text = "Full Name";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelAccountCreation
            // 
            panelAccountCreation.Controls.Add(labelBirthdate);
            panelAccountCreation.Controls.Add(labelPhoneNumber);
            panelAccountCreation.Controls.Add(inputBirthdate);
            panelAccountCreation.Controls.Add(inputOther);
            panelAccountCreation.Controls.Add(inputFemale);
            panelAccountCreation.Controls.Add(inputMale);
            panelAccountCreation.Controls.Add(label10);
            panelAccountCreation.Controls.Add(label8);
            panelAccountCreation.Controls.Add(inputPhoneNumber);
            panelAccountCreation.Controls.Add(labelp);
            panelAccountCreation.Controls.Add(label7);
            panelAccountCreation.Controls.Add(labelPasswordRequired);
            panelAccountCreation.Controls.Add(inputPassword);
            panelAccountCreation.Controls.Add(label5);
            panelAccountCreation.Controls.Add(label6);
            panelAccountCreation.Controls.Add(btnSignup);
            panelAccountCreation.Controls.Add(labelEmailRequired);
            panelAccountCreation.Controls.Add(labelNameRequired);
            panelAccountCreation.Controls.Add(inputEmail);
            panelAccountCreation.Controls.Add(labelEmail);
            panelAccountCreation.Controls.Add(label4);
            panelAccountCreation.Controls.Add(inputName);
            panelAccountCreation.Controls.Add(labelName);
            panelAccountCreation.Controls.Add(label2);
            panelAccountCreation.Controls.Add(label9);
            panelAccountCreation.Dock = DockStyle.Fill;
            panelAccountCreation.Location = new Point(0, 0);
            panelAccountCreation.Name = "panelAccountCreation";
            panelAccountCreation.Size = new Size(480, 580);
            panelAccountCreation.TabIndex = 2;
            // 
            // labelBirthdate
            // 
            labelBirthdate.AutoSize = true;
            labelBirthdate.ForeColor = Color.Red;
            labelBirthdate.Location = new Point(60, 392);
            labelBirthdate.Name = "labelBirthdate";
            labelBirthdate.Size = new Size(103, 20);
            labelBirthdate.TabIndex = 30;
            labelBirthdate.Text = "labelBirthdate";
            labelBirthdate.Visible = false;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.ForeColor = Color.Red;
            labelPhoneNumber.Location = new Point(60, 312);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(137, 20);
            labelPhoneNumber.TabIndex = 29;
            labelPhoneNumber.Text = "labelPhoneNumber";
            labelPhoneNumber.Visible = false;
            // 
            // inputBirthdate
            // 
            inputBirthdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputBirthdate.Location = new Point(61, 361);
            inputBirthdate.Name = "inputBirthdate";
            inputBirthdate.PlaceholderText = "dd/mm/yyyy";
            inputBirthdate.Size = new Size(358, 30);
            inputBirthdate.TabIndex = 4;
            inputBirthdate.KeyDown += inputBirthdate_KeyDown;
            // 
            // inputOther
            // 
            inputOther.AutoSize = true;
            inputOther.FlatAppearance.BorderSize = 2;
            inputOther.FlatStyle = FlatStyle.Flat;
            inputOther.ForeColor = Color.FromArgb(255, 109, 0);
            inputOther.Location = new Point(353, 440);
            inputOther.Name = "inputOther";
            inputOther.Size = new Size(66, 24);
            inputOther.TabIndex = 27;
            inputOther.TabStop = true;
            inputOther.Text = "Other";
            inputOther.UseVisualStyleBackColor = true;
            // 
            // inputFemale
            // 
            inputFemale.AutoSize = true;
            inputFemale.FlatAppearance.BorderSize = 2;
            inputFemale.FlatStyle = FlatStyle.Flat;
            inputFemale.ForeColor = Color.FromArgb(255, 109, 0);
            inputFemale.Location = new Point(199, 440);
            inputFemale.Name = "inputFemale";
            inputFemale.Size = new Size(77, 24);
            inputFemale.TabIndex = 26;
            inputFemale.TabStop = true;
            inputFemale.Text = "Female";
            inputFemale.UseVisualStyleBackColor = true;
            // 
            // inputMale
            // 
            inputMale.AutoSize = true;
            inputMale.FlatAppearance.BorderSize = 2;
            inputMale.FlatStyle = FlatStyle.Flat;
            inputMale.ForeColor = Color.FromArgb(255, 109, 0);
            inputMale.Location = new Point(60, 440);
            inputMale.Name = "inputMale";
            inputMale.Size = new Size(62, 24);
            inputMale.TabIndex = 25;
            inputMale.TabStop = true;
            inputMale.Text = "Male";
            inputMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(255, 109, 0);
            label10.Location = new Point(60, 410);
            label10.Name = "label10";
            label10.Size = new Size(120, 30);
            label10.TabIndex = 24;
            label10.Text = "Gender";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(255, 109, 0);
            label8.Location = new Point(60, 330);
            label8.Name = "label8";
            label8.Size = new Size(120, 30);
            label8.TabIndex = 22;
            label8.Text = "Birthdate";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputPhoneNumber
            // 
            inputPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputPhoneNumber.Location = new Point(61, 281);
            inputPhoneNumber.Name = "inputPhoneNumber";
            inputPhoneNumber.PlaceholderText = "Enter your phone number....";
            inputPhoneNumber.Size = new Size(358, 30);
            inputPhoneNumber.TabIndex = 3;
            inputPhoneNumber.KeyDown += inputPhoneNumber_KeyDown;
            // 
            // labelp
            // 
            labelp.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelp.ForeColor = Color.FromArgb(255, 109, 0);
            labelp.Location = new Point(60, 250);
            labelp.Name = "labelp";
            labelp.Size = new Size(163, 30);
            labelp.TabIndex = 18;
            labelp.Text = "Phone Number";
            labelp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(255, 109, 0);
            label7.FlatStyle = FlatStyle.Flat;
            label7.ForeColor = Color.FromArgb(255, 109, 0);
            label7.Location = new Point(60, 280);
            label7.Name = "label7";
            label7.Size = new Size(360, 32);
            label7.TabIndex = 20;
            // 
            // labelPasswordRequired
            // 
            labelPasswordRequired.AutoSize = true;
            labelPasswordRequired.ForeColor = Color.Red;
            labelPasswordRequired.Location = new Point(60, 232);
            labelPasswordRequired.Name = "labelPasswordRequired";
            labelPasswordRequired.Size = new Size(163, 20);
            labelPasswordRequired.TabIndex = 17;
            labelPasswordRequired.Text = "labelPasswordRequired";
            labelPasswordRequired.Visible = false;
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.Location = new Point(61, 201);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '•';
            inputPassword.PlaceholderText = "Enter your password....";
            inputPassword.Size = new Size(358, 30);
            inputPassword.TabIndex = 2;
            inputPassword.KeyDown += inputPassword_KeyDown;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 109, 0);
            label5.Location = new Point(60, 170);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 14;
            label5.Text = "Password";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(255, 109, 0);
            label6.FlatStyle = FlatStyle.Flat;
            label6.ForeColor = Color.FromArgb(255, 109, 0);
            label6.Location = new Point(60, 200);
            label6.Name = "label6";
            label6.Size = new Size(360, 32);
            label6.TabIndex = 16;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 109, 0);
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.FromArgb(255, 109, 0);
            label2.Location = new Point(60, 40);
            label2.Name = "label2";
            label2.Size = new Size(360, 32);
            label2.TabIndex = 3;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(255, 109, 0);
            label9.FlatStyle = FlatStyle.Flat;
            label9.ForeColor = Color.FromArgb(255, 109, 0);
            label9.Location = new Point(60, 360);
            label9.Name = "label9";
            label9.Size = new Size(360, 32);
            label9.TabIndex = 23;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 580);
            Controls.Add(panelAccountCreation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupFrom";
            panelAccountCreation.ResumeLayout(false);
            panelAccountCreation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSignup;
        private Label labelEmailRequired;
        private Label labelNameRequired;
        private TextBox inputEmail;
        private Label labelEmail;
        private Label label4;
        private TextBox inputName;
        private Label labelName;
        private Panel panelAccountCreation;
        private Label label2;
        private Label labelPasswordRequired;
        private TextBox inputPassword;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox inputPhoneNumber;
        private Label labelp;
        private Label label7;
        private Label label9;
        private RadioButton inputMale;
        private Label label10;
        private RadioButton inputOther;
        private RadioButton inputFemale;
        private TextBox inputBirthdate;
        private Label labelBirthdate;
        private Label labelPhoneNumber;
    }
}