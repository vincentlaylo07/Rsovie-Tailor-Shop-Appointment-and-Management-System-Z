using Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.AdminForms
{
    public partial class ScheduleForm : Form
    {
        private Form? activeForm; // Tracks the currently active child form
        private Classes.PlaySound playSound;

        private Classes.DatabaseClass databaseClass;

        public ScheduleForm()
        {
            InitializeComponent();
            databaseClass = new Classes.DatabaseClass();
            playSound = new Classes.PlaySound();
        }

        private async void OpenChildForm(Form childForm)
        {

            ActiveFormClose();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelSchedulePane.Controls.Add(childForm);
            panelSchedulePane.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void ActiveFormClose()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private async void buttonSchedule_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            OpenChildForm(new ScheduleManagementForms.ScheduleForm());
        }

        private async void buttonAddSchedule_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            if (!int.TryParse(textBoxId.Text, out int customerId))
            {
                MessageBox.Show("Enter a valid numeric ID.");
                return;
            }

            if (!DateTime.TryParseExact(textBoxDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime scheduleDate))
            {
                MessageBox.Show("Enter a valid date in the format YYYY-MM-DD.");
                return;
            }

            if (!TimeSpan.TryParse(textBoxTime.Text, out TimeSpan scheduleTime))
            {
                MessageBox.Show("Enter a valid time in the format HH:mm.");
                return;
            }

            databaseClass.InsertSchedule(customerId, scheduleDate, scheduleTime);

            textBoxId.Clear();
            textBoxDate.Clear();
            textBoxTime.Clear();
        }

        private async void buttonManage_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            ActiveFormClose();
        }
    }
}
