using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Department_application
{
    internal class calculateBillAmount
    {
        private string customer_name;
        private double unit_consumed;
        private double bill_amount;
        private double tax_amount;
        private double total_bill_amount;
        public string CustomerName
        {
            get { return customer_name; }
            set { customer_name = value;}
        }

        public double UnitConsumed
        {
            get { return unit_consumed; }
            set { unit_consumed = value;}
        }
        public double BillAmount
        {
            get { return bill_amount; }
            set { bill_amount = value; }
        }

        public double TaxAmount
        {
            get { return tax_amount; }
            set { tax_amount = value; }
        }
        public double TotalBillAmount
        {
            get { return total_bill_amount; }
            set { total_bill_amount = value; }
        }

        public calculateBillAmount()
        {
            customer_name = string.Empty;
            unit_consumed = 0;
            bill_amount = 0;
            tax_amount = 0;
            total_bill_amount = 0;

        }

        public void calculate()
        {

            double unit_price = 0.00;  
            double tax_rate_total = 0.00;

            if (unit_consumed > 100)
            {
                unit_price = 30.00;
                tax_rate_total = 0.05;
            }
            else if( unit_consumed <= 100 && unit_consumed > 50)
            {
                unit_price = 20.00;
                tax_rate_total = 0.03;
            }
            else if(unit_consumed < 50)
            {
                unit_price = 10.00;
                tax_rate_total = 0.02;
            }

            bill_amount = unit_consumed * unit_price;
            tax_amount = bill_amount * tax_rate_total;
            total_bill_amount = bill_amount + tax_amount;


        }

    }
}
