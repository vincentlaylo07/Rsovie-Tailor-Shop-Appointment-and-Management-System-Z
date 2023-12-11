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
    public partial class ErrorHandlerForm : Form
    {
        public ErrorHandlerForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoading.Width += 15;

            if(panelLoading.Width >= 2000) 
            {
                timer1.Stop();
            }
        }
    }
}
