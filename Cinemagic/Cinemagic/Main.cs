using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RandomProj;
using Cinemagic;
using System.Diagnostics;

namespace RandomProj
{
    public partial class Main : Form
    {
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CinemagicDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            toolTipHelp.SetToolTip(btnHelp, "When the window opens, select Help.pdf");
            btnHelp.ForeColor = Color.Blue;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.ForeColor = Color.Yellow;
            lblWelcome.Text = $"Welcome to the Cinemagic Booking System! {'\n'}Make a booking or commit a snack transaction.{'\n'}The Cinemagic System makes it easier" +
            $"to maintain{'\n'} bookings, customers, movies as well as snacks{'\n'} and their transaction details.{'\n'} Cinemagic takes process automation to a{'\n'} whole new level!";
            btnMake_A_Booking.ForeColor = Color.Blue;
            btnCommitSale.ForeColor = Color.Blue;
            btnExit.ForeColor = Color.Red;
            this.BackgroundImage = Cinemagic.Properties.Resources.Main_Wallpaper;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Could not connect to database","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCommitSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Snacks main_snacks = new Main_Snacks();
            main_snacks.ShowDialog();
        }

        private void btnMake_A_Booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookings_Movies booking = new Bookings_Movies();
            booking.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit_system = MessageBox.Show("Are you sure you want to exit?","CINEMAGIC",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (exit_system == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }
    }
}
