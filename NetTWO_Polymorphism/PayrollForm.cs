using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTWO_Polymorphism
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void calcPayrollBtn_Click(object sender, EventArgs e)
        {
            int hours_worked = Convert.ToInt32(hoursTxtBox.Text);
            double pay_rate = Convert.ToDouble(payRateTxtBox.Text);
            int sales = Convert.ToInt32(salesTxtBox.Text);
            Hourly_Person hr = new Hourly_Person(hours_worked, pay_rate);
            Commission_Person cm = new Commission_Person(sales);
            hourlyPersonTxtBox.Text = hr.Print_Pay();
            comPersonTextBox.Text = cm.Print_Pay();
        }
    }
}
