namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.AdminForms
{
    partial class PaymentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label6 = new Label();
            textBoxPayment = new TextBox();
            textBoxId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelChange = new Label();
            buttonSubmit = new Button();
            label4 = new Label();
            textBoxCost = new TextBox();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Beaufort for LOL", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(65, 46, 39);
            label6.Location = new Point(225, 10);
            label6.Name = "label6";
            label6.Size = new Size(428, 60);
            label6.TabIndex = 25;
            label6.Text = "Customers Payment";
            // 
            // textBoxPayment
            // 
            textBoxPayment.BackColor = Color.FromArgb(106, 112, 76);
            textBoxPayment.BorderStyle = BorderStyle.None;
            textBoxPayment.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPayment.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxPayment.Location = new Point(293, 231);
            textBoxPayment.MaxLength = 60;
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.Size = new Size(220, 41);
            textBoxPayment.TabIndex = 26;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.FromArgb(106, 112, 76);
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxId.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxId.Location = new Point(293, 288);
            textBoxId.MaxLength = 60;
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(220, 41);
            textBoxId.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(65, 46, 39);
            label1.Location = new Point(143, 231);
            label1.Name = "label1";
            label1.Size = new Size(144, 40);
            label1.TabIndex = 28;
            label1.Text = "Payment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(65, 46, 39);
            label2.Location = new Point(100, 289);
            label2.Name = "label2";
            label2.Size = new Size(191, 40);
            label2.TabIndex = 29;
            label2.Text = "Customer ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(65, 46, 39);
            label3.Location = new Point(161, 344);
            label3.Name = "label3";
            label3.Size = new Size(126, 40);
            label3.TabIndex = 31;
            label3.Text = "Change:";
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelChange.ForeColor = Color.FromArgb(65, 46, 39);
            labelChange.Location = new Point(293, 344);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(0, 40);
            labelChange.TabIndex = 32;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackgroundImage = (Image)resources.GetObject("buttonSubmit.BackgroundImage");
            buttonSubmit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSubmit.ForeColor = Color.FromArgb(237, 225, 211);
            buttonSubmit.Location = new Point(345, 400);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(100, 45);
            buttonSubmit.TabIndex = 33;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(65, 46, 39);
            label4.Location = new Point(204, 175);
            label4.Name = "label4";
            label4.Size = new Size(83, 40);
            label4.TabIndex = 35;
            label4.Text = "Cost:";
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = Color.FromArgb(106, 112, 76);
            textBoxCost.BorderStyle = BorderStyle.None;
            textBoxCost.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxCost.ForeColor = Color.FromArgb(237, 225, 211);
            textBoxCost.Location = new Point(293, 174);
            textBoxCost.MaxLength = 60;
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(220, 41);
            textBoxCost.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(buttonSubmit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 600);
            panel1.TabIndex = 36;
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
            dataGridView.Location = new Point(550, 129);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 100;
            dataGridView.RowTemplate.Height = 40;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView.Size = new Size(300, 200);
            dataGridView.TabIndex = 37;
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(237, 225, 211);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(900, 600);
            Controls.Add(dataGridView);
            Controls.Add(label4);
            Controls.Add(textBoxCost);
            Controls.Add(labelChange);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(textBoxPayment);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentsForm";
            Load += PaymentsForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBoxPayment;
        private TextBox textBoxId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelChange;
        private Button buttonSubmit;
        private Label label4;
        private TextBox textBoxCost;
        private Panel panel1;
        private DataGridView dataGridView;
    }
}