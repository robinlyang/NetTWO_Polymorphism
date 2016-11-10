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

        public void Print_Pay()
        {
            //call Get_Pay
        }

        public double Get_Pay()
        {
            double net_pay = 0.0;

            return net_pay;
        }

        public double Get_Tax(double total_pay)
        {
            return total_pay * .3;
        }
    }
}
