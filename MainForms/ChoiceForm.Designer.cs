namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.MainForms
{
    partial class ChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceForm));
            panelAdminBar = new Panel();
            buttonMinimize = new Button();
            buttonExit = new Button();
            label1 = new Label();
            buttonAdmin = new Button();
            buttonAppointment = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panelAdminBar.SuspendLayout();
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
            buttonMinimize.TabIndex = 6;
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
            buttonExit.TabIndex = 5;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Beaufort for LOL", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(106, 112, 76);
            label1.Location = new Point(109, 74);
            label1.Name = "label1";
            label1.Size = new Size(95, 36);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackgroundImage = (Image)resources.GetObject("buttonAdmin.BackgroundImage");
            buttonAdmin.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAdmin.Location = new Point(210, 80);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(30, 30);
            buttonAdmin.TabIndex = 2;
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonAppointment
            // 
            buttonAppointment.BackgroundImage = (Image)resources.GetObject("buttonAppointment.BackgroundImage");
            buttonAppointment.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAppointment.FlatAppearance.BorderSize = 0;
            buttonAppointment.FlatStyle = FlatStyle.Flat;
            buttonAppointment.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAppointment.Location = new Point(245, 120);
            buttonAppointment.Name = "buttonAppointment";
            buttonAppointment.Size = new Size(30, 30);
            buttonAppointment.TabIndex = 4;
            buttonAppointment.UseVisualStyleBackColor = true;
            buttonAppointment.Click += buttonAppointment_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Beaufort for LOL", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(106, 112, 76);
            label2.Location = new Point(65, 113);
            label2.Name = "label2";
            label2.Size = new Size(174, 36);
            label2.TabIndex = 3;
            label2.Text = "Appointment";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 200);
            panel1.TabIndex = 5;
            // 
            // ChoiceForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(237, 225, 211);
            ClientSize = new Size(350, 200);
            Controls.Add(buttonAppointment);
            Controls.Add(label2);
            Controls.Add(buttonAdmin);
            Controls.Add(label1);
            Controls.Add(panelAdminBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChoiceForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            panelAdminBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAdminBar;
        private Label label1;
        private Button buttonAdmin;
        private Button buttonAppointment;
        private Label label2;
        private Button buttonExit;
        private Button buttonMinimize;
        private Panel panel1;
    }
}