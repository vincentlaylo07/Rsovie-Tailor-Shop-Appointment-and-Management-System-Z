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
    public partial class DashboardForm : Form
    {
        private Classes.DatabaseClass databaseClass;
        private Classes.LinkClass linkClass;
        private Classes.PlaySound playSound;
        public DashboardForm()
        {
            InitializeComponent();

            databaseClass = new Classes.DatabaseClass();
            linkClass = new Classes.LinkClass();
            playSound = new Classes.PlaySound();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadChartDataIncome();
            LoadChartDataCustomerCount();
        }

        private void LoadChartDataIncome()
        {
            DataTable chartData = databaseClass.ChartDataTransaction();

            chart.Series[0].XValueMember = "Year";
            chart.Series[0].YValueMembers = "Cost";

            chart.Series[0].IsValueShownAsLabel = true;

            chart.DataSource = chartData;
            chart.DataBind();
        }

        private void LoadChartDataCustomerCount()
        {
            DataTable chartData = databaseClass.FinishedCustomerCountByYear();

            chartCustomer.Series[0].XValueMember = "Year";
            chartCustomer.Series[0].YValueMembers = "CustomerCount";

            chartCustomer.Series[0].IsValueShownAsLabel = true;

            chartCustomer.DataSource = chartData;
            chartCustomer.DataBind();
        }

        private async void buttonEmail_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            linkClass.WebsiteLink("https://mail.google.com/mail/u/0/#inbox?compose=new");
        }
    }
}
