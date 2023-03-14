
namespace Distance_Calculator
{
    partial class DistanceCalculator
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
            this.speedLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.speedInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.distanceOutputList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(31, 18);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(152, 17);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Vehicle Speed in MPH:";
            this.speedLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(73, 46);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(110, 17);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Hours Traveled:";
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(196, 46);
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(100, 22);
            this.timeInput.TabIndex = 2;
            // 
            // speedInput
            // 
            this.speedInput.Location = new System.Drawing.Point(196, 18);
            this.speedInput.Name = "speedInput";
            this.speedInput.Size = new System.Drawing.Size(100, 22);
            this.speedInput.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(76, 276);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(80, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(196, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // distanceOutputList
            // 
            this.distanceOutputList.FormattingEnabled = true;
            this.distanceOutputList.ItemHeight = 16;
            this.distanceOutputList.Location = new System.Drawing.Point(34, 102);
            this.distanceOutputList.Name = "distanceOutputList";
            this.distanceOutputList.Size = new System.Drawing.Size(262, 148);
            this.distanceOutputList.TabIndex = 7;
            // 
            // DistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 311);
            this.Controls.Add(this.distanceOutputList);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.speedInput);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.speedLabel);
            this.Name = "DistanceCalculator";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.TextBox speedInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox distanceOutputList;
    }
}

