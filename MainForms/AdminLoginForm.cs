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

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.MainForms
{
    public partial class AdminLoginForm : Form
    {
        //Fields
        Thread thread;

        private Classes.DatabaseClass databaseClass;
        private Classes.DragFormClass dragForm;
        private Classes.PasswordManagerClass passwordManagerClass;
        private Classes.ErrorClass errorClass;
        private Classes.PlaySound playSound;

        public AdminLoginForm()
        {
            InitializeComponent();

            dragForm = new DragFormClass(this);
            databaseClass = new Classes.DatabaseClass();
            passwordManagerClass = new PasswordManagerClass();
            errorClass = new ErrorClass();
            playSound = new PlaySound();
        }

        private void panelAdminBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm.MouseDownMethod(sender, e);
        }

        private void panelAdminBar_MouseMove(object sender, MouseEventArgs e)
        {
            dragForm.MouseMoveMethod(sender, e);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void buttonBack_Click(object sender, EventArgs e)
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

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            // Read the region
            #region
            // I used this to insert the password bruh
            //string password = passwordManagerClass.HashPassword("examplepassword");
            //databaseClass.InsertHashedPassword(password);
            #endregion

            await playSound.xPlaySound();
            string userInputUsername = textBoxUsername.Text;
            string userInputPassword = textBoxPassword.Text;

            string storedHashedPassword = databaseClass.GetStoredHashedPassword(); // Retrieve hashed password from the database

            bool isCorrectUsername = userInputUsername == "Admin";
            bool passwordsMatch = passwordManagerClass.VerifyPassword(userInputPassword, storedHashedPassword);

            if (isCorrectUsername && passwordsMatch)
            {
                this.Dispose();
                thread = new Thread(OpenForm2);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                await errorClass.ShowErrorForm("             Error Bruh!", this);
            }

        }

        private void OpenForm2(object? obj)
        {
            Application.Run(new AdminForm());
        }
    }
}
