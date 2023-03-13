
namespace Discount_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalPkgLabel = new System.Windows.Forms.Label();
            this.discountPctLabel = new System.Windows.Forms.Label();
            this.discountAmtLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.displayDiscountPct = new System.Windows.Forms.TextBox();
            this.displayDiscountAmt = new System.Windows.Forms.TextBox();
            this.displayTotal = new System.Windows.Forms.TextBox();
            this.inputTotalPkg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // totalPkgLabel
            // 
            this.totalPkgLabel.AutoSize = true;
            this.totalPkgLabel.Location = new System.Drawing.Point(23, 22);
            this.totalPkgLabel.Name = "totalPkgLabel";
            this.totalPkgLabel.Size = new System.Drawing.Size(271, 17);
            this.totalPkgLabel.TabIndex = 0;
            this.totalPkgLabel.Text = "Number of software packages purchased:";
            // 
            // discountPctLabel
            // 
            this.discountPctLabel.AutoSize = true;
            this.discountPctLabel.Location = new System.Drawing.Point(125, 113);
            this.discountPctLabel.Name = "discountPctLabel";
            this.discountPctLabel.Size = new System.Drawing.Size(120, 17);
            this.discountPctLabel.TabIndex = 1;
            this.discountPctLabel.Text = "Discount Percent:";
            this.discountPctLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // discountAmtLabel
            // 
            this.discountAmtLabel.AutoSize = true;
            this.discountAmtLabel.Location = new System.Drawing.Point(44, 158);
            this.discountAmtLabel.Name = "discountAmtLabel";
            this.discountAmtLabel.Size = new System.Drawing.Size(201, 17);
            this.discountAmtLabel.TabIndex = 2;
            this.discountAmtLabel.Text = "Discount Amount - You Saved:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(167, 202);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(78, 17);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Final Price:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(195, 57);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(99, 35);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // displayDiscountPct
            // 
            this.displayDiscountPct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayDiscountPct.Location = new System.Drawing.Point(283, 108);
            this.displayDiscountPct.Name = "displayDiscountPct";
            this.displayDiscountPct.Size = new System.Drawing.Size(100, 22);
            this.displayDiscountPct.TabIndex = 5;
            // 
            // displayDiscountAmt
            // 
            this.displayDiscountAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayDiscountAmt.Location = new System.Drawing.Point(283, 153);
            this.displayDiscountAmt.Name = "displayDiscountAmt";
            this.displayDiscountAmt.Size = new System.Drawing.Size(100, 22);
            this.displayDiscountAmt.TabIndex = 6;
            // 
            // displayTotal
            // 
            this.displayTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTotal.Location = new System.Drawing.Point(283, 197);
            this.displayTotal.Name = "displayTotal";
            this.displayTotal.Size = new System.Drawing.Size(100, 22);
            this.displayTotal.TabIndex = 7;
            // 
            // inputTotalPkg
            // 
            this.inputTotalPkg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTotalPkg.Location = new System.Drawing.Point(325, 22);
            this.inputTotalPkg.Name = "inputTotalPkg";
            this.inputTotalPkg.Size = new System.Drawing.Size(100, 22);
            this.inputTotalPkg.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 236);
            this.Controls.Add(this.inputTotalPkg);
            this.Controls.Add(this.displayTotal);
            this.Controls.Add(this.displayDiscountAmt);
            this.Controls.Add(this.displayDiscountPct);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.discountAmtLabel);
            this.Controls.Add(this.discountPctLabel);
            this.Controls.Add(this.totalPkgLabel);
            this.Name = "Form1";
            this.Text = "Discount Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalPkgLabel;
        private System.Windows.Forms.Label discountPctLabel;
        private System.Windows.Forms.Label discountAmtLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox displayDiscountPct;
        private System.Windows.Forms.TextBox displayDiscountAmt;
        private System.Windows.Forms.TextBox displayTotal;
        private System.Windows.Forms.TextBox inputTotalPkg;
    }
}

