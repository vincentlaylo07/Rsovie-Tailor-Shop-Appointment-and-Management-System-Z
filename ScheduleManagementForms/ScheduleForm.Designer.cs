namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.ScheduleManagementForms
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            dataGridView = new DataGridView();
            buttonDelete = new Button();
            textBoxDelete = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(106, 112, 76);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Beaufort for LOL Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxSearch.Location = new Point(12, 12);
            textBoxSearch.MaxLength = 60;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(180, 31);
            textBoxSearch.TabIndex = 28;
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
            buttonSearch.Location = new Point(198, 10);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(35, 35);
            buttonSearch.TabIndex = 29;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle7.BackColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(66, 47, 40);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(66, 47, 40);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(237, 225, 211);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.BackgroundColor = Color.FromArgb(237, 225, 211);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle8.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(66, 47, 40);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(66, 47, 40);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.ColumnHeadersHeight = 80;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(106, 112, 76);
            dataGridViewCellStyle9.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(237, 225, 211);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(106, 112, 76);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(12, 49);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 100;
            dataGridView.RowTemplate.Height = 40;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView.Size = new Size(530, 307);
            dataGridView.TabIndex = 27;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = (Image)resources.GetObject("buttonDelete.BackgroundImage");
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.FromArgb(237, 225, 211);
            buttonDelete.Location = new Point(605, 160);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(96, 45);
            buttonDelete.TabIndex = 31;
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
            textBoxDelete.Location = new Point(640, 119);
            textBoxDelete.MaxLength = 60;
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(80, 35);
            textBoxDelete.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(65, 46, 39);
            label2.Location = new Point(585, 120);
            label2.Name = "label2";
            label2.Size = new Size(49, 34);
            label2.TabIndex = 33;
            label2.Text = "ID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDelete);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 370);
            panel1.TabIndex = 30;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 225, 211);
            ClientSize = new Size(770, 370);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScheduleForm";
            Text = "DeleteScheduleForm";
            Load += ScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridView;
        private Button buttonDelete;
        private TextBox textBoxDelete;
        private Label label2;
        private Panel panel1;
    }
}