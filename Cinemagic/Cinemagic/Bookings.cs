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
using System.Text.RegularExpressions;

namespace RandomProj
{
    public partial class Bookings_Movies : Form
    {
        private string connection;
        private SqlCommand command;
        private DataTable dt = new DataTable();
        private SqlDataReader dr;

        public Bookings_Movies()
        {
            InitializeComponent();
        }

        private void SetColors()
        {
            foreach (GroupBox box in this.tbBookings_GUI.Controls)
            {
                box.BackColor = Color.LightSkyBlue;
            }
            groupDeleteMovies.BackColor = Color.DodgerBlue;
            groupMaintain_Bookings.BackColor = Color.DodgerBlue;
            groupMaintain_Customers.BackColor = Color.DodgerBlue;
            tbBookings_GUI.BackColor = Color.CadetBlue;
            foreach (GroupBox box in this.tbMovies_Control.Controls)
            {
                box.BackColor = Color.LightSkyBlue;
            }
            groupMaintain_Genres.BackColor = Color.DodgerBlue;
            groupMaintain_Movies.BackColor = Color.DodgerBlue;
            tbMovies_Control.BackColor = Color.CadetBlue;
        }

        private void Bookings_Movies_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Cinemagic.Properties.Resources.System_Light;
            SetColors();
            dbBookings.Font = new Font(DefaultFont, FontStyle.Regular);
            dbBookings.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            dbCustomers.Font = new Font(DefaultFont, FontStyle.Regular);
            dbCustomers.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            dbMovies.Font = new Font(DefaultFont, FontStyle.Regular);
            dbMovies.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            dbGenres.Font = new Font(DefaultFont, FontStyle.Regular);
            dbGenres.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            dateRelease.Value = DateTime.Now;
            dateWithdrawal.Value = DateTime.Now.AddDays(7);
            this.Size = new Size(1050, 1000);
            toolTipBack.SetToolTip(btnMain,"Go back to Cinemagic");
            DisplayCustomers();
            DisplayBookings();
            DisplayGenres();
            DisplayMovies();
            cmbAge.Items.Add("General Audiences");
            cmbAge.Items.Add("PG-13");
            cmbAge.Items.Add("PG");
            cmbAge.Items.Add("Restricted Under 17");
            cmbAge.Items.Add("NC-17");
        }

        #region BOOKINGS

        private void RenameCustomerColumns()
        {
            dbCustomers.Columns[1].HeaderCell.Value = "Name";
            dbCustomers.Columns[2].HeaderCell.Value = "Surname";
            dbCustomers.Columns[3].HeaderCell.Value = "Cellphone Number";
            dbCustomers.Columns[4].HeaderCell.Value = "Email";
        }

        private void RenameBookingColumns()
        {
            dbBookings.Columns[3].HeaderCell.Value = "Total Cost for Tickets (R)";
            dbBookings.Columns[4].HeaderCell.Value = "Number of seats";
            dbBookings.Columns[5].HeaderCell.Value = "Date";
        }

