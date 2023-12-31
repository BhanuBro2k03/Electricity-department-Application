using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Department_application
{
    public partial class displayWindow : Form
    {
        public displayWindow()
        {
            InitializeComponent();
        }

        public displayWindow(string customer_name,double bill_amount,double tax_amount,double total_bill_amount)
        {
            InitializeComponent();
            label6.Text = customer_name;
            label7.Text = Convert.ToString(bill_amount);
            label8.Text = Convert.ToString(tax_amount);
            label9.Text = Convert.ToString(total_bill_amount);

        }
    }
}
