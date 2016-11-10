using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTWO_Polymorphism
{
    class Commission_Person:Hourly_Person
    {
        private int sales;

        public Commission_Person(int sales)
        {
            this.sales = sales;
        }

        public override double Get_Pay()
        {
            double net_pay = 0.0;
            double total_pay = this.sales * 0.03;
            net_pay = total_pay - Get_Tax(total_pay);
            return net_pay;
        }
    }
}
