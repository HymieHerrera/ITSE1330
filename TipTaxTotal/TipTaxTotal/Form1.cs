using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTaxTotal
{
    public partial class TipTaxTotal : Form
    {
        public TipTaxTotal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal baseAmt, tax, tip, totalAmt;
            try
            {
                baseAmt = decimal.Parse(inputBase.Text);
                tip = baseAmt * 0.1m;
                tax = baseAmt * 0.0825m;
                totalAmt = baseAmt + tip + tax;
                outputTip.Text = tip.ToString("c");
                outputTax.Text = tax.ToString("c");
                outputTotal.Text = totalAmt.ToString("c");
            }
            catch(FormatException)
            {
                inputBase.Text = "";
                outputTip.Text = "";
                outputTax.Text = "";
                outputTotal.Text = "";
                MessageBox.Show("Invalid input. Input a number value");
            }
        }

        private void labelTip_Click(object sender, EventArgs e)
        {

        }
    }
}
