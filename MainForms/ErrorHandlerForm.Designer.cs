namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.MainForms
{
    partial class ErrorHandlerForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorHandlerForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panelLoading = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            labelErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 170);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(65, 46, 39);
            panel1.Controls.Add(panelLoading);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 30);
            panel1.TabIndex = 4;
            // 
            // panelLoading
            // 
            panelLoading.BackColor = Color.FromArgb(106, 112, 76);
            panelLoading.Location = new Point(0, 0);
            panelLoading.Name = "panelLoading";
            panelLoading.Size = new Size(40, 30);
            panelLoading.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelErrorMessage.ForeColor = Color.FromArgb(65, 46, 39);
            labelErrorMessage.Location = new Point(176, 65);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(0, 34);
            labelErrorMessage.TabIndex = 16;
            // 
            // ErrorHandlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 225, 211);
            ClientSize = new Size(500, 200);
            Controls.Add(labelErrorMessage);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ErrorHandlerForm";
            Opacity = 0.9D;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panelLoading;
        public Label labelErrorMessage;
        public System.Windows.Forms.Timer timer1;
    }
}