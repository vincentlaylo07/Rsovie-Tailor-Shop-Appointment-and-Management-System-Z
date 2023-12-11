using System.Threading;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z
{
    public partial class SplashScreen : Form
    {
        Thread thread;
        public SplashScreen()
        {
            InitializeComponent();
            circularProgressBar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar.Value += 1;

            if (circularProgressBar.Value == 100)
            {
                timer1.Enabled = false;
                this.Dispose();
                thread = new Thread(OpenForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void OpenForm(object? obj)
        {
            Application.Run(new MainForms.ChoiceForm());
        }
    }
}