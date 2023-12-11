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
    public partial class PaymentsForm : Form
    {
        private Classes.DatabaseClass databaseClass;
        private Classes.PlaySound playSound;
        public PaymentsForm()
        {
            InitializeComponent();

            databaseClass = new DatabaseClass();
            playSound = new Classes.PlaySound();
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            if (string.IsNullOrEmpty(textBoxCost.Text)
                || string.IsNullOrEmpty(textBoxPayment.Text)
                || string.IsNullOrEmpty(textBoxId.Text))
            {
                labelChange.Text = "Fill out all fields.";
            }
            else
            {
                if (int.TryParse(textBoxCost.Text, out int cost) &&
                    int.TryParse(textBoxPayment.Text, out int payment) &&
                    int.TryParse(textBoxId.Text, out int customerId))
                {
                    // Retrieve scheduleId based on the customerId (you need a method to get this)
                    int scheduleId = databaseClass.GetScheduleId(customerId);

                    int calculatedChange = payment - cost; // Calculate change based on the cost

                    if (calculatedChange >= 0)
                    {
                        // Assuming you have a databaseClass instance to perform operations
                        databaseClass.InsertIntoTransactionDetails(customerId, scheduleId, payment, calculatedChange, cost);

                        labelChange.Text = $"{calculatedChange}";
                    }
                    else
                    {
                        labelChange.Text = "Change cannot be negative.";
                    }
                }
                else
                {
                    labelChange.Text = "Enter numeric values.";
                }
            }
            textBoxCost.Clear();
            textBoxPayment.Clear();
            textBoxId.Clear();
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            LoadAppointment();
        }
        private void LoadAppointment()
        {
            DataTable dataTable = databaseClass.ScheduleGridTablePayment();

            if (dataTable.Rows.Count > 0)
            {
                dataGridView.DataSource = dataTable;
                dataGridView.ReadOnly = true;

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.Width = 140;
                }
            }
            else
            {
                dataGridView.Visible = false;
            }
        }

    }
}
