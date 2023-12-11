namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.AdminForms
{
    partial class FinishedAppointmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishedAppointmentsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridView = new DataGridView();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.BackgroundImage = (Image)resources.GetObject("buttonSearch.BackgroundImage");
            buttonSearch.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.FromArgb(237, 225, 211);
            buttonSearch.Location = new Point(260, 130);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(35, 35);
            buttonSearch.TabIndex = 30;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(106, 112, 76);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Beaufort for LOL Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxSearch.Location = new Point(74, 132);
            textBoxSearch.MaxLength = 60;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(180, 31);
            textBoxSearch.TabIndex = 29;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(66, 47, 40);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(66, 47, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(237, 225, 211);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = Color.FromArgb(237, 225, 211);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle2.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(66, 47, 40);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(66, 47, 40);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 80;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(106, 112, 76);
            dataGridViewCellStyle3.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(106, 112, 76);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(74, 169);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 100;
            dataGridView.RowTemplate.Height = 40;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView.Size = new Size(814, 370);
            dataGridView.TabIndex = 27;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Beaufort for LOL", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(65, 46, 39);
            label6.Location = new Point(215, 9);
            label6.Name = "label6";
            label6.Size = new Size(464, 60);
            label6.TabIndex = 28;
            label6.Text = "Finised Appointments";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 600);
            panel1.TabIndex = 31;
            // 
            // FinishedAppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(237, 225, 211);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(900, 600);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView);
            Controls.Add(label6);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FinishedAppointmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FinishedAppointmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridView;
        private Label label6;
        private Panel panel1;
    }
}