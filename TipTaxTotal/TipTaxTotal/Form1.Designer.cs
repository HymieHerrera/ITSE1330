
namespace TipTaxTotal
{
    partial class TipTaxTotal
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
            this.labelBase = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.outputTip = new System.Windows.Forms.Label();
            this.outputTax = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.inputBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(34, 24);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(106, 20);
            this.labelBase.TabIndex = 0;
            this.labelBase.Text = "Food Charge:";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(137, 88);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(109, 20);
            this.labelTip.TabIndex = 1;
            this.labelTip.Text = "Tip Amount is:";
            this.labelTip.Click += new System.EventHandler(this.labelTip_Click);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(193, 143);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(53, 20);
            this.labelTax.TabIndex = 2;
            this.labelTax.Text = "Tax is:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(183, 195);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(63, 20);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total is:";
            // 
            // outputTip
            // 
            this.outputTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTip.Location = new System.Drawing.Point(282, 88);
            this.outputTip.Name = "outputTip";
            this.outputTip.Size = new System.Drawing.Size(100, 20);
            this.outputTip.TabIndex = 4;
            this.outputTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputTax
            // 
            this.outputTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTax.Location = new System.Drawing.Point(282, 143);
            this.outputTax.Name = "outputTax";
            this.outputTax.Size = new System.Drawing.Size(100, 20);
            this.outputTax.TabIndex = 5;
            this.outputTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputTotal
            // 
            this.outputTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTotal.Location = new System.Drawing.Point(282, 195);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(100, 20);
            this.outputTotal.TabIndex = 6;
            this.outputTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(160, 302);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(238, 43);
            this.buttonCalc.TabIndex = 7;
            this.buttonCalc.Text = "Calculate Tip, Tax and Total";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBase
            // 
            this.inputBase.Location = new System.Drawing.Point(146, 18);
            this.inputBase.Name = "inputBase";
            this.inputBase.Size = new System.Drawing.Size(100, 26);
            this.inputBase.TabIndex = 8;
            // 
            // TipTaxTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 384);
            this.Controls.Add(this.inputBase);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.outputTotal);
            this.Controls.Add(this.outputTax);
            this.Controls.Add(this.outputTip);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelBase);
            this.Name = "TipTaxTotal";
            this.Text = "Tip Tax Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label outputTip;
        private System.Windows.Forms.Label outputTax;
        private System.Windows.Forms.Label outputTotal;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox inputBase;
    }
}

