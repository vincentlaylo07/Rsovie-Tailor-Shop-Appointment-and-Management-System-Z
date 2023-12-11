using Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.MainForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes
{
    internal class ErrorClass
    {
        public async Task ShowErrorForm(string errorMessage, Form form)
        {
            MainForms.ErrorHandlerForm errorHandlerForm = new ErrorHandlerForm();

            errorHandlerForm.labelErrorMessage.Text = errorMessage;

            // Calculate the position to center ErrorHandlerForm on the screen
            int x = form.Location.X + (form.Width - errorHandlerForm.Width) / 2;
            int y = form.Location.Y + (form.Height - errorHandlerForm.Height) / 2;

            // Set the start position to manual and set the location
            errorHandlerForm.StartPosition = FormStartPosition.Manual;
            errorHandlerForm.Location = new Point(x, y);

            errorHandlerForm.Show();

            await Task.Delay(2000); // Delay

            errorHandlerForm.timer1.Start();
            errorHandlerForm.Close();
        }
    }

}
