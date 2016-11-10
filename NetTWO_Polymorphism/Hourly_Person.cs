using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTWO_Polymorphism
{
    class Hourly_Person
    {
        private int hours_worked;
        private double pay_rate;

        public Hourly_Person()
        {

        }

        public Hourly_Person(int hours_worked, double pay_rate)
        {
            this.hours_worked = hours_worked;
            this.pay_rate = pay_rate;
        }

        ~Hourly_Person()
        {

        }

        public string Print_Pay()
        {
            return Get_Pay().ToString("$#,#00.00");
        }

        public virtual double Get_Pay()
        {
            double net_pay = 0.0;
            int regular_hours = 0;
            int overtime_hours = 0;
            double regular_pay = 0.0;
            double overtime_pay = 0.0;
            double total_pay = 0.0;
            int total_hours = this.hours_worked;
            if(total_hours >= 40)
            {
                regular_hours = total_hours - 40;
                overtime_hours = total_hours - regular_hours;
                regular_pay = regular_hours * this.pay_rate;
                overtime_pay = overtime_hours * this.pay_rate * 1.5;
                total_pay = regular_pay + overtime_pay;
            }
            if(total_hours <= 39)
            {
                regular_hours = total_hours;
                total_pay = regular_hours * this.pay_rate;
            }
            net_pay = total_pay - Get_Tax(total_pay);
            return net_pay;
        }

        public double Get_Tax(double total_pay)
        {
            return total_pay * .3;
        }
    }
}
