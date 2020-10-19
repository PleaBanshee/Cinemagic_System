using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SplashScreen;

namespace SplashScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            lblHeading.BackColor = Color.Transparent;
            lblHeading.ForeColor = Color.LimeGreen;
            lblLoading.ForeColor = Color.LimeGreen;
            lblLoading.BackColor = Color.Transparent;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            lblLoading.Text = (progressBar1.Value).ToString() + "%";
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }
    }
}
