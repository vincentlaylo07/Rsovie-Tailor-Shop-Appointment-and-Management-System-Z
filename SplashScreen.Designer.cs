namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            circularProgressBar = new CircularProgressBar_NET5.CircularProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // circularProgressBar
            // 
            circularProgressBar.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            circularProgressBar.AnimationSpeed = 500;
            circularProgressBar.BackColor = Color.Transparent;
            circularProgressBar.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            circularProgressBar.ForeColor = Color.FromArgb(106, 112, 76);
            circularProgressBar.InnerColor = Color.FromArgb(237, 225, 211);
            circularProgressBar.InnerMargin = 2;
            circularProgressBar.InnerWidth = -1;
            circularProgressBar.Location = new Point(360, 298);
            circularProgressBar.MarqueeAnimationSpeed = 2000;
            circularProgressBar.Name = "circularProgressBar";
            circularProgressBar.OuterColor = Color.FromArgb(66, 47, 40);
            circularProgressBar.OuterMargin = -25;
            circularProgressBar.OuterWidth = 25;
            circularProgressBar.ProgressColor = Color.FromArgb(106, 112, 76);
            circularProgressBar.ProgressWidth = 10;
            circularProgressBar.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar.Size = new Size(80, 80);
            circularProgressBar.StartAngle = 270;
            circularProgressBar.Style = ProgressBarStyle.Marquee;
            circularProgressBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar.SubscriptText = "";
            circularProgressBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar.SuperscriptText = "";
            circularProgressBar.TabIndex = 1;
            circularProgressBar.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar.Value = 68;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(255, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 290);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(circularProgressBar);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 3;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(237, 225, 211);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashScreen";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CircularProgressBar_NET5.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
