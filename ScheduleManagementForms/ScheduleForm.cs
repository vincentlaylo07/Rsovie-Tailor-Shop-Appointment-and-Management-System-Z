using Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.ScheduleManagementForms
{
    public partial class ScheduleForm : Form
    {
        private Classes.DatabaseClass databaseClass;
        public ScheduleForm()
        {
            InitializeComponent();

            databaseClass = new Classes.DatabaseClass();
        }

        private async void LoadAppointment()
        {
            DataTable dataTable = databaseClass.ScheduleGridTable();

            dataGridView.DataSource = dataTable;
            dataGridView.ReadOnly = true;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = 200;
            }
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            LoadAppointment();
        }

        public async void SearchData(string valueToSearch)
        {
            DataTable searchResult = databaseClass.ScheduleGridTableSearch(valueToSearch);

            if (searchResult != null && searchResult.Rows.Count > 0)
            {
                dataGridView.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("No Records!");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchData("");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBoxSearch.Text.ToString();
            SearchData(valueToSearch);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
                e.SuppressKeyPress = true; // Suppress the Enter key
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string deleteInput = textBoxDelete.Text;
            if (!int.TryParse(deleteInput, out int deleteId))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            else
            {
                MessageBox.Show("Deleted ID.");
                databaseClass.DeleteSchedule(deleteId);
                dataGridView.DataSource = null; // Clear the data source
                dataGridView.DataSource = databaseClass.ScheduleGridTable(); // Set data source again
                textBoxDelete.Clear();
            }
        }
    }
}
