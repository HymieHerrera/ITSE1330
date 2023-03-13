using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discount_Calculator
{
    public partial class Form1 : Form
    {
        //constant for Retail Price
        const decimal retailPrice = 99.00M;
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // parse input quantity as integer
            if (!int.TryParse(inputTotalPkg.Text, out int quantity))
            {
                // value error exception message xox
                MessageBox.Show("Invalid Data");
                displayDiscountPct.Text = "";
                displayDiscountAmt.Text = "";
                displayTotal.Text = "";
                return;
            }

            // parse if input quantity is out of range
            if (quantity < 1 || quantity > 150)
            {
                // value error Exception message box
                MessageBox.Show("Out of Range");
                displayDiscountPct.Text = "";
                displayDiscountAmt.Text = "";
                displayTotal.Text = "";
                return;
            }

            // if-else if statements to determine discount percent
            decimal discountPercent;
            if (quantity >= 10 && quantity <= 19)
            {
                discountPercent = 0.20M;
            }
            else if (quantity >= 20 && quantity <= 49)
            {
                discountPercent = 0.30M;
            }
            else if (quantity >= 50 && quantity <= 150)
            {
                discountPercent = 0.40M;
            }
            else if (quantity >= 100 && quantity <= 150)
            {
                discountPercent = 0.40M;
            }
            else
            {
                discountPercent = 0.00M;
            }

            // subtotal calculation
            decimal subtotal = quantity * retailPrice;

            // calculate discount
            decimal discountAmount = subtotal * discountPercent;

            // convert decimal values to whole numbers if missing values after decimal. (I know the assignment said to make the variables all decimals but this is still in the spirit)
            string discountAmountFormat = discountAmount % 1 == 0 ? "{0:C0}" : "{0:C}";

            // total amount calcuation
            decimal total = subtotal - discountAmount;

            string totalFormat = total % 1 == 0 ? "{0:C0}" : "{0:C}";

            // display outputs
            displayDiscountPct.Text = discountPercent.ToString("0");
            displayDiscountAmt.Text = string.Format(discountAmountFormat, discountAmount);
            displayTotal.Text = string.Format(totalFormat, total);
        }

    }
}

