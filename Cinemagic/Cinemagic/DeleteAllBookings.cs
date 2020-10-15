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

namespace RandomProj
{
    public partial class DeleteAllBookings : Form
    {
        DataTable dt = new DataTable();
        Bookings_Movies bookings = new Bookings_Movies();

        public DeleteAllBookings()
        {
            InitializeComponent();
        }

        private void btnDelete_AllBookings_Click(object sender, EventArgs e)
        {
            Main cinema = new Main();
            string select_movies = "SELECT * FROM BOOKING WHERE Customer_ID = " + spinDeleteAll_Bookings.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_all = "DELETE FROM BOOKING WHERE Customer_ID = " + spinDeleteAll_Bookings.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_movies, cinema.conn);
                cmd = new SqlCommand(delete_all, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    DialogResult confirm_deletions = MessageBox.Show($"Bookings with Customer_ID {spinDeleteAll_Bookings.Value} deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (confirm_deletions == DialogResult.OK)
                    {
                        this.Hide();
                        bookings.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Customer_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete selected records...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_To_Bookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookings.ShowDialog();
        }
    }
}
