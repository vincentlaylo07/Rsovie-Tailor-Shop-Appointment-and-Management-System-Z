namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.MainForms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            buttonMinimize = new Button();
            buttonExit = new Button();
            panelAdminBarDashBoard = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            panelMenu = new Panel();
            buttonBackToChoice = new Button();
            buttonFinishedAppointments = new Button();
            buttonPayments = new Button();
            buttonSchedule = new Button();
            buttonAppointments = new Button();
            buttonDashboard = new Button();
            panel3 = new Panel();
            buttonBack = new Button();
            panelAdminPane = new Panel();
            panelAdminBarDashBoard.SuspendLayout();
            panel4.SuspendLayout();
            panelMenu.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackgroundImage = (Image)resources.GetObject("buttonMinimize.BackgroundImage");
            buttonMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMinimize.ForeColor = Color.FromArgb(237, 225, 211);
            buttonMinimize.Location = new Point(1041, 3);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(25, 25);
            buttonMinimize.TabIndex = 10;
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
            buttonExit.Location = new Point(1072, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(25, 25);
            buttonExit.TabIndex = 9;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // panelAdminBarDashBoard
            // 
            panelAdminBarDashBoard.Controls.Add(panel4);
            panelAdminBarDashBoard.Controls.Add(buttonExit);
            panelAdminBarDashBoard.Controls.Add(buttonMinimize);
            panelAdminBarDashBoard.Dock = DockStyle.Top;
            panelAdminBarDashBoard.Location = new Point(0, 0);
            panelAdminBarDashBoard.Name = "panelAdminBarDashBoard";
            panelAdminBarDashBoard.Size = new Size(1100, 50);
            panelAdminBarDashBoard.TabIndex = 11;
            panelAdminBarDashBoard.MouseDown += panelAdminBarDashBoard_MouseDown;
            panelAdminBarDashBoard.MouseMove += panelAdminBarDashBoard_MouseMove;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(106, 112, 76);
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 50);
            panel4.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 49);
            panel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(106, 112, 76);
            panelMenu.Controls.Add(buttonBackToChoice);
            panelMenu.Controls.Add(buttonFinishedAppointments);
            panelMenu.Controls.Add(buttonPayments);
            panelMenu.Controls.Add(buttonSchedule);
            panelMenu.Controls.Add(buttonAppointments);
            panelMenu.Controls.Add(buttonDashboard);
            panelMenu.Controls.Add(panel3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 50);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 600);
            panelMenu.TabIndex = 0;
            // 
            // buttonBackToChoice
            // 
            buttonBackToChoice.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBackToChoice.FlatAppearance.BorderSize = 0;
            buttonBackToChoice.FlatStyle = FlatStyle.Flat;
            buttonBackToChoice.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBackToChoice.ForeColor = Color.FromArgb(237, 225, 211);
            buttonBackToChoice.Location = new Point(3, 567);
            buttonBackToChoice.Name = "buttonBackToChoice";
            buttonBackToChoice.Size = new Size(45, 30);
            buttonBackToChoice.TabIndex = 11;
            buttonBackToChoice.Text = "<<";
            buttonBackToChoice.UseVisualStyleBackColor = true;
            buttonBackToChoice.Click += buttonBackToChoice_Click;
            // 
            // buttonFinishedAppointments
            // 
            buttonFinishedAppointments.Dock = DockStyle.Top;
            buttonFinishedAppointments.FlatAppearance.BorderSize = 0;
            buttonFinishedAppointments.FlatStyle = FlatStyle.Flat;
            buttonFinishedAppointments.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonFinishedAppointments.ForeColor = Color.FromArgb(237, 225, 211);
            buttonFinishedAppointments.Image = (Image)resources.GetObject("buttonFinishedAppointments.Image");
            buttonFinishedAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFinishedAppointments.Location = new Point(0, 460);
            buttonFinishedAppointments.Name = "buttonFinishedAppointments";
            buttonFinishedAppointments.Size = new Size(200, 90);
            buttonFinishedAppointments.TabIndex = 10;
            buttonFinishedAppointments.Text = "      Finished";
            buttonFinishedAppointments.UseVisualStyleBackColor = true;
            buttonFinishedAppointments.Click += buttonFinishedAppointments_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.Dock = DockStyle.Top;
            buttonPayments.FlatAppearance.BorderSize = 0;
            buttonPayments.FlatStyle = FlatStyle.Flat;
            buttonPayments.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonPayments.ForeColor = Color.FromArgb(237, 225, 211);
            buttonPayments.Image = (Image)resources.GetObject("buttonPayments.Image");
            buttonPayments.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPayments.Location = new Point(0, 370);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Size = new Size(200, 90);
            buttonPayments.TabIndex = 9;
            buttonPayments.Text = "      Payments";
            buttonPayments.UseVisualStyleBackColor = true;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // buttonSchedule
            // 
            buttonSchedule.Dock = DockStyle.Top;
            buttonSchedule.FlatAppearance.BorderSize = 0;
            buttonSchedule.FlatStyle = FlatStyle.Flat;
            buttonSchedule.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSchedule.ForeColor = Color.FromArgb(237, 225, 211);
            buttonSchedule.Image = (Image)resources.GetObject("buttonSchedule.Image");
            buttonSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSchedule.Location = new Point(0, 280);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(200, 90);
            buttonSchedule.TabIndex = 8;
            buttonSchedule.Text = "      Schedule";
            buttonSchedule.UseVisualStyleBackColor = true;
            buttonSchedule.Click += buttonSchedule_Click;
            // 
            // buttonAppointments
            // 
            buttonAppointments.Dock = DockStyle.Top;
            buttonAppointments.FlatAppearance.BorderSize = 0;
            buttonAppointments.FlatStyle = FlatStyle.Flat;
            buttonAppointments.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAppointments.ForeColor = Color.FromArgb(237, 225, 211);
            buttonAppointments.Image = (Image)resources.GetObject("buttonAppointments.Image");
            buttonAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAppointments.Location = new Point(0, 190);
            buttonAppointments.Name = "buttonAppointments";
            buttonAppointments.Size = new Size(200, 90);
            buttonAppointments.TabIndex = 7;
            buttonAppointments.Text = "          Appointments";
            buttonAppointments.UseVisualStyleBackColor = true;
            buttonAppointments.Click += buttonAppointments_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackgroundImageLayout = ImageLayout.Center;
            buttonDashboard.Dock = DockStyle.Top;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.FromArgb(237, 225, 211);
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(0, 100);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(200, 90);
            buttonDashboard.TabIndex = 6;
            buttonDashboard.Text = "      Dashboard";
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonBack);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImage = (Image)resources.GetObject("buttonBack.BackgroundImage");
            buttonBack.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.FromArgb(237, 225, 211);
            buttonBack.Location = new Point(50, 0);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 100);
            buttonBack.TabIndex = 11;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelAdminPane
            // 
            panelAdminPane.BackgroundImage = (Image)resources.GetObject("panelAdminPane.BackgroundImage");
            panelAdminPane.Dock = DockStyle.Fill;
            panelAdminPane.Location = new Point(200, 50);
            panelAdminPane.Name = "panelAdminPane";
            panelAdminPane.Size = new Size(900, 600);
            panelAdminPane.TabIndex = 12;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 225, 211);
            ClientSize = new Size(1100, 650);
            Controls.Add(panelAdminPane);
            Controls.Add(panelMenu);
            Controls.Add(panelAdminBarDashBoard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            panelAdminBarDashBoard.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonMinimize;
        private Button buttonExit;
        private Panel panelAdminBarDashBoard;
        private Panel panel4;
        private Panel panelMenu;
        private Button buttonFinishedAppointments;
        private Button buttonPayments;
        private Button buttonSchedule;
        private Button buttonAppointments;
        private Button buttonDashboard;
        private Panel panelAdminPane;
        private Panel panel1;
        private Panel panel3;
        private Button buttonBack;
        private Button buttonBackToChoice;
    }
}