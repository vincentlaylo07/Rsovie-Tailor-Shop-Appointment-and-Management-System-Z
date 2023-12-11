namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.AdminForms
{
    partial class AppointmentsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentsForm));
            label6 = new Label();
            dataGridView = new DataGridView();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonDelete = new Button();
            textBoxDelete = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Beaufort for LOL", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(65, 46, 39);
            label6.Location = new Point(300, 10);
            label6.Name = "label6";
            label6.Size = new Size(310, 60);
            label6.TabIndex = 24;
            label6.Text = "Appointments";
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
            dataGridView.Location = new Point(70, 170);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 100;
            dataGridView.RowTemplate.Height = 40;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView.Size = new Size(650, 370);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(106, 112, 76);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Beaufort for LOL Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxSearch.Location = new Point(70, 133);
            textBoxSearch.MaxLength = 60;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(180, 31);
            textBoxSearch.TabIndex = 25;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.BackgroundImage = (Image)resources.GetObject("buttonSearch.BackgroundImage");
            buttonSearch.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.FromArgb(237, 225, 211);
            buttonSearch.Location = new Point(256, 131);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(35, 35);
            buttonSearch.TabIndex = 26;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = (Image)resources.GetObject("buttonDelete.BackgroundImage");
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.FromArgb(237, 225, 211);
            buttonDelete.Location = new Point(760, 174);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(96, 45);
            buttonDelete.TabIndex = 27;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxDelete
            // 
            textBoxDelete.BackColor = Color.FromArgb(106, 112, 76);
            textBoxDelete.BorderStyle = BorderStyle.None;
            textBoxDelete.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxDelete.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxDelete.Location = new Point(795, 133);
            textBoxDelete.MaxLength = 60;
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(80, 35);
            textBoxDelete.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(65, 46, 39);
            label2.Location = new Point(740, 134);
            label2.Name = "label2";
            label2.Size = new Size(49, 34);
            label2.TabIndex = 30;
            label2.Text = "ID:";
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
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(237, 225, 211);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(900, 600);
            Controls.Add(label2);
            Controls.Add(textBoxDelete);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppointmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AppointmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView dataGridView;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonDelete;
        private TextBox textBoxDelete;
        private Label label2;
        private Panel panel1;
    }
}