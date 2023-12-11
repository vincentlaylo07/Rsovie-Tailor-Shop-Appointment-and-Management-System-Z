using Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.AdminForms;
using Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.MainForms
{
    public partial class AdminForm : Form
    {
        // Fields
        Thread thread;

        private Classes.DragFormClass dragForm;
        private Classes.LinkClass linkClass;
        private Classes.PlaySound playSound;

        private Button? currentButton; // Represents the currently selected button in the menu
        private Form? activeForm; // Tracks the currently active child form

        public AdminForm()
        {
            InitializeComponent();

            dragForm = new DragFormClass(this);
            linkClass = new LinkClass();
            playSound = new PlaySound();
        }

        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton(); // Disables previously active buttons
                    Color color = SetThemeColor();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = color; // Sets the background color for the selected button
                }
            }
        }

        // Disables all buttons in the menu
        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(106, 112, 76); // Resets button background color
                }
            }
        }

        // Open child form in the panel
        private async void OpenChildForm(Form childForm, object buttonSender)
        {
            await playSound.zPlaySound();

            if (panelAdminPane.Controls.Count > 0)
            {
                panelAdminPane.Controls.RemoveAt(0); // Remove the existing form from the panel
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelAdminPane.Controls.Add(childForm); // Adds the child form to the panel
            panelAdminPane.Tag = childForm;

            childForm.BringToFront(); // Brings the child form to the front
            childForm.Show(); // Displays the child form

            ActivateButton(buttonSender); // Activates the corresponding menu button

        }

        private Color SetThemeColor()
        {
            return ColorTranslator.FromHtml("#422f28");
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelAdminBarDashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm.MouseDownMethod(sender, e);
        }

        private void panelAdminBarDashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            dragForm.MouseMoveMethod(sender, e);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm(), sender);
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AppointmentsForm(), sender);
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ScheduleForm(), sender);
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PaymentsForm(), sender);
        }

        private void buttonFinishedAppointments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FinishedAppointmentsForm(), sender);
        }

        private async void buttonBack_Click(object sender, EventArgs e)
        {
            if (activeForm != null) // Check if the active form is not the MainForm
            {
                activeForm.Close();
            }
            else
            {
                Reset(); // Resets UI elements
            }

            await playSound.xPlaySound();
        }

        // Resets UI elements to default state
        private void Reset()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            DisableButton(); // Resets button colors
            currentButton = null;

            // Clear the child form from the panel
            if (panelAdminPane.Controls.Count > 0)
            {
                panelAdminPane.Controls.RemoveAt(0);
            }
        }

        private async void buttonBackToChoice_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();
            this.Dispose();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenForm(object? obj)
        {
            Application.Run(new ChoiceForm());
        }
    }
}
