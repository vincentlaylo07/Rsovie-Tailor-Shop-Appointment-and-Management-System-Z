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
    public partial class FinishedAppointmentsForm : Form
    {
        private Classes.DatabaseClass databaseClass;
        private Classes.PlaySound playSound;
        public FinishedAppointmentsForm()
        {
            InitializeComponent();

            databaseClass = new Classes.DatabaseClass();
            playSound = new Classes.PlaySound();
        }

        private void LoadFinishedAppointments()
        {
            DataTable dataTable = databaseClass.FinishedAppointments();

            dataGridView.DataSource = dataTable;
            dataGridView.ReadOnly = true;
            dataGridView.Update();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = 200;
            }

        }

        private void FinishedAppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadFinishedAppointments();
        }

        public void SearchData(string valueToSearch)
        {
            DataTable searchResult = databaseClass.SearchFinishedAppointments(valueToSearch);

            if (searchResult != null && searchResult.Rows.Count > 0)
            {
                dataGridView.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("No Records");
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
    }
}
