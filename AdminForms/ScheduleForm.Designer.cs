namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.AdminForms
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            label6 = new Label();
            panel1 = new Panel();
            buttonSchedule = new Button();
            buttonManage = new Button();
            panelSchedulePane = new Panel();
            label3 = new Label();
            label2 = new Label();
            textBoxTime = new TextBox();
            textBoxDate = new TextBox();
            buttonAddSchedule = new Button();
            label1 = new Label();
            label4 = new Label();
            textBoxId = new TextBox();
            panel1.SuspendLayout();
            panelSchedulePane.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Beaufort for LOL", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(65, 46, 39);
            label6.Location = new Point(220, 9);
            label6.Name = "label6";
            label6.Size = new Size(480, 60);
            label6.TabIndex = 25;
            label6.Text = "Schedule Management";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(buttonSchedule);
            panel1.Controls.Add(buttonManage);
            panel1.Controls.Add(panelSchedulePane);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 600);
            panel1.TabIndex = 26;
            // 
            // buttonSchedule
            // 
            buttonSchedule.BackColor = Color.FromArgb(65, 46, 39);
            buttonSchedule.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSchedule.FlatAppearance.BorderSize = 0;
            buttonSchedule.FlatStyle = FlatStyle.Flat;
            buttonSchedule.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSchedule.ForeColor = Color.FromArgb(237, 225, 211);
            buttonSchedule.Location = new Point(480, 119);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(100, 45);
            buttonSchedule.TabIndex = 29;
            buttonSchedule.Text = "Schedule";
            buttonSchedule.UseVisualStyleBackColor = false;
            buttonSchedule.Click += buttonSchedule_Click;
            // 
            // buttonManage
            // 
            buttonManage.BackColor = Color.FromArgb(65, 46, 39);
            buttonManage.BackgroundImageLayout = ImageLayout.Stretch;
            buttonManage.FlatAppearance.BorderSize = 0;
            buttonManage.FlatStyle = FlatStyle.Flat;
            buttonManage.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonManage.ForeColor = Color.FromArgb(237, 225, 211);
            buttonManage.Location = new Point(335, 119);
            buttonManage.Name = "buttonManage";
            buttonManage.Size = new Size(100, 45);
            buttonManage.TabIndex = 28;
            buttonManage.Text = "Manage";
            buttonManage.UseVisualStyleBackColor = false;
            buttonManage.Click += buttonManage_Click;
            // 
            // panelSchedulePane
            // 
            panelSchedulePane.Controls.Add(label3);
            panelSchedulePane.Controls.Add(label2);
            panelSchedulePane.Controls.Add(textBoxTime);
            panelSchedulePane.Controls.Add(textBoxDate);
            panelSchedulePane.Controls.Add(buttonAddSchedule);
            panelSchedulePane.Controls.Add(label1);
            panelSchedulePane.Controls.Add(label4);
            panelSchedulePane.Controls.Add(textBoxId);
            panelSchedulePane.Location = new Point(73, 170);
            panelSchedulePane.Name = "panelSchedulePane";
            panelSchedulePane.Size = new Size(770, 370);
            panelSchedulePane.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Beaufort for LOL", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(65, 46, 39);
            label3.Location = new Point(248, 24);
            label3.Name = "label3";
            label3.Size = new Size(279, 44);
            label3.TabIndex = 43;
            label3.Text = "Schedule Meet Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(65, 46, 39);
            label2.Location = new Point(232, 210);
            label2.Name = "label2";
            label2.Size = new Size(93, 40);
            label2.TabIndex = 42;
            label2.Text = "Time:";
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = Color.FromArgb(106, 112, 76);
            textBoxTime.BorderStyle = BorderStyle.None;
            textBoxTime.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxTime.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxTime.Location = new Point(327, 209);
            textBoxTime.MaxLength = 60;
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(220, 41);
            textBoxTime.TabIndex = 41;
            textBoxTime.Text = "HH:mm";
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = Color.FromArgb(106, 112, 76);
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxDate.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxDate.Location = new Point(327, 154);
            textBoxDate.MaxLength = 60;
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(220, 41);
            textBoxDate.TabIndex = 40;
            textBoxDate.Text = "yyyy-MM-dd";
            // 
            // buttonAddSchedule
            // 
            buttonAddSchedule.BackColor = Color.FromArgb(65, 46, 39);
            buttonAddSchedule.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAddSchedule.FlatAppearance.BorderSize = 0;
            buttonAddSchedule.FlatStyle = FlatStyle.Flat;
            buttonAddSchedule.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAddSchedule.ForeColor = Color.FromArgb(237, 225, 211);
            buttonAddSchedule.Location = new Point(327, 265);
            buttonAddSchedule.Name = "buttonAddSchedule";
            buttonAddSchedule.Size = new Size(100, 45);
            buttonAddSchedule.TabIndex = 39;
            buttonAddSchedule.Text = "Add";
            buttonAddSchedule.UseVisualStyleBackColor = false;
            buttonAddSchedule.Click += buttonAddSchedule_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(65, 46, 39);
            label1.Location = new Point(232, 155);
            label1.Name = "label1";
            label1.Size = new Size(89, 40);
            label1.TabIndex = 38;
            label1.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(65, 46, 39);
            label4.Location = new Point(130, 98);
            label4.Name = "label4";
            label4.Size = new Size(191, 40);
            label4.TabIndex = 36;
            label4.Text = "Customer ID:";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.FromArgb(106, 112, 76);
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxId.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxId.Location = new Point(327, 98);
            textBoxId.MaxLength = 60;
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(220, 41);
            textBoxId.TabIndex = 28;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(237, 225, 211);
            ClientSize = new Size(900, 600);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panelSchedulePane.ResumeLayout(false);
            panelSchedulePane.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private Panel panelSchedulePane;
        private Button buttonSchedule;
        private Button buttonManage;
        private TextBox textBoxId;
        private Label label1;
        private Label label4;
        private Button buttonAddSchedule;
        private Label label2;
        private TextBox textBoxTime;
        private TextBox textBoxDate;
        private Label label3;
    }
}