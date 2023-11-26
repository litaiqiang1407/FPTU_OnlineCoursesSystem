namespace FPTU_OnlineCoursesSystem
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            panelTop = new Panel();
            btnClose = new Button();
            panelBottom = new Panel();
            labelCopyright = new Label();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelHorizontal = new Panel();
            labelWelcome = new Label();
            label1 = new Label();
            panelRoleSelection = new Panel();
            btnSignup = new Button();
            btnLogin = new Button();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRoleSelection.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(255, 72, 0);
            panelTop.Controls.Add(btnClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1380, 30);
            panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 72, 0);
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 84, 0);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 84, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1316, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(64, 24);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(255, 72, 0);
            panelBottom.Controls.Add(labelCopyright);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panelBottom.Location = new Point(0, 900);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1380, 30);
            panelBottom.TabIndex = 1;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCopyright.ForeColor = Color.White;
            labelCopyright.Location = new Point(634, 5);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(113, 20);
            labelCopyright.TabIndex = 0;
            labelCopyright.Text = "© CuongLT <3";
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 30);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1380, 150);
            panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(515, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelHorizontal
            // 
            panelHorizontal.BackColor = Color.FromArgb(255, 72, 0);
            panelHorizontal.Dock = DockStyle.Top;
            panelHorizontal.Location = new Point(0, 180);
            panelHorizontal.Name = "panelHorizontal";
            panelHorizontal.Size = new Size(1380, 4);
            panelHorizontal.TabIndex = 3;
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.ForeColor = Color.FromArgb(255, 109, 0);
            labelWelcome.Location = new Point(380, 194);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(620, 68);
            labelWelcome.TabIndex = 4;
            labelWelcome.Text = "Welcome to FPT University\r\n";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 109, 0);
            label1.Location = new Point(426, 252);
            label1.Name = "label1";
            label1.Size = new Size(528, 68);
            label1.TabIndex = 5;
            label1.Text = "Online Courses System";
            // 
            // panelRoleSelection
            // 
            panelRoleSelection.Controls.Add(btnSignup);
            panelRoleSelection.Controls.Add(btnLogin);
            panelRoleSelection.Location = new Point(450, 320);
            panelRoleSelection.Name = "panelRoleSelection";
            panelRoleSelection.Size = new Size(480, 580);
            panelRoleSelection.TabIndex = 6;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.White;
            btnSignup.FlatAppearance.BorderColor = Color.FromArgb(255, 109, 0);
            btnSignup.FlatAppearance.BorderSize = 2;
            btnSignup.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 109, 0);
            btnSignup.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 109, 0);
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.ForeColor = Color.FromArgb(255, 109, 0);
            btnSignup.Location = new Point(250, 155);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(200, 60);
            btnSignup.TabIndex = 2;
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
            btnLogin.Location = new Point(30, 155);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 60);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1380, 930);
            Controls.Add(panelRoleSelection);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            Controls.Add(panelHorizontal);
            Controls.Add(panelLogo);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRoleSelection.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Label labelCopyright;
        private Button btnClose;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelHorizontal;
        private Label labelWelcome;
        private Label label1;
        private Panel panelRoleSelection;
        private Button btnSignup;
        private Button btnLogin;
    }
}