        public void DisplayBookings()
        {
            dbBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_movies = "SELECT * FROM BOOKING";
            cinema.com = new SqlCommand(select_movies, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_movies, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Bookings");
            dbBookings.DataSource = cinema.ds;
            dbBookings.DataMember = "Bookings";
            RenameBookingColumns();
            for (int i = 0; i < this.dbBookings.Columns.Count; i++)
            {
                if (i == 3)
                {
                    this.dbBookings.Columns[i].DefaultCellStyle.Format = "0.00";
                }
            }
            cinema.conn.Close();
        }

        private void DisplayCustomers()
        {
            dbCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_customers = "SELECT * FROM CUSTOMER";
            cinema.com = new SqlCommand(select_customers, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_customers, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Customers");
            dbCustomers.DataSource = cinema.ds;
            dbCustomers.DataMember = "Customers";
            RenameCustomerColumns();
            cinema.conn.Close();  
        }

        private bool CheckEmptyBookingInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(txtTicket_Total.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        private bool CheckEmptyCustomerInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text) || String.IsNullOrEmpty(txtPhoneNum.Text) || String.IsNullOrEmpty(txtEmail.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        private void AddCustomers()
        {
            if (CheckEmptyCustomerInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                connection = cinema.constr;
                try
                {
                    string insert_customers = @"INSERT INTO CUSTOMER VALUES(@Customer_Name,@Customer_Surname,@Customer_Phone,@Customer_Email)";
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    cinema.com = new SqlCommand(insert_customers, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@Customer_Name", txtName.Text);
                    cinema.com.Parameters.AddWithValue("@Customer_Surname", txtSurname.Text);
                    cinema.com.Parameters.AddWithValue("@Customer_Phone", txtPhoneNum.Text);
                    cinema.com.Parameters.AddWithValue("@Customer_Email", txtEmail.Text);
                    cinema.com.ExecuteNonQuery();
                    MessageBox.Show("Customer has been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cinema.conn.Close();
                    DisplayCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Failed to add customer... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddBookings()
        {
            if (CheckEmptyBookingInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                connection = cinema.constr;
                try
                {
                    string insert_bookings = @"INSERT INTO BOOKING VALUES(@Movie_ID,@Customer_ID,@Total_TicketCost,@NumberOfSeats,@Tickets_SaleDate)";
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    cinema.com = new SqlCommand(insert_bookings, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@Movie_ID", spinMovieID.Value);
                    cinema.com.Parameters.AddWithValue("@Customer_ID", spinCustID.Value);
                    cinema.com.Parameters.AddWithValue("@Total_TicketCost", decimal.Parse(txtTicket_Total.Text));
                    cinema.com.Parameters.AddWithValue("@NumberOfSeats", spinNumOfSeats.Value);
                    cinema.com.Parameters.AddWithValue("@Tickets_SaleDate", DateTime.Now.ToString("yyyy/MM/dd"));
                    cinema.com.ExecuteNonQuery();
                    MessageBox.Show("Booking has been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cinema.conn.Close();
                    DisplayBookings();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ticket amount must contain a comma as currency seperator... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Failed to add booking... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FillCustomers()
        {
            Main cinema = new Main();
            string select_customers = "SELECT * FROM CUSTOMER WHERE Customer_ID = " + spinFill_Customer.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_customers, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr.GetValue(1).ToString();
                    txtSurname.Text = dr.GetValue(2).ToString();
                    txtPhoneNum.Text= dr.GetValue(3).ToString();
                    txtEmail.Text = dr.GetValue(4).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Customer_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to fill inputs with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillBookings()
        {
            Main cinema = new Main();
            string select_bookings = "SELECT * FROM BOOKING WHERE Booking_ID = " + spinFill_BookingID.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_bookings, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    spinMovieID.Value = int.Parse(dr.GetValue(1).ToString());
                    spinCustID.Value = int.Parse(dr.GetValue(2).ToString());
                    txtTicket_Total.Text = dr.GetValue(3).ToString();
                    spinNumOfSeats.Value = int.Parse(dr.GetValue(4).ToString());
                }
                else
                {
                    MessageBox.Show("Please enter a valid Booking_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to fill inputs with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCustomers()
        {
            Main cinema = new Main();
            cinema.conn = new SqlConnection(connection);
            string select_customers = "SELECT * FROM CUSTOMER WHERE Customer_ID = " + spinFill_Customer.Value.ToString() + ";";
            string update_customers = $"UPDATE CUSTOMER SET Customer_Name = '{txtName.Text}', Customer_Surname = '{txtSurname.Text}', Customer_Phone = '{txtPhoneNum.Text}'," +
            $"Customer_Email = '{txtEmail.Text}' WHERE Customer_ID = {spinFill_Customer.Value.ToString()}";
            cinema.com = new SqlCommand(update_customers, cinema.conn);
            command = new SqlCommand(select_customers, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.adap.SelectCommand = command;
            cinema.adap.Fill(dt);
            try
            {
                cinema.conn.Open();
                if (dt.Rows.Count > 0)
                {
                    cinema.com.ExecuteNonQuery();
                    cinema.conn.Close();
                    DisplayCustomers();
                    MessageBox.Show("Customer has been updated successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The selected Customer_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " Failed to update the customer...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBookings()
        {
            Main cinema = new Main();
            cinema.conn = new SqlConnection(connection);
            string select_bookings = "SELECT * FROM BOOKING WHERE Booking_ID = " + spinFill_BookingID.Value.ToString() + ";";
            string update_bookings = $"UPDATE BOOKING SET Movie_ID = '{spinMovieID.Value}', Customer_ID = {spinCustID.Value}, " +
            $"Total_TicketCost =  CAST(REPLACE('{txtTicket_Total.Text}', ',', '.') AS DECIMAL(10, 2)), NumberOfSeats = {spinNumOfSeats.Value}"+
            $"WHERE Booking_ID = {spinFill_BookingID.Value.ToString()}";
            cinema.com = new SqlCommand(update_bookings, cinema.conn);
            command = new SqlCommand(select_bookings, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.adap.SelectCommand = command;
            cinema.adap.Fill(dt);
            try
            {
                cinema.conn.Open();
                if (dt.Rows.Count > 0)
                {
                    cinema.com.ExecuteNonQuery();
                    cinema.conn.Close();
                    DisplayBookings();
                    MessageBox.Show("Booking has been updated successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The selected Booking_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ticket amount must contain a comma as currency seperator... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " Failed to update booking...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCustomer()
        {
            Main cinema = new Main();
            string select_customer = "SELECT * FROM CUSTOMER WHERE Customer_ID = " + spinDel_CustID.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_customer = "DELETE FROM CUSTOMER WHERE Customer_ID = " + spinDel_CustID.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_customer, cinema.conn);
                cmd = new SqlCommand(delete_customer, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Customer was deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayCustomers();
                }
                else
                {
                    MessageBox.Show("Customer_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sql_err)
            {
                int err_num = sql_err.Number;
                if (err_num == 547)
                {
                    MessageBox.Show($"Failed to delete record... Please click on DELETE ALL BOOKINGS button and delete all records in Bookings with Customer_ID {spinDel_CustID.Value}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(sql_err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBookings()
        {
            Main cinema = new Main();
            string select_booking = "SELECT * FROM BOOKING WHERE Booking_ID = " + spinDel_Booking.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_booking = "DELETE FROM BOOKING WHERE Booking_ID = " + spinDel_Booking.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_booking, cinema.conn);
                cmd = new SqlCommand(delete_booking, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Booking was deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayBookings();
                }
                else
                {
                    MessageBox.Show("Booking_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Customer_Click(object sender, EventArgs e)
        {
            AddCustomers();
        }

        private void btnAdd_Booking_Click(object sender, EventArgs e)
        {
            AddBookings();
        }

        private void btnFill_Bookings_Click(object sender, EventArgs e)
        {
            FillBookings();
        }

        private void btnFill_Customers_Click(object sender, EventArgs e)
        {
            FillCustomers();
        }

        private void btnUpdate_Customer_Click(object sender, EventArgs e)
        {
            UpdateCustomers();
        }

        private void btnUpdate_Booking_Click(object sender, EventArgs e)
        {
            UpdateBookings();
        }

        private void btnDelete_Booking_Click(object sender, EventArgs e)
        {
            DeleteBookings();
        }

        private void btnDelete_Customers_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void txtTicket_Total_Validated(object sender, EventArgs e)
        {
            decimal total;
            if (!decimal.TryParse(txtTicket_Total.Text, out total))
            {
                MessageBox.Show("Must enter a decimal value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhoneNum_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhoneNum.Text.Length != 10)
            {
                MessageBox.Show("Phone number must be ten digits long", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex mRegxExpression;
            if (txtEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.)
                {3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("You entered an invalid email address", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Any(char.IsDigit) || !txtName.Text.Any(ch => Char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Customer Name cannot contain numbers or special characters!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (txtSurname.Text.Any(char.IsDigit) || !txtSurname.Text.Any(ch => Char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Customer Surname cannot contain numbers or special characters!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region MOVIES

        private void RenameMovieColumns()
        {
            dbMovies.Columns[1].HeaderCell.Value = "Movie";
            dbMovies.Columns[3].HeaderCell.Value = "Duration";
            dbMovies.Columns[4].HeaderCell.Value = "Age Restriction";
            dbMovies.Columns[5].HeaderCell.Value = "Release Date";
            dbMovies.Columns[6].HeaderCell.Value = "Withdrawal Date";

        }

        private void RenameGenreColumns()
        {
            dbGenres.Columns[1].HeaderCell.Value = "Description";
        }

        private void DisplayMovies()
        {
            dbMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_snacks = "SELECT * FROM MOVIE";
            cinema.com = new SqlCommand(select_snacks, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_snacks, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Movies");
            dbMovies.DataSource = cinema.ds;
            dbMovies.DataMember = "Movies";
            RenameMovieColumns();
            cinema.conn.Close();
        }

        private void DisplayGenres()
        {
            dbGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_snacks = "SELECT * FROM GENRE";
            cinema.com = new SqlCommand(select_snacks, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_snacks, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Genres");
            dbGenres.DataSource = cinema.ds;
            dbGenres.DataMember = "Genres";
            RenameGenreColumns();
            cinema.conn.Close();
        }

        private bool CheckEmptyMovieInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(txtMovie.Text) || String.IsNullOrEmpty(txtDuration.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        private bool CheckEmptyGenreInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(txtDescription.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        private void AddGenres()
        {
            if (CheckEmptyGenreInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                connection = cinema.constr;
                try
                {
                    string insert_genres = @"INSERT INTO GENRE VALUES(@Genre_Description)";
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    cinema.com = new SqlCommand(insert_genres, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@Genre_Description", txtDescription.Text);
                    cinema.com.ExecuteNonQuery();
                    MessageBox.Show("Movie Genre has been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cinema.conn.Close();
                    DisplayGenres();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Failed to add Genre... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddMovies()
        {
            if (CheckEmptyMovieInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                connection = cinema.constr;
                try
                {
                    string insert_movies = @"INSERT INTO MOVIE VALUES(@Movie_Name,@Genre_ID,@Movie_Duration,@Age_Restriction,@Release_Date,@Withdrawal_Date)";
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    cinema.com = new SqlCommand(insert_movies, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@Movie_Name", txtMovie.Text);
                    cinema.com.Parameters.AddWithValue("@Genre_ID", spinGenre_ID.Value);
                    cinema.com.Parameters.AddWithValue("@Movie_Duration", DateTime.Parse(txtDuration.Text).ToString("HH:mm:ss"));
                    cinema.com.Parameters.AddWithValue("@Age_Restriction", cmbAge.SelectedItem.ToString());
                    cinema.com.Parameters.AddWithValue("@Release_Date", dateRelease.Value.ToString("yyyy/MM/dd"));
                    cinema.com.Parameters.AddWithValue("@Withdrawal_Date", dateWithdrawal.Value.ToString("yyyy/MM/dd"));
                    cinema.com.ExecuteNonQuery();
                    MessageBox.Show("Movie has been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cinema.conn.Close();
                    DisplayMovies();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Movie duration must have format HH:MM:SS","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Failed to add movie... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FillGenres()
        {
            Main cinema = new Main();
            string select_genres = "SELECT * FROM GENRE WHERE Genre_ID = " + spinFill_GenreID.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_genres, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    txtDescription.Text = dr.GetValue(1).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Genre_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to fill inputs with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillMovies()
        {
            Main cinema = new Main();
            string select_movies = "SELECT * FROM MOVIE WHERE Movie_ID = " + spinMovie_ID.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_movies, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    txtMovie.Text = dr.GetValue(1).ToString();
                    spinGenre_ID.Value = int.Parse(dr.GetValue(2).ToString());
                    txtDuration.Text = dr.GetValue(3).ToString();
                    cmbAge.SelectedItem = dr.GetValue(4).ToString();
                    dateRelease.Value = DateTime.Parse(dr.GetValue(5).ToString());
                    dateWithdrawal.Value = DateTime.Parse(dr.GetValue(6).ToString());
                }
                else
                {
                    MessageBox.Show("Please enter a valid Snack_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to fill inputs with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGenres()
        {
            if (CheckEmptyGenreInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                cinema.conn = new SqlConnection(connection);
                string select_genres = "SELECT * FROM GENRE WHERE Genre_ID = " + spinFill_GenreID.Value.ToString() + ";";
                string update_genres = $"UPDATE GENRE SET Genre_Description = '{txtDescription.Text}' WHERE Genre_ID = {spinFill_GenreID.Value.ToString()}";
                cinema.com = new SqlCommand(update_genres, cinema.conn);
                command = new SqlCommand(select_genres, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = command;
                cinema.adap.Fill(dt);
                try
                {
                    cinema.conn.Open();
                    if (dt.Rows.Count > 0)
                    {
                        cinema.com.ExecuteNonQuery();
                        cinema.conn.Close();
                        DisplayGenres();
                        MessageBox.Show("Movie Genre updated successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The selected Genre_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + " Failed to update Genre...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateMovies()
        {
            if (CheckEmptyMovieInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                cinema.conn = new SqlConnection(connection);
                string select_movies = "SELECT * FROM MOVIE WHERE Movie_ID = " + spinMovie_ID.Value.ToString() + ";";
                string update_movies = $"UPDATE MOVIE SET Movie_Name = '{txtMovie.Text}', Genre_ID = {spinGenre_ID.Value}, Movie_Duration = '{txtDuration.Text}'," +
                $"Age_Restriction = '{cmbAge.SelectedItem.ToString()}', " +
                $"Release_Date = '{dateRelease.Value.ToString("yyyy/MM/dd")}', Withdrawal_Date = '{dateWithdrawal.Value.ToString("yyyy/MM/dd")}' WHERE Movie_ID = {spinMovie_ID.Value.ToString()}";
                cinema.com = new SqlCommand(update_movies, cinema.conn);
                command = new SqlCommand(select_movies, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = command;
                cinema.adap.Fill(dt);
                try
                {
                    cinema.conn.Open();
                    if (dt.Rows.Count > 0)
                    {
                        cinema.com.ExecuteNonQuery();
                        cinema.conn.Close();
                        DisplayMovies();
                        MessageBox.Show("Movie updates successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The selected Movie_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Movie duration must have format HH:MM:SS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + " Failed to update movie...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteGenre()
        {
            Main cinema = new Main();
            string select_genre = "SELECT * FROM GENRE WHERE Genre_ID = " + spinDel_GenreID.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_genre = "DELETE FROM GENRE WHERE Genre_ID = " + spinDel_GenreID.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_genre, cinema.conn);
                cmd = new SqlCommand(delete_genre, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Movie Genre was deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayGenres();
                }
                else
                {
                    MessageBox.Show("Genre_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sql_err)
            {
                int err_num = sql_err.Number;
                if (err_num == 547)
                {
                    MessageBox.Show($"Failed to delete record... Please delete all records in Movies with Genre_ID {spinDel_GenreID.Value}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(sql_err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMovie()
        {
            Main cinema = new Main();
            string select_movies = "SELECT * FROM MOVIE WHERE Movie_ID = " + spinDel_MovieID.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_movie = "DELETE FROM MOVIE WHERE Movie_ID = " + spinDel_MovieID.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_movies, cinema.conn);
                cmd = new SqlCommand(delete_movie, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Movie was deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayMovies();
                }
                else
                {
                    MessageBox.Show("Movie_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAllMovies()
        {
            Main cinema = new Main();
            string select_movies = "SELECT * FROM MOVIE WHERE Genre_ID = " + spinDeleteAll_Movies.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_all = "DELETE FROM MOVIE WHERE Genre_ID = " + spinDeleteAll_Movies.Value.ToString();
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
                    MessageBox.Show($"Movies with Genre_ID {spinDeleteAll_Movies.Value} deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayMovies();
                }
                else
                {
                    MessageBox.Show("Genre_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete selected records...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Movie_Click(object sender, EventArgs e)
        {
            AddMovies();
        }

        private void btnFill_Movie_Click(object sender, EventArgs e)
        {
            FillMovies();
        }

        private void btnUpdate_Movie_Click(object sender, EventArgs e)
        {
            UpdateMovies();
        }

        private void btnDelete_Movie_Click(object sender, EventArgs e)
        {
            DeleteMovie();
        }

        private void btnAdd_Genre_Click(object sender, EventArgs e)
        {
            AddGenres();
        }

        private void btnUpdate_Genre_Click(object sender, EventArgs e)
        {
            UpdateGenres();
        }

        private void btnFill_Genres_Click(object sender, EventArgs e)
        {
            FillGenres();
        }

        private void btnDelete_Genres_Click(object sender, EventArgs e)
        {
            DeleteGenre();
        }

        private void btnDelete_AllMovies_Click(object sender, EventArgs e)
        {
            DeleteAllMovies();
        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            if (!txtDuration.Text.Contains(':'))
            {
                MessageBox.Show("Please enter Movie duration in format HH:MM:SS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAge_Validating(object sender, CancelEventArgs e)
        {
            if (cmbAge.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an age restriction...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateRelease_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Compare(dateRelease.Value,dateWithdrawal.Value) >= 0)
            {
                MessageBox.Show("Release date cannot be after or on Withdrawal date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateWithdrawal_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Compare(dateWithdrawal.Value, dateRelease.Value) <= 0)
            {
                MessageBox.Show("Withdrawal date cannot be before or on Release date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Movie Genre cannot contain numbers...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main_GUI = new Main();
            main_GUI.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main_GUI = new Main();
            main_GUI.ShowDialog();
        }

        private void btnDelAllBookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteAllBookings del_Bookings = new DeleteAllBookings();
            del_Bookings.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhoneNum.Text = "";
            txtSurname.Text = "";
            txtTicket_Total.Text = "";
            spinCustID.Value = 0;
            spinDel_Booking.Value = 0;
            spinDel_CustID.Value = 0;
            spinFill_BookingID.Value = 0;
            spinFill_Customer.Value = 0;
            spinNumOfSeats.Value = 0;
            spinMovieID.Value = 0;
        }

        private void btnClearMovies_Click(object sender, EventArgs e)
        {
            txtMovie.Text = "";
            txtDescription.Text = "";
            txtDuration.Text = "";
            spinDeleteAll_Movies.Value = 0;
            spinDel_GenreID.Value = 0;
            spinDel_MovieID.Value = 0;
            spinFill_GenreID.Value = 0;
            spinGenre_ID.Value = 0;
            spinMovie_ID.Value = 0;
            cmbAge.SelectedIndex = -1;
            dateRelease.Value = DateTime.Now;
            dateWithdrawal.Value = DateTime.Now.AddDays(7);
        }

    }
}
