using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the minimum and maximum values for the gauge
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            // Set the initial value of the gauge
            progressBar1.Value = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example: Increase the gauge value
            progressBar1.Value -= 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Example: Decrease the gauge value
            progressBar1.Value += 10;
        }
    }
}
