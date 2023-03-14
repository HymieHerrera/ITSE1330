using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class DistanceCalculator : Form
    {
        public DistanceCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int speed;
            int time;
            int distance;
            distanceOutputList.Items.Clear();

            if (int.TryParse(speedInput.Text, out speed) && int.TryParse(timeInput.Text, out time))
            {
                for (int i = 1; i <= time; i++)
                {
                     distance = speed * i;
                    distanceOutputList.Items.Add($"After hour {i} the distance is {distance} miles");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid speed and time values.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
