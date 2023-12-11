namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.AdminForms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            label3 = new Label();
            buttonEmail = new Button();
            panel4 = new Panel();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            chartCustomer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonEmail);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 600);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(65, 46, 39);
            label3.Location = new Point(119, 350);
            label3.Name = "label3";
            label3.Size = new Size(95, 40);
            label3.TabIndex = 30;
            label3.Text = "Email";
            // 
            // buttonEmail
            // 
            buttonEmail.BackgroundImage = (Image)resources.GetObject("buttonEmail.BackgroundImage");
            buttonEmail.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEmail.FlatAppearance.BorderSize = 0;
            buttonEmail.FlatStyle = FlatStyle.Flat;
            buttonEmail.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEmail.ForeColor = Color.FromArgb(237, 225, 211);
            buttonEmail.Location = new Point(91, 392);
            buttonEmail.Name = "buttonEmail";
            buttonEmail.Size = new Size(150, 120);
            buttonEmail.TabIndex = 12;
            buttonEmail.UseVisualStyleBackColor = true;
            buttonEmail.Click += buttonEmail_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(chart);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(445, 220);
            panel4.TabIndex = 1;
            // 
            // chart
            // 
            chart.BackColor = Color.FromArgb(237, 225, 211);
            chart.BackSecondaryColor = Color.FromArgb(237, 225, 211);
            chart.BorderlineColor = Color.FromArgb(237, 225, 211);
            chartArea1.BackColor = Color.FromArgb(237, 225, 211);
            chartArea1.BackSecondaryColor = Color.FromArgb(237, 225, 211);
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Dock = DockStyle.Fill;
            legend1.BackColor = Color.FromArgb(237, 225, 211);
            legend1.Font = new Font("Beaufort for LOL", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            legend1.ForeColor = Color.FromArgb(66, 47, 40);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(0, 0);
            chart.Name = "chart";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BackImageTransparentColor = Color.FromArgb(237, 225, 211);
            series1.BackSecondaryColor = Color.FromArgb(237, 225, 211);
            series1.BorderColor = Color.FromArgb(237, 225, 211);
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = Color.FromArgb(237, 225, 211);
            series1.Font = new Font("Beaufort for LOL", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            series1.LabelForeColor = Color.FromArgb(66, 47, 40);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.YValuesPerPoint = 6;
            chart.Series.Add(series1);
            chart.Size = new Size(445, 220);
            chart.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 70);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(65, 46, 39);
            label1.Location = new Point(119, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 40);
            label1.TabIndex = 29;
            label1.Text = "Income";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(445, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 600);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 280);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 280);
            panel7.Name = "panel7";
            panel7.Size = new Size(455, 70);
            panel7.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(65, 46, 39);
            label2.Location = new Point(160, 20);
            label2.Name = "label2";
            label2.Size = new Size(145, 40);
            label2.TabIndex = 29;
            label2.Text = "Customer";
            // 
            // panel6
            // 
            panel6.Controls.Add(chartCustomer);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 350);
            panel6.Name = "panel6";
            panel6.Size = new Size(455, 220);
            panel6.TabIndex = 1;
            // 
            // chartCustomer
            // 
            chartCustomer.BackColor = Color.FromArgb(237, 225, 211);
            chartCustomer.BackSecondaryColor = Color.FromArgb(237, 225, 211);
            chartCustomer.BorderlineColor = Color.FromArgb(237, 225, 211);
            chartArea2.BackColor = Color.FromArgb(237, 225, 211);
            chartArea2.BackSecondaryColor = Color.FromArgb(237, 225, 211);
            chartArea2.Name = "ChartArea1";
            chartCustomer.ChartAreas.Add(chartArea2);
            chartCustomer.Dock = DockStyle.Fill;
            legend2.BackColor = Color.FromArgb(237, 225, 211);
            legend2.Enabled = false;
            legend2.Font = new Font("Beaufort for LOL", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            legend2.ForeColor = Color.FromArgb(66, 47, 40);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            chartCustomer.Legends.Add(legend2);
            chartCustomer.Location = new Point(0, 0);
            chartCustomer.Name = "chartCustomer";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.BackImageTransparentColor = Color.FromArgb(237, 225, 211);
            series2.BackSecondaryColor = Color.FromArgb(237, 225, 211);
            series2.BorderColor = Color.FromArgb(237, 225, 211);
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Color = Color.FromArgb(237, 225, 211);
            series2.Font = new Font("Beaufort for LOL", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            series2.LabelForeColor = Color.FromArgb(66, 47, 40);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series2.ShadowColor = Color.FromArgb(237, 225, 211);
            series2.YValuesPerPoint = 6;
            chartCustomer.Series.Add(series2);
            chartCustomer.Size = new Size(455, 220);
            chartCustomer.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 570);
            panel5.Name = "panel5";
            panel5.Size = new Size(455, 30);
            panel5.TabIndex = 0;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(237, 225, 211);
            ClientSize = new Size(900, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Label label1;
        private Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomer;
        private Panel panel5;
        private Panel panel7;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonEmail;
        private Label label3;
    }
}