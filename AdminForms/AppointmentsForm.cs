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

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.AdminForms
{
    public partial class AppointmentsForm : Form
    {
        private Classes.DatabaseClass databaseClass;
        private Classes.PlaySound playSound;
        public AppointmentsForm()
        {
            InitializeComponent();

            databaseClass = new Classes.DatabaseClass();
            playSound = new Classes.PlaySound();
        }

        //Refresh the Datagrid after 100sec
        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadAppointment(); 
            
        }

        private void LoadAppointment()
        {
            DataTable dataTable = databaseClass.LoadDataGridTable();

            dataGridView.DataSource = dataTable;
            dataGridView.ReadOnly = true;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = 200;
            }
            
        }

        public void SearchData(string valueToSearch)
        {
            DataTable searchResult = databaseClass.SearchData(valueToSearch);

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

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

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

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            string deleteInput = textBoxDelete.Text;
            if (!int.TryParse(deleteInput, out int deleteId))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            else
            {
                MessageBox.Show("Deleted ID.");
                databaseClass.DeleteIdAppointment(deleteId);
                dataGridView.DataSource = null; // Clear the data source
                dataGridView.DataSource = databaseClass.ScheduleGridTable(); // Set data source again
                textBoxDelete.Clear();
            }
        }

    }
}
