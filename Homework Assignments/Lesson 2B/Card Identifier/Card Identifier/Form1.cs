using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cardid.Text = "Ace of Clubs";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cardid.Text = "Ace of Diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cardid.Text = "Ace of Spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cardid.Text = "Ace of Hearts";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cardid.Text = "Joker";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
