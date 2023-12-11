using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.MainForms
{
    public partial class ChoiceForm : Form
    {
        //Fields
        Thread thread; 

        private DragFormClass dragForm;
        private Classes.PlaySound playSound;

        public ChoiceForm()
        {
            InitializeComponent();

            dragForm = new DragFormClass(this);
            playSound = new Classes.PlaySound();
        }

        private async void buttonAdmin_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            this.Dispose();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenForm(object? obj)
        {
            Application.Run(new AdminLoginForm());
        }

        private async void buttonAppointment_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound(); 

            this.Dispose();
            thread = new Thread(OpenForm2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenForm2(object? obj)
        {
            Application.Run(new AppointmentForm());
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelAdminBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm.MouseDownMethod(sender, e);
        }

        private void panelAdminBar_MouseMove(object sender, MouseEventArgs e)
        {
            dragForm.MouseMoveMethod(sender, e);
        }
    }
}
