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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateBillAmount calcBillAmo = new calculateBillAmount();
            calcBillAmo.CustomerName = textBox1.Text;
            calcBillAmo.UnitConsumed = Convert.ToDouble(textBox2.Text);

            calcBillAmo.calculate();

            displayWindow diwin = new displayWindow(calcBillAmo.CustomerName,calcBillAmo.BillAmount,calcBillAmo.TaxAmount,calcBillAmo.TotalBillAmount);
            diwin.Show();
            this.Hide();

        }
    }
}
