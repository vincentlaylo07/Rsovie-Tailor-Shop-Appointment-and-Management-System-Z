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
    public partial class AppointmentForm : Form
    {
        // Fields
        Thread thread;

        private Classes.DragFormClass dragForm;
        private Classes.LinkClass linkClass;
        private Classes.ErrorClass errorClass;
        private Classes.DatabaseClass databaseClass;
        private Classes.PlaySound playSound;

        public AppointmentForm()
        {
            InitializeComponent();

            dragForm = new DragFormClass(this);
            linkClass = new LinkClass();
            errorClass = new ErrorClass();
            databaseClass = new Classes.DatabaseClass();
            playSound = new Classes.PlaySound();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelAAppointmentBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm.MouseDownMethod(sender, e);
        }

        private void panelAAppointmentBar_MouseMove(object sender, MouseEventArgs e)
        {
            dragForm.MouseMoveMethod(sender, e);
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            if (string.IsNullOrEmpty(textBoxFullName.Text)
                || string.IsNullOrEmpty(textBoxAddress.Text)
                || string.IsNullOrEmpty(textBoxEmail.Text)
                || string.IsNullOrEmpty(textBoxContact.Text)
                || string.IsNullOrEmpty(textBoxDescription.Text))
            {
                await errorClass.ShowErrorForm("  Fill Out All Information!", this);
            }
            else if (!this.textBoxEmail.Text.Contains('@') || !this.textBoxEmail.Text.Contains('.'))
            {
                await errorClass.ShowErrorForm("         Invalid Email!", this);
            }
            else if (!checkBoxUniform.Checked && !checkBoxJersey.Checked && !checkBoxPrinting.Checked && !checkBoxOthers.Checked)
            {
                await errorClass.ShowErrorForm("    Check at least one box!", this);
            }
            else if ((checkBoxUniform.Checked && !IsValidNumericInput(textBoxUniformQuantity)) ||
                     (checkBoxJersey.Checked && !IsValidNumericInput(textBoxJerseyQuantity)) ||
                     (checkBoxPrinting.Checked && !IsValidNumericInput(textBoxPrintingQuantity)) ||
                     (checkBoxOthers.Checked && !IsValidNumericInput(textBoxOthersQuantity)))
            {
                await errorClass.ShowErrorForm("       Invalid Quantity!", this);
            }
            else
            {
                // Get values from textboxes
                string fullName = textBoxFullName.Text;
                string address = textBoxAddress.Text;
                string email = textBoxEmail.Text;
                string contact = textBoxContact.Text;
                string description = textBoxDescription.Text;

                // Parse textbox values to integers or default to 0 if empty
                int uniformQuantity = string.IsNullOrEmpty(textBoxUniformQuantity.Text) ? 0 : int.Parse(textBoxUniformQuantity.Text);
                int jerseyQuantity = string.IsNullOrEmpty(textBoxJerseyQuantity.Text) ? 0 : int.Parse(textBoxJerseyQuantity.Text);
                int printingQuantity = string.IsNullOrEmpty(textBoxPrintingQuantity.Text) ? 0 : int.Parse(textBoxPrintingQuantity.Text);
                int othersQuantity = string.IsNullOrEmpty(textBoxOthersQuantity.Text) ? 0 : int.Parse(textBoxOthersQuantity.Text);

                // Get current date
                DateTime currentDate = DateTime.Now;

                // Insert customer information into respective tables and retrieve generated IDs
                int customerId = databaseClass.InsertIntoCustomersAndGetId(fullName, address);
                int contactId = databaseClass.InsertIntoCustomerContactsAndGetId(customerId, email, contact);
                int descriptionId = databaseClass.InsertIntoCustomerDescriptionsAndGetId(customerId, description);
                int orderId = databaseClass.InsertIntoCustomerOrdersAndGetId(customerId, uniformQuantity, jerseyQuantity, printingQuantity, othersQuantity);
                int appointmentId = databaseClass.InsertIntoAppointmentSubmitAndGetId(customerId, currentDate);

                if (orderId != 0)
                {
                    await errorClass.ShowErrorForm("Wait for the response.", this);

                    // Clear all fields after successful submission
                    textBoxFullName.Clear();
                    textBoxAddress.Clear();
                    textBoxEmail.Clear();
                    textBoxContact.Clear();
                    textBoxDescription.Clear();

                    // Uncheck checkboxes
                    checkBoxUniform.Checked = false;
                    checkBoxJersey.Checked = false;
                    checkBoxPrinting.Checked = false;
                    checkBoxOthers.Checked = false;

                    // Reset associated textboxes to "" for all checkboxes
                    textBoxUniformQuantity.Text = "";
                    textBoxJerseyQuantity.Text = "";
                    textBoxPrintingQuantity.Text = "";
                    textBoxOthersQuantity.Text = "";
                }
                else
                {
                    await errorClass.ShowErrorForm("        Try Again!", this);
                }
            }
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

        private async void buttonEmail_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            linkClass.WebsiteLink("https://mail.google.com/mail/u/0/#inbox?compose=GTvVlcSGMTDsQBhRbQNnWRCgkPZjGLhhlVDbSZrNMXxSdwgBRVMLMVvNscjwSTjCQpBTFlmXgfMQb");
        }

        private void HandleCheckBoxCheckedChanged(CheckBox checkBox, TextBox associatedTextBox)
        {
            if (checkBox.Checked)
            {
                associatedTextBox.Enabled = true;
                associatedTextBox.Text = "1"; // Set text to "1" when checkbox is checked
                associatedTextBox.Focus();
            }
            else
            {
                associatedTextBox.Enabled = false;
                associatedTextBox.Text = "0"; // Set text to "0" when checkbox is unchecked
            }
        }

        private bool IsValidNumericInput(TextBox textBox)
        {
            // Check if the textbox has a valid numeric input greater than zero
            if (int.TryParse(textBox.Text, out int value) && value > 0)
            {
                return true;
            }
            return false;
        }

        // Check Box
        private void checkBoxUniform_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxCheckedChanged(checkBoxUniform, textBoxUniformQuantity);
        }

        private void checkBoxJersey_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxCheckedChanged(checkBoxJersey, textBoxJerseyQuantity);
        }

        private void checkBoxPrinting_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxCheckedChanged(checkBoxPrinting, textBoxPrintingQuantity);
        }

        private void checkBoxOthers_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxCheckedChanged(checkBoxOthers, textBoxOthersQuantity);
        }

        // Key Press
        private void textBoxUniformQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!checkBoxUniform.Checked && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress key input if the checkbox is unchecked
            }
        }

        private void textBoxJerseyQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!checkBoxJersey.Checked && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBoxPrintingQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!checkBoxPrinting.Checked && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxOthersQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!checkBoxOthers.Checked && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}