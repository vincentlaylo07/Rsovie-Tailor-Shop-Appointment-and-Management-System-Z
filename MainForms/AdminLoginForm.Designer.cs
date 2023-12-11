namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.MainForms
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            panelAdminBar = new Panel();
            buttonMinimize = new Button();
            buttonExit = new Button();
            label1 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            buttonBack = new Button();
            buttonLogin = new Button();
            label3 = new Label();
            panel1 = new Panel();
            panelAdminBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdminBar
            // 
            panelAdminBar.Controls.Add(buttonMinimize);
            panelAdminBar.Controls.Add(buttonExit);
            panelAdminBar.Dock = DockStyle.Top;
            panelAdminBar.Location = new Point(0, 0);
            panelAdminBar.Name = "panelAdminBar";
            panelAdminBar.Size = new Size(350, 50);
            panelAdminBar.TabIndex = 0;
            panelAdminBar.MouseDown += panelAdminBar_MouseDown;
            panelAdminBar.MouseMove += panelAdminBar_MouseMove;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackgroundImage = (Image)resources.GetObject("buttonMinimize.BackgroundImage");
            buttonMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMinimize.ForeColor = Color.FromArgb(237, 225, 211);
            buttonMinimize.Location = new Point(291, 3);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(25, 25);
            buttonMinimize.TabIndex = 8;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackgroundImage = (Image)resources.GetObject("buttonExit.BackgroundImage");
            buttonExit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.FromArgb(237, 225, 211);
            buttonExit.Location = new Point(322, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(25, 25);
            buttonExit.TabIndex = 7;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(65, 46, 39);
            label1.Location = new Point(20, 130);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(106, 112, 76);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxUsername.Location = new Point(145, 130);
            textBoxUsername.MaxLength = 60;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(180, 31);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(106, 112, 76);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Beaufort for LOL Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxPassword.Location = new Point(145, 190);
            textBoxPassword.MaxLength = 60;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(180, 31);
            textBoxPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(65, 46, 39);
            label2.Location = new Point(20, 190);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.FromArgb(65, 46, 39);
            buttonBack.Location = new Point(3, 297);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(45, 30);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "<<";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackgroundImage = (Image)resources.GetObject("buttonLogin.BackgroundImage");
            buttonLogin.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.FromArgb(237, 225, 211);
            buttonLogin.Location = new Point(120, 245);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(100, 45);
            buttonLogin.TabIndex = 10;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(65, 46, 39);
            label3.Location = new Point(40, 60);
            label3.Name = "label3";
            label3.Size = new Size(267, 34);
            label3.TabIndex = 11;
            label3.Text = "Welcome Back Admin!";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 330);
            panel1.TabIndex = 12;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(237, 225, 211);
            ClientSize = new Size(350, 330);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(panelAdminBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminLoginForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            panelAdminBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAdminBar;
        private Button buttonMinimize;
        private Button buttonExit;
        private Label label1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonBack;
        private Button buttonLogin;
        private Label label3;
        private Panel panel1;
    }
